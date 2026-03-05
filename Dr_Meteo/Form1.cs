namespace Dr_Meteo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using System.Data;
    using System.Net.Http;
    using System.Text.Json;
    using System.Windows.Forms;
    using System.Drawing;

    public partial class Form1 : Form
    {
        private const string BaseText = "Saisissez une Ville ou un code postal ex: Bordeaux, 33063";
        private string ville = "";
        
        public Form1()
        {
            InitializeComponent();
            CreerPanelMeteo();
            Form1_Load(null, null); // Appel manuel pour éviter les soucis de timing avec le designer
            InitializeSearchBar();
        }
        private void CreerPanelMeteo()
        {
            Panel_Meteo_Ville = new Panel
            {
                Size = new Size(400, 250),
                Location = new Point(50, 100), // Ajuste la position selon ton design
                BackColor = Color.AliceBlue,
                Visible = false
            };
            iconeMeteo.Size = new Size(100, 100);
            iconeMeteo.Location = new Point(20, 20);
            iconeMeteo.SizeMode = PictureBoxSizeMode.Zoom;
            Lbl_VilleNom = new Label { Font = new Font("Segoe UI", 18, FontStyle.Bold), Location = new Point(20, 20), AutoSize = true };
            Lbl_Temperature = new Label { Font = new Font("Segoe UI", 28, FontStyle.Bold), Location = new Point(20, 70), AutoSize = true };
            Lbl_MeteoDesc = new Label { Font = new Font("Segoe UI", 14), Location = new Point(20, 140), AutoSize = true };

            Panel_Meteo_Ville.Controls.Add(Lbl_VilleNom);
            Panel_Meteo_Ville.Controls.Add(Lbl_Temperature);
            Panel_Meteo_Ville.Controls.Add(Lbl_MeteoDesc);
            Panel_Meteo_Ville.Controls.Add(iconeMeteo);

            this.Controls.Add(Panel_Meteo_Ville);
        }
        private async void Form1_Load(object sender, EventArgs e)
        {
            // On indique visuellement à l'utilisateur que l'application se prépare
            Barre_Recherche.Enabled = false;
            Barre_Recherche.Text = "Téléchargement des villes de France...";

            GestionBdd bdd = new GestionBdd();

            // 1. Crée les tables si elles n'existent pas
            GestionBdd.InitialiserBase();

            // 2. Télécharge et insère les villes (seulement si la base est vide)
            await bdd.ImporterVillesDepuisApiGouv();

            // 3. On remet la barre de recherche à la normale et on charge l'autocomplétion
            Barre_Recherche.Enabled = true;
            InitializeSearchBar(); // Votre méthode qui remplit l'AutoCompleteCustomSource
        }
        private void InitializeSearchBar()
        {
            Barre_Recherche.Text = BaseText;
            Barre_Recherche.ForeColor = Color.Gray;

            // Événements visuels
            Barre_Recherche.Enter += (s, e) =>
            {
                if (Barre_Recherche.Text == BaseText)
                {
                    Barre_Recherche.Text = "";
                    Barre_Recherche.ForeColor = Color.Black;
                }
            };
            Barre_Recherche.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(Barre_Recherche.Text))
                {
                    Barre_Recherche.Text = BaseText;
                    Barre_Recherche.ForeColor = Color.Gray;
                }
            };

            // Autocomplétion depuis la BDD
            GestionBdd bdd = new GestionBdd();
            var villes = GestionBdd.GetVilles();
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            foreach (DataRow row in villes.Rows)
            {
                if (row[0] != null)
                    collection.Add(row[0].ToString());
            }

            Barre_Recherche.AutoCompleteCustomSource = collection;
            Barre_Recherche.AutoCompleteSource = AutoCompleteSource.CustomSource;
            Barre_Recherche.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            // Touche Entrée
            Barre_Recherche.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.SuppressKeyPress = true; // Stop le "Bip"
                    AfficherMeteo(Barre_Recherche.Text);
                }
            };
        }

        private void RetirerBaseText(object? sender, EventArgs e)
        {
            if (Barre_Recherche.Text == BaseText)
            {
                Barre_Recherche.Text = "";
                Barre_Recherche.ForeColor = Color.Gray;
            }
        }


        private void RajouterBaseText(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Barre_Recherche.Text))
            {
                Barre_Recherche.Text = BaseText;
                Barre_Recherche.ForeColor = Color.Green;
            }
        }       

        // Fonction liée à l'événement KeyDown de votre TextBox (txtRecherche)
        private void BarreRecherche_KeyDown(object? sender, KeyEventArgs e)
        {
            // On vérifie si la touche appuyée est "Entrée"
            if (e.KeyCode == Keys.Enter)
            {
                // Empêche le "bip" système désagréable windows et le saut de ligne
                //e.SuppressKeyPress = true;

                // Récupération du texte saisi
                string villeSaisie = Barre_Recherche.Text;

                // Validation : On ne lance pas la recherche si vide ou si c'est le texte gris
                if (!(string.IsNullOrWhiteSpace(villeSaisie)) && villeSaisie != BaseText)
                {
                    AfficherMeteo(villeSaisie);
                }
            }
        }

        // Fonction personnalisée pour changer d'écran
        private async void AfficherMeteo(string villeSaisie)
        {
            if (string.IsNullOrWhiteSpace(villeSaisie) || villeSaisie == BaseText) return;

            VilleData villeBdd = GestionBdd.RecupererVille(villeSaisie);

            // --- LOGIQUE DU CACHE (30 minutes) ---
            bool cacheValide = false;
            if (villeBdd != null)
            {
                TimeSpan age = DateTime.Now - villeBdd.DerniereMaj;
                if (age.TotalMinutes < 30 && villeBdd.DerniereMaj != DateTime.MinValue)
                {
                    cacheValide = true;
                }
            }

            if (cacheValide)
            {
                // CAS 1 : On utilise la BDD (Pas d'internet)
                System.Diagnostics.Debug.WriteLine("Données depuis le CACHE BDD");
                ReponseMeteo reponseMeteo = JsonConvert.DeserializeObject<ReponseMeteo>(villeBdd.DonneesJson);
                MettreAJourInterface(villeBdd.Nom, reponseMeteo);
            }
            else
            {
                // CAS 2 : On appelle l'API
                System.Diagnostics.Debug.WriteLine("Appel API...");
                ServiceMeteo service = new ServiceMeteo();

                // A. On trouve les coordonnées (si on ne les a pas déjà en BDD)
                double lat = (villeBdd != null && villeBdd.Latitude != 0) ? villeBdd.Latitude : 0;
                double lon = (villeBdd != null && villeBdd.Longitude != 0) ? villeBdd.Longitude : 0;
                VilleResultat geo = null;
                if (lat == 0 || lon == 0)
                {
                    geo = await service.ChercherVille(villeSaisie);
                    if (geo == null)
                    {
                        MessageBox.Show("Ville introuvable !");
                        return;
                    }
                    lat = geo.latitude;
                    lon = geo.longitude;
                    // On garde le "vrai" nom officiel (ex: "Paris" avec majuscule)
                    villeSaisie = geo.name;
                }

                // B. On prend la météo
                var meteo = await service.ObtenirMeteo(lat, lon);
                if (meteo != null)
                {
                    string json_meteo = JsonConvert.SerializeObject(meteo);
                    string ListeCodesPostaux = "";
                    if (geo != null && geo.codePostal != null && geo.codePostal.Count > 0)
                    {
                        // string.Join va créer un texte du type : "75001, 75002, 75003"
                        ListeCodesPostaux = string.Join(", ", geo.codePostal);
                    }
                    // C. On sauvegarde en BDD (Mise en cache)
                    GestionBdd.MajVille(villeSaisie, ListeCodesPostaux, lat, lon, json_meteo);

                    // D. Affichage
                    MettreAJourInterface(villeSaisie, meteo);
                }
            }
        }
        private void MettreAJourInterface(string ville, ReponseMeteo reponseMeteo)
        {
            //Affichage du panel météo
            // Les propriétés (current_weather.temperature, etc.) sont à adapter selon comment tu as nommé les variables dans ta classe ReponseMeteo
            Lbl_VilleNom.Text = ville;
            Lbl_Temperature.Text = $"{reponseMeteo.current.temperature} °C";
            Lbl_MeteoDesc.Text = TraduireCodeMeteo(reponseMeteo.current.code_meteo);
            //On vérifie quelle image on va afficher
            if (reponseMeteo.current.code_meteo==0)
            {
                iconeMeteo.Image = Image.FromFile("Ressources\\soleil.png");
            }
            Panel_Accueil.Visible = false;
            Panel_Meteo_Ville.Visible = true;

        }

        private string TraduireCodeMeteo(int code)
        {
            if (code == 0) return "Ciel dégagé ??";
            if (code >= 1 && code <= 3) return "Nuageux ??";
            if (code >= 45 && code <= 48) return "Brouillard ???";
            if (code >= 51 && code <= 67) return "Pluie ?";
            if (code >= 71 && code <= 77) return "Neige ??";
            if (code >= 95) return "Orage ?";
            return "Variable";
        }



        private async void Bouton_Loc_Click(object sender, EventArgs e)
        {
            DialogResult reponse = MessageBox.Show(
            "Pouvons-nous accéder à votre localisation ?",
            "Demande de localisation",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (reponse == DialogResult.Yes)
            {
                //Utilisation d'une API pour la position
                using var client = new HttpClient();
                string json = await client.GetStringAsync("https://ipinfo.io/json");

                //On découpe le retour pour avoir juste city
                JsonDocument requete_json = JsonDocument.Parse(json);
                JsonElement root = requete_json.RootElement;
                ville = root.GetProperty("city").GetString();
                Barre_Recherche.Text = ville;
            }
        }

        private void Loupe_Click(object sender, EventArgs e)
        {
            string villeSaisie = Barre_Recherche.Text;
            AfficherMeteo(villeSaisie);
        }

        









    }

}

