namespace Dr_Meteo
{
    using System;
    using Newtonsoft.Json;
    using System.Data;
    using System.Net.Http;
    using System.Text.Json;
    using System.Windows.Forms;
    using System.Drawing;

    public partial class Form1 : Form
    {
        private string pseudoActuel = ""; // Variable pour stocker le pseudo de l'utilisateur connecté
        private const string BaseText = "Saisissez une Ville ou un code postal ex: Bordeaux, 33063";
        private string ville = "";

        public Form1()
        {
            InitializeComponent();
            CreerPanelMeteo();
            Form1_Load(null, null); // Appel manuel pour éviter les soucis de timing avec le designer
        }
        private void CreerPanelMeteo()
        {
            iconeMeteo.SizeMode = PictureBoxSizeMode.Zoom;
            Lbl_VilleNom.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            Lbl_VilleNom.AutoSize = false;
            iconeMeteo.Location = new Point(20, 20);
            iconeMeteo.Size = new Size(100, 100);
            pictureBox1.Size = new Size(100, 100);
            Lbl_Temperature.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            Lbl_Temperature.AutoSize = true;
            Lbl_MeteoDesc.Font = new Font("Segoe UI", 14);
            Lbl_MeteoDesc.AutoSize = true;
            Lbl_humidite.Font = new Font("Segeo UI", 14);
            Lbl_humidite.AutoSize = true;
            Lbl_Speed_wind.Font = new Font("Segeo UI", 14);
            Lbl_Speed_wind.AutoSize = true;
            Aujourd_hui.Font = new Font("Segoe UI", 14);
            Aujourd_hui.AutoSize = true;
            Aujourd_hui.Text = "Aujourd'hui";
            Lbl_pressure.Font = new Font("Segoe UI", 14);
            Lbl_pressure.AutoSize = true;
            Lbl_Uv.Font = new Font("Segoe UI", 14);
            Lbl_Uv.AutoSize = true;
            Lbl_lever_soleil.Font = new Font("Segoe UI", 14);
            Lbl_lever_soleil.AutoSize = true;
            Lbl_coucher_soleil.Font = new Font("Segoe UI", 14);
            Lbl_coucher_soleil.AutoSize = true;

            Lbl_Demain.Font = new Font("Segoe UI", 14);
            Lbl_Demain.AutoSize = true;
            Lbl_MeteoDesc_demain.Font = new Font("Segoe UI", 14);
            Lbl_MeteoDesc_demain.AutoSize = true;
            Lbl_Uv_demain.Font = new Font("Segoe UI", 14);
            Lbl_Uv_demain.AutoSize = true;
            iconeMeteo_demain.Size = new Size(100, 100);
            iconeMeteo_demain.SizeMode = PictureBoxSizeMode.Zoom;
            Lbl_temp_max_demain.Font = new Font("Segoe UI", 14);
            Lbl_temp_max_demain.AutoSize = true;
            Lbl_temp_min_demain.Font = new Font("Segoe UI", 14);
            Lbl_temp_min_demain.AutoSize = true;
            Lbl_diff_temp_ensoleilement_demain.Font = new Font("Segoe UI", 12);
            Lbl_diff_temp_ensoleilement_demain.AutoSize = true;
            Lbl_diff_sunset_demain.Font = new Font("Segoe UI", 12);
            Lbl_diff_sunset_demain.AutoSize = true;

            lbl_Apres_demain.Font = new Font("Segoe UI", 14);
            lbl_Apres_demain.AutoSize = true;
            Lbl_MeteoDesc_apres_demain.Font = new Font("Segoe UI", 14);
            Lbl_MeteoDesc_apres_demain.AutoSize = true;
            Lbl_Uv_apres_demain.Font = new Font("Segoe UI", 14);
            Lbl_Uv_apres_demain.AutoSize = true;
            iconeMeteo_apres_demain_bis.Size = new Size(100, 100);
            iconeMeteo_apres_demain_bis.Location = new Point(825, 20);
            iconeMeteo_apres_demain_bis.SizeMode = PictureBoxSizeMode.Zoom;
            Lbl_temp_max_apres_demain.Font = new Font("Segoe UI", 14);
            Lbl_temp_max_apres_demain.AutoSize = true;
            Lbl_temp_min_apres_demain.Font = new Font("Segoe UI", 14);
            Lbl_temp_min_apres_demain.AutoSize = true;
            Lbl_diff_temp_ensoleilement_apres_demain.Font = new Font("Segoe UI", 12);
            Lbl_diff_temp_ensoleilement_apres_demain.AutoSize = true;
            Lbl_diff_sunset_apres_demain.Font = new Font("Segoe UI", 12);
            Lbl_diff_sunset_apres_demain.AutoSize = true;


            Lbl_j_3.Font = new Font("Segoe UI", 14);
            Lbl_j_3.AutoSize = true;
            Lbl_min_j3.Font = new Font("Segoe UI", 14);
            Lbl_min_j3.AutoSize = true;
            Lbl_max_j3.Font = new Font("Segoe UI", 14);
            Lbl_max_j3.AutoSize = true;
            iconeMeteo_j3.Size = new Size(25, 25);
            iconeMeteo_j3.SizeMode = PictureBoxSizeMode.Zoom;


            Lbl_j_4.Font = new Font("Segoe UI", 14);
            Lbl_j_4.AutoSize = true;
            Lbl_min_j4.Font = new Font("Segoe UI", 14);
            Lbl_min_j4.AutoSize = true;
            Lbl_max_j4.Font = new Font("Segoe UI", 14);
            Lbl_max_j4.AutoSize = true;
            iconeMeteo_j4.Size = new Size(25, 25);
            iconeMeteo_j4.SizeMode = PictureBoxSizeMode.Zoom;


            Lbl_j_5.Font = new Font("Segoe UI", 14);
            Lbl_j_5.AutoSize = true;
            Lbl_min_j5.Font = new Font("Segoe UI", 14);
            Lbl_min_j5.AutoSize = true;
            Lbl_max_j5.Font = new Font("Segoe UI", 14);
            Lbl_max_j5.AutoSize = true;
            iconeMeteo_j5.Size = new Size(25, 25);
            iconeMeteo_j5.SizeMode = PictureBoxSizeMode.Zoom;


            Lbl_j_6.Font = new Font("Segoe UI", 14);
            Lbl_j_6.AutoSize = true;
            Lbl_min_j6.Font = new Font("Segoe UI", 14);
            Lbl_min_j6.AutoSize = true;
            Lbl_max_j6.Font = new Font("Segoe UI", 14);
            Lbl_max_j6.AutoSize = true;
            iconeMeteo_j6.Size = new Size(25, 25);
            iconeMeteo_j6.SizeMode = PictureBoxSizeMode.Zoom;


        }
        private async void Form1_Load(object sender, EventArgs e)
        {
            //Gestion des Panels
            Panel_Accueil.Visible = true;
            FondPanelRandom(Panel_Accueil);
            Panel_Header.Parent = Panel_Accueil;
            Panel_Meteo_Ville.Visible = false;
            Panel_Inscription.Visible = false;
            Panel_Configuration.Visible = false;
            Panel_Connection.Visible = false;
            // On indique visuellement à l'utilisateur que l'application se prépare
            Barre_Recherche.Enabled = false;
            Barre_Recherche.Text = "Téléchargement des villes de France...";

            GestionBdd bdd = new GestionBdd();

            //Création de la Bdd
            GestionBdd.InitialiserBase();

            //Insertion des villes en BDD (si pas déjà fait)
            await bdd.ImporterVillesDepuisApiGouv();

            //Barre de recherche disponible
            Barre_Recherche.Enabled = true;
            InitializeSearchBar();
        }
        private void InitializeSearchBar()
        {
            Barre_Recherche.Text = BaseText;
            Barre_Recherche.ForeColor = Color.Gray;

            //Gestion des entrées et sorties du curseur sur la barre de recherche
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

            //Gestion de la saisie avec soit le nom de la ville soit le code postal
            var villes = GestionBdd.GetVilles();
            AutoCompleteStringCollection collectionVille = new AutoCompleteStringCollection();

            Barre_Recherche.AutoCompleteSource = AutoCompleteSource.CustomSource;
            Barre_Recherche.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            foreach (DataRow row in villes.Rows)
            {
                if (row["Nom"] != DBNull.Value)
                {
                    string nom = row["Nom"].ToString();
                    string cpText = row["CodePostal"] != DBNull.Value ? row["CodePostal"].ToString() : "";

                    if (!string.IsNullOrWhiteSpace(cpText))
                    {
                        // Si la ville a plusieurs codes (ex: "75001, 75002"), on les sépare
                        string[] listeCodes = cpText.Split(',');

                        // 1. Sens normal : "Ville , CodePostal"
                        collectionVille.Add(nom + " , " + listeCodes[0].Trim());

                        // 2. Sens inverse (Miroir) : "CodePostal , Ville"
                        foreach (string code in listeCodes)
                        {
                            collectionVille.Add(code.Trim() + " , " + nom);
                        }
                    }
                    else
                    {
                        // S'il n'y a pas de code postal du tout
                        collectionVille.Add(nom);
                    }
                }
            }

            Barre_Recherche.AutoCompleteCustomSource = collectionVille;

            //Gestion de la touche "Entrée" pour lancer la recherche
            Barre_Recherche.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.SuppressKeyPress = true; // Stop le "Bip"

                    string texteSaisi = Barre_Recherche.Text;
                    string villeReelle = texteSaisi;

                    //Si le texte contient " , "
                    if (texteSaisi.Contains(" , "))
                    {
                        //On coupe en deux parties (avant et après le séparateur)
                        string[] morceaux = texteSaisi.Split(new string[] { " , " }, StringSplitOptions.None);
                        string partie1 = morceaux[0].Trim();
                        string partie2 = morceaux[1].Trim();

                        //On vérifie si la première partie est un nombre (le Code Postal)
                        if (int.TryParse(partie1, out _))
                        {
                            //Si partie1 = code postal, alors la ville est la partie2
                            villeReelle = partie2;
                        }
                        else
                        {
                            //Sinon, la ville est la partie1
                            villeReelle = partie1;
                        }
                    }

                    //On remet la barre propre avec juste le nom de la ville
                    Barre_Recherche.Text = villeReelle;

                    if (GestionBdd.VilleExiste(villeReelle))
                    {
                        //On lance la recherche
                        AfficherMeteo(villeReelle);
                        ville = villeReelle;
                    }
                    else
                    {
                        MessageBox.Show("Ville non reconnue ! Assurez-vous d'avoir sélectionné une ville dans la liste déroulante.");
                    }

                }
            };
        }

        private async void AfficherMeteo(string villeSaisie)
        {
            if (string.IsNullOrWhiteSpace(villeSaisie) || villeSaisie == BaseText) return;

            VilleData villeBdd = GestionBdd.RecupererVille(villeSaisie);

            //On vérifie si les données en BDD sont encore valides (moins de 30 minutes) pour éviter les appels API inutiles
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
                //On utilise les données en cache
                System.Diagnostics.Debug.WriteLine("Données depuis le CACHE BDD");
                ReponseMeteo reponseMeteo = JsonConvert.DeserializeObject<ReponseMeteo>(villeBdd.DonneesJson);
                MettreAJourInterface(villeBdd.Nom, reponseMeteo);
            }
            else
            {
                //Appel API pour obtenir les données fraîches
                System.Diagnostics.Debug.WriteLine("Appel API...");
                ServiceMeteo service = new ServiceMeteo();

                //On trouve les coordonnées (si on ne les a pas déjà en BDD)
                double lat = (villeBdd != null && villeBdd.Latitude != 0) ? villeBdd.Latitude : 0;
                double lon = (villeBdd != null && villeBdd.Longitude != 0) ? villeBdd.Longitude : 0;


                //On prend la météo
                var meteo = await service.ObtenirMeteo(lat, lon);
                if (meteo != null)
                {
                    string json_meteo = JsonConvert.SerializeObject(meteo);
                    //Sauvegarde en BDD (Mise en cache)
                    GestionBdd.MajVille(villeSaisie, lat, lon, json_meteo);

                    //Affichage
                    MettreAJourInterface(villeSaisie, meteo);
                }
            }
        }
        private void MettreAJourInterface(string ville, ReponseMeteo reponseMeteo)
        {
            //Affichage du panel météo
            Panel_Accueil.Visible = false;
            Panel_Configuration.Visible = false;
            Panel_Connection.Visible = false;
            Panel_Inscription.Visible = false;
            FondPanel(Panel_Meteo_Ville, reponseMeteo.current.code_meteo);
            Panel_Header.Parent = Panel_Meteo_Ville;
            Panel_Meteo_Ville.Visible = true;
            // Les propriétés (current_weather.temperature, etc.) sont à adapter selon comment tu as nommé les variables dans ta classe ReponseMeteo
            Lbl_VilleNom.Text = ville;
            Lbl_Temperature.Text = $"{reponseMeteo.current.temperature} °C";
            Lbl_MeteoDesc.Text = TraduireCodeMeteo(reponseMeteo.current.code_meteo);
            Lbl_humidite.Text = $"{reponseMeteo.current.humidity} % d'humidité";
            Lbl_Speed_wind.Text = $"{reponseMeteo.current.windspeed} km/h";
            Lbl_pressure.Text = $"{reponseMeteo.current.pressure} hPa";
            Lbl_Uv.Text = $"Indice UV : {reponseMeteo.daily.uv_index_max[0]}";
            Lbl_Uv.ForeColor = TraduireCodeUV(reponseMeteo.daily.uv_index_max[0]);
            iconeMeteo.Image = ChoixImage(reponseMeteo.current.code_meteo);
            pictureBox1.Image = ChoixImage(reponseMeteo.current.code_meteo);
            Lbl_temp_max.Text = $"Max : {reponseMeteo.daily.temperature_max[0]} °C";
            Lbl_temp_min.Text = $"Min : {reponseMeteo.daily.temperature_min[0]} °C";
            Lbl_lever_soleil.Text = "Lever : " + Traduire_heures_soleil(reponseMeteo.daily.sunrise[0]);
            Lbl_coucher_soleil.Text = "Coucher : " + Traduire_heures_soleil(reponseMeteo.daily.sunset[0]);


            Lbl_Demain.Text = "Demain";
            Lbl_MeteoDesc_demain.Text = TraduireCodeMeteo(reponseMeteo.daily.weather_code[1]);
            Lbl_Uv_demain.Text = $"Indice UV : {reponseMeteo.daily.uv_index_max[1]}";
            Lbl_Uv_demain.ForeColor = TraduireCodeUV(reponseMeteo.daily.uv_index_max[1]);
            iconeMeteo_demain.Image = ChoixImage(reponseMeteo.daily.weather_code[1]);
            iconeMeteo_demain.Location = new Point(525, 20);
            Lbl_temp_max_demain.Text = $"Temperature Max : {reponseMeteo.daily.temperature_max[1]} °C";
            Lbl_temp_min_demain.Text = $"Temperature Min : {reponseMeteo.daily.temperature_min[1]} °C";
            Lbl_diff_temp_ensoleilement_demain.Text = DiffTempEnsoleilement(reponseMeteo.daily.sunrise[1], reponseMeteo.daily.sunrise[0]);
            Lbl_diff_sunset_demain.Text = Diff_sunset(reponseMeteo.daily.sunset[1], reponseMeteo.daily.sunset[0]);


            lbl_Apres_demain.Text = "Après demain";
            Lbl_MeteoDesc_apres_demain.Text = TraduireCodeMeteo(reponseMeteo.daily.weather_code[2]);
            Lbl_Uv_apres_demain.Text = $"Indice UV : {reponseMeteo.daily.uv_index_max[2]}";
            Lbl_Uv_apres_demain.ForeColor = TraduireCodeUV(reponseMeteo.daily.uv_index_max[2]);
            iconeMeteo_apres_demain_bis.Image = ChoixImage(reponseMeteo.daily.weather_code[2]);
            iconeMeteo_apres_demain_bis.Location = new Point(950, 20);
            Lbl_temp_max_apres_demain.Text = $"Temperature Max : {reponseMeteo.daily.temperature_max[2]} °C";
            Lbl_temp_min_apres_demain.Text = $"Temperature Min : {reponseMeteo.daily.temperature_min[2]} °C";
            Lbl_diff_temp_ensoleilement_apres_demain.Text = DiffTempEnsoleilement(reponseMeteo.daily.sunrise[2], reponseMeteo.daily.sunrise[1]);
            Lbl_diff_sunset_apres_demain.Text = Diff_sunset(reponseMeteo.daily.sunset[2], reponseMeteo.daily.sunset[1]);


            Lbl_j_3.Text = Date(reponseMeteo.daily.time[3]);
            Lbl_min_j3.Text = $"Min : {reponseMeteo.daily.temperature_min[3]} °C";
            Lbl_max_j3.Text = $"Max : {reponseMeteo.daily.temperature_max[3]} °C";
            iconeMeteo_j3.Image = ChoixImage(reponseMeteo.daily.weather_code[3]);

            Lbl_j_4.Text = Date(reponseMeteo.daily.time[4]);
            Lbl_min_j4.Text = $"Min : {reponseMeteo.daily.temperature_min[4]} °C";
            Lbl_max_j4.Text = $"Max : {reponseMeteo.daily.temperature_max[4]} °C";
            iconeMeteo_j4.Image = ChoixImage(reponseMeteo.daily.weather_code[4]);

            Lbl_j_5.Text = Date(reponseMeteo.daily.time[5]);
            Lbl_min_j5.Text = $"Min : {reponseMeteo.daily.temperature_min[5]} °C";
            Lbl_max_j5.Text = $"Max : {reponseMeteo.daily.temperature_max[5]} °C";
            iconeMeteo_j5.Image = ChoixImage(reponseMeteo.daily.weather_code[5]);


            Lbl_j_6.Text = Date(reponseMeteo.daily.time[6]);
            Lbl_min_j6.Text = $"Min : {reponseMeteo.daily.temperature_min[6]} °C";
            Lbl_max_j6.Text = $"Max : {reponseMeteo.daily.temperature_max[6]} °C";
            iconeMeteo_j6.Image = ChoixImage(reponseMeteo.daily.weather_code[6]);

            Lbl_conseil.Text = GenererRecommandationVetements(reponseMeteo.current.temperature, reponseMeteo.current.code_meteo);
        }

        private string TraduireCodeMeteo(int code)
        {
            if (code == 0) return "Ciel dégagé";
            if (code >= 1 && code <= 3) return "Nuageux";
            if (code >= 45 && code <= 48) return "Brouillard";
            if (code >= 51 && code <= 67) return "Pluie";
            if (code >= 71 && code <= 77) return "Neige";
            if (code >= 95) return "Orage";
            return "Variable";
        }

        private Color TraduireCodeUV(double uv)
        {
            if (uv >= 0 && uv <= 2) return Color.Green;
            if (uv >= 3 && uv <= 5) return Color.Orange;
            if (uv >= 6 && uv <= 7) return Color.Red;
            if (uv >= 8 && uv <= 10) return Color.Purple;
            if (uv >= 11) return Color.Maroon;
            return Color.Black;
        }

        private static Image ChoixImage(int code)
        {
            if (code == 0) return Properties.Resources.soleil;
            if (code >= 1 && code <= 3) return Properties.Resources.nuageux;
            if (code >= 45 && code <= 48) return Properties.Resources.brouillard;
            if (code >= 51 && code <= 67) return Properties.Resources.pluvieux;
            if (code >= 71 && code <= 77) return Properties.Resources.neigeux;
            if (code >= 95) return Properties.Resources.tempete;
            else return Properties.Resources.soleil;
        }
        private static void FondPanel(Panel panel, int code)
        {
            if (code == 0) panel.BackgroundImage = Properties.Resources.ciel_bleu;
            else if (code >= 1 && code <= 3) panel.BackgroundImage = Properties.Resources.ciel_nuageux;
            else if (code >= 45 && code <= 48) panel.BackgroundImage = Properties.Resources.ciel_brouillard;
            else if (code >= 51 && code <= 67) panel.BackgroundImage = Properties.Resources.ciel_pluvieux;
            else if (code >= 71 && code <= 77) panel.BackgroundImage = Properties.Resources.ciel_neige;
            else if (code >= 95) panel.BackgroundImage = Properties.Resources.ciel_orageux;
            else panel.BackgroundImage = Properties.Resources.ciel_bleu;
            panel.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private static void FondPanelRandom(Panel panel)
        {
            Random var = new Random();
            int code = var.Next(0, 5); //Vu qu'on a 6 images, ça nous fait 6 valeurs
            if (code == 0)
            {
                panel.BackgroundImage = Properties.Resources.ciel_bleu;
            }
            else if (code == 1)
            {
                panel.BackgroundImage = Properties.Resources.ciel_nuageux;
            }
            else if (code == 2)
            {
                panel.BackgroundImage = Properties.Resources.ciel_brouillard;
            }
            else if (code == 3)
            {
                panel.BackgroundImage = Properties.Resources.ciel_pluvieux;
            }
            else if (code == 4)
            {
                panel.BackgroundImage = Properties.Resources.ciel_neige;
            }
            else if (code == 5)
            {
                panel.BackgroundImage = Properties.Resources.ciel_orageux;
            }
            else panel.BackgroundImage = Properties.Resources.ciel_bleu;
            panel.BackgroundImageLayout = ImageLayout.Stretch;

        }
        private string Traduire_heures_soleil(string heure)
        {
            // La fonction reçoit une heure au format "2024-06-01T05:30:00"
            // On veut extraire "05:30"
            try
            {
                DateTime dt = DateTime.Parse(heure);
                return dt.ToString("HH:mm");
            }
            catch
            {
                return heure; // En cas d'erreur, on retourne la chaîne d'origine
            }
        }
        //Fonction calcul difference Lever de soleil
        private string DiffTempEnsoleilement(string temp_j1, string temp_j2)
        {
            int min_j1, min_j2, h_j1, h_j2;
            string rep;
            DateTime dt = DateTime.Parse(temp_j1);
            int.TryParse(dt.ToString("mm"), out min_j1);
            int.TryParse(dt.ToString("HH"), out h_j1);
            DateTime dt2 = DateTime.Parse(temp_j2);
            int.TryParse(dt2.ToString("mm"), out min_j2);
            int.TryParse(dt2.ToString("HH"), out h_j2);
            if (h_j1 == h_j2)
            {
                if (min_j1 <= min_j2)
                {
                    rep = $"Lever de soleil plus tard de {min_j2 - min_j1} min";
                }
                else
                {
                    rep = $"Lever de soleil plus tot de {min_j1 - min_j2} min";
                }
            }
            else if (h_j1 < h_j2)
            {
                rep = $"Lever de soleil plus tard de {60 - (min_j1 - min_j2)} min";
            }
            else
            {
                rep = $"Lever de soleil plus tot de {60 - (min_j2 - min_j1)} min";
            }
            return rep;
        }
        // Idem que pour le lever de soleil, mais coucher de soleil  
        private string Diff_sunset(string temp_j1, string temp_j2)
        {
            int min_j1, min_j2, h_j1, h_j2;
            string rep;
            DateTime dt = DateTime.Parse(temp_j1);
            int.TryParse(dt.ToString("mm"), out min_j1);
            int.TryParse(dt.ToString("HH"), out h_j1);
            DateTime dt2 = DateTime.Parse(temp_j2);
            int.TryParse(dt2.ToString("mm"), out min_j2);
            int.TryParse(dt2.ToString("HH"), out h_j2);
            if (h_j1 == h_j2)
            {
                if (min_j1 <= min_j2)
                {
                    rep = $"Coucher de soleil plus tot de {min_j2 - min_j1} min";
                }
                else
                {
                    rep = $"Coucher de soleil plus tard de {min_j1 - min_j2} min";
                }
            }
            else if (h_j1 < h_j2)
            {
                rep = $"Coucher de soleil plus tot de {60 - (min_j1 - min_j2)} min";
            }
            else
            {
                rep = $"Coucher de soleil plus tard de {60 - (min_j2 - min_j1)} min";
            }
            return rep;
        }

        private string Date(string jour)
        {
            string jj_mm_aa;
            DateTime dt = DateTime.Parse(jour);
            jj_mm_aa = dt.ToString("D");
            return jj_mm_aa;
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

        //Menu hamburger
        private void toolBar_Click(object sender, EventArgs e)
        {
            menuHamburger.Show(toolBar, new Point(0, toolBar.Height));
        }

        private void changerDeVilleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Panel_Accueil.Visible = true;
            FondPanelRandom(Panel_Accueil);
            Panel_Header.Parent = Panel_Accueil;
            Panel_Meteo_Ville.Visible = false;
            Panel_Inscription.Visible = false;
            Panel_Configuration.Visible = false;
            Panel_Connection.Visible = false;

            textBoxMdpConnection.Text = "";
            textBoxMdp.Text = "";
            textBoxMdpConf.Text = "";
        }

        private void sinscrireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Gestion des Panels
            FondPanelRandom(Panel_Inscription);
            Panel_Header.Parent = Panel_Inscription;
            Panel_Inscription.Visible = true;
            Panel_Meteo_Ville.Visible = false;
            Panel_Accueil.Visible = false;
            Panel_Connection.Visible = false;
            Panel_Configuration.Visible = false;
            bouton_Inscription.Visible = false;
            textBoxUname.Focus();
            //Gestion des évènements
            textBoxUname.KeyDown += textBoxUname_KeyDown;
            textBoxMdp.KeyDown += textBoxMdp_KeyDown;
            textBoxMdpConf.KeyDown += textBoxMdpConf_KeyDown;

            textBoxMdpConnection.Text = "";
            textBoxMdp.Text = "";
            textBoxMdpConf.Text = "";

        }
        private void textBoxUname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                if (!string.IsNullOrWhiteSpace(textBoxUname.Text) && textBoxUname.Text != "Saisissez votre nom d'utilisateur")
                {
                    if (GestionBdd.UtilisateurExiste(textBoxUname.Text))
                    {
                        MessageBox.Show("Ce nom d'utilisateur existe déjà ! Choisissez-en un autre.");
                        textBoxUname.Text = "";
                        textBoxUname.Focus();
                        return;
                    }
                    //Username valide, on procede à la suite de l'inscription
                    Lbl_Mdp.Visible = true;
                    textBoxMdp.Visible = true;
                    textBoxMdp.Focus();
                    pseudoActuel = textBoxUname.Text; //On stocke le pseudo pour la suite
                }
                else
                {
                    MessageBox.Show("Nom d'utilisateur invalide !");
                }
            }
        }
        private void textBoxMdp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                if (!string.IsNullOrWhiteSpace(textBoxMdp.Text))
                {
                    Lbl_Conf_Mdp.Visible = true;
                    textBoxMdpConf.Visible = true;
                    textBoxMdpConf.Focus();
                }
            }
        }
        private void textBoxMdpConf_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                if (textBoxMdp.Text == textBoxMdpConf.Text)
                {
                    string pseudo = textBoxUname.Text;
                    string mdp = textBoxMdp.Text;

                    GestionBdd.CreerUtilisateur(pseudo, mdp, "");
                    MessageBox.Show($"Bienvenue {pseudo} ! Votre compte est créé.");
                    DialogResult reponse = MessageBox.Show(
                    "Voulez-vous renseigner votre e-mail et une ou plusieurs ville(s) favorite(s) afin d'être alerté en cas d'alerte orange ou rouge ?",
                    "Poursuite d'inscription",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                    if (reponse == DialogResult.Yes)
                    {
                        LancerPhaseConfigAlertes();
                        textBoxMdpConf.Text = ""; // On vide la case pour éviter que le mot de passe soit visible
                        textBoxMdp.Text = "";
                    }
                    else
                    {
                        bouton_Inscription.Visible = true;
                    }
                }
                else
                {
                    MessageBox.Show("Les mots de passe ne correspondent pas ! Réessayez.");
                    textBoxMdpConf.Text = ""; // On vide la case pour qu'il recommence
                    textBoxMdpConf.Focus();
                }
            }
        }
        private void LancerPhaseConfigAlertes()
        {
            //Gestion des Panels
            Panel_Inscription.Visible = false;
            Panel_Accueil.Visible = false;
            Panel_Connection.Visible = false;
            Panel_Meteo_Ville.Visible = false;
            FondPanelRandom(Panel_Configuration);
            Panel_Configuration.Visible = true;
            Panel_Header.Parent = Panel_Configuration;
            //Gestion des évènements
            textBoxEmail.KeyDown += textBoxEmail_KeyDown;
            textBoxVilleFavorite.KeyDown += textBoxVilleFavorite_KeyDown;
            //Affichage des éléments de configuration
            Lbl_EMail.Visible = true;
            textBoxEmail.Visible = true;
            textBoxEmail.Text="";
            textBoxVilleFavorite.Visible = false;
            textBoxVilleFavorite.Text = "";

            textBoxEmail.Focus();
        }
        private void textBoxEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                string email = textBoxEmail.Text;

                //Vérification basique pour voir si ça ressemble à un e-mail
                if (email.Contains("@") && email.Contains("."))
                {
                    //On enregistre l'e-mail dans la base
                    GestionBdd.EnregistrerEmail(pseudoActuel, email);

                    //On passe à la ville favorite
                    InitializeVilleFavoriteBar();
                    Lbl_VilleFavorite.Visible = true;
                    textBoxVilleFavorite.Visible = true;
                    textBoxVilleFavorite.Focus();
                }
                else
                {
                    MessageBox.Show("Veuillez saisir une adresse e-mail valide (avec un @ et .).");
                }
            }
        }
        private void textBoxVilleFavorite_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                string villeFav = textBoxVilleFavorite.Text;

                if (!string.IsNullOrWhiteSpace(villeFav))
                {
                    GestionBdd.AjouterVilleFavorite(pseudoActuel, villeFav);

                    MessageBox.Show("Configuration terminée ! Vous serez alerté en cas de vigilance Orange ou Rouge.");
                    if (string.IsNullOrWhiteSpace(ville))
                    {
                        Panel_Configuration.Visible = false;
                        Panel_Accueil.Visible = true; //Affichez l'interface normale après configuration
                        Panel_Header.Parent = Panel_Accueil;
                    }
                    else
                    {
                        Panel_Configuration.Visible = false;
                        Panel_Meteo_Ville.Visible = true;
                        Panel_Header.Parent = Panel_Meteo_Ville;
                    }
                }
            }
        }
        private void InitializeVilleFavoriteBar()
        {
            //Reprends la même logique que pour la barre de recherche classique pour l'auto-complétion, mais appliquée à la textBoxVilleFavorite
            var villes = GestionBdd.GetVilles();
            AutoCompleteStringCollection collectionVille = new AutoCompleteStringCollection();

            textBoxVilleFavorite.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBoxVilleFavorite.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            foreach (DataRow row in villes.Rows)
            {
                if (row["Nom"] != DBNull.Value)
                {
                    string nom = row["Nom"].ToString();
                    string cpText = row["CodePostal"] != DBNull.Value ? row["CodePostal"].ToString() : "";

                    if (!string.IsNullOrWhiteSpace(cpText))
                    {
                        string[] listeCodes = cpText.Split(',');

                        collectionVille.Add(nom + " , " + listeCodes[0].Trim());

                        foreach (string code in listeCodes)
                        {
                            collectionVille.Add(code.Trim() + " , " + nom);
                        }
                    }
                    else
                    {
                        collectionVille.Add(nom);
                    }
                }
            }

            textBoxVilleFavorite.AutoCompleteCustomSource = collectionVille;

            textBoxVilleFavorite.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.SuppressKeyPress = true;

                    string texteSaisi = textBoxVilleFavorite.Text;
                    string villeReelle = texteSaisi;

                    if (texteSaisi.Contains(" , "))
                    {
                        string[] morceaux = texteSaisi.Split(new string[] { " , " }, StringSplitOptions.None);
                        string partie1 = morceaux[0].Trim();
                        string partie2 = morceaux[1].Trim();

                        if (int.TryParse(partie1, out _))
                        {
                            villeReelle = partie2;
                        }
                        else
                        {
                            villeReelle = partie1;
                        }
                    }
                }
            };
        }

        private void seConnecterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Panel_Meteo_Ville.Visible = false;
            Panel_Inscription.Visible = false;
            Panel_Configuration.Visible = false;
            Panel_Accueil.Visible = false;
            textBoxUconnection.KeyDown += textBoxUconnection_KeyDown;
            textBoxMdpConnection.KeyDown += textBoxMdpConnection_KeyDown;
            FondPanelRandom(Panel_Connection);
            Panel_Header.Parent = Panel_Connection;
            Panel_Connection.Visible = true;
            textBoxUconnection.Focus();

            textBoxMdpConnection.Text = "";
            textBoxMdp.Text = "";
            textBoxMdpConf.Text = "";
        }
        private void textBoxUconnection_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                if (!string.IsNullOrWhiteSpace(textBoxUconnection.Text) && textBoxUconnection.Text != "Saisissez votre nom d'utilisateur")
                {
                    if (!GestionBdd.UtilisateurExiste(textBoxUconnection.Text))
                    {
                        MessageBox.Show("Ce nom d'utilisateur n'existe pas ! Veuillez vous inscrire.");
                        textBoxUconnection.Text = "";
                        textBoxUconnection.Focus();
                        return;
                    }
                    //Username existant, on procede à la suite de la connexion
                    Lbl_Mdp_Connection.Visible = true;
                    textBoxMdpConnection.Visible = true;
                    textBoxMdpConnection.Focus();
                    pseudoActuel = textBoxUconnection.Text; //On stocke le pseudo pour la suite
                }
                else
                {
                    MessageBox.Show("Nom d'utilisateur invalide !");
                }
            }

        }
        private void textBoxMdpConnection_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                if (!string.IsNullOrWhiteSpace(textBoxMdpConnection.Text))
                {
                    //Vérification des identifiants
                    if (GestionBdd.VerifierIdentifiants(pseudoActuel, textBoxMdpConnection.Text))
                    {
                        MessageBox.Show($"Bienvenue {pseudoActuel} !");
                        if (!string.IsNullOrEmpty(GestionBdd.GetEmail(pseudoActuel)))
                        {
                            if (string.IsNullOrWhiteSpace(ville))
                            {
                                Panel_Connection.Visible = false;
                                Panel_Accueil.Visible = true;
                                Panel_Header.Parent = Panel_Accueil;
                            }
                            else
                            {
                                Panel_Connection.Visible = false;
                                Panel_Meteo_Ville.Visible = true;
                                Panel_Header.Parent = Panel_Meteo_Ville;
                            }
                        }
                        else
                        {
                            DialogResult reponse = MessageBox.Show(
                            "Voulez-vous renseigner votre e-mail et une ou plusieurs ville(s) favorite(s) afin d'être alerté en cas d'alerte orange ou rouge ?",
                            "Poursuite d'inscription",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);
                            if (reponse == DialogResult.Yes)
                            {
                                LancerPhaseConfigAlertes();
                            }
                            else
                            {
                                if (string.IsNullOrWhiteSpace(ville))
                                {
                                    Panel_Connection.Visible = false;
                                    Panel_Accueil.Visible = true;
                                    Panel_Header.Parent = Panel_Accueil;
                                }
                                else
                                {
                                    Panel_Connection.Visible = false;
                                    Panel_Meteo_Ville.Visible = true;
                                    Panel_Header.Parent = Panel_Meteo_Ville;
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mot de passe incorrect !");
                        textBoxMdpConnection.Text = "";
                        textBoxMdpConnection.Focus();
                    }
                }
                textBoxMdpConnection.Text = "";
            }
        }

        private string GenererRecommandationVetements(double temperature, int codeMeteo)
        {
            string conseil = "";

            if (temperature <= 5)
            {
                conseil += "Il fait très froid ! Sortez le gros manteau d'hiver, l'écharpe et les gants.\n";
            }
            else if (temperature > 5 && temperature <= 15)
            {
                conseil += "Il fait un peu frais. Une veste de mi-saison ou un bon pull sera parfait.\n";
            }
            else if (temperature > 15 && temperature <= 25)
            {
                conseil += "Température agréable ! Un t-shirt avec un jean ou pantalon léger feront l'affaire.\n";
            }
            else
            {
                conseil += "Il fait chaud ! Privilégiez une tenue très légère (short, t-shirt) et hydratez-vous bien.\n";
            }

            if ((codeMeteo >= 51 && codeMeteo <= 67) || (codeMeteo >= 80 && codeMeteo <= 82) || codeMeteo >= 95)
            {
                conseil += "Attention, il pleut. N'oubliez pas votre parapluie ou un imperméable !\n";
            }
            else if ((codeMeteo >= 71 && codeMeteo <= 77) || (codeMeteo >= 85 && codeMeteo <= 86))
            {
                conseil += "Il neige ! Mettez des chaussures chaudes et antidérapantes.\n";
            }
            else if ((codeMeteo == 0 || codeMeteo == 1) && temperature >= 20)
            {
                conseil += "Grand soleil ! C'est le moment de sortir les lunettes de soleil (et la crème !).\n";
            }

            return conseil;
        }

        private void Lbl_min_j5_Click(object sender, EventArgs e)
        {

        }

        private void iconeMeteo_j5_Click(object sender, EventArgs e)
        {

        }

        private void bouton_Inscription_Click(object sender, EventArgs e)
        {
            DialogResult reponse = MessageBox.Show(
                    "Voulez-vous renseigner votre e-mail et une ou plusieurs ville(s) favorite(s) afin d'être alerté en cas d'alerte orange ou rouge ?",
                    "Poursuite d'inscription",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
            if (reponse == DialogResult.Yes)
            {
                LancerPhaseConfigAlertes();
            }
        }
    }


}

