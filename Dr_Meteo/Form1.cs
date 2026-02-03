namespace Dr_Meteo
{
    public partial class Form1 : Form
    {
        private const string BaseText = "Saisissez une Ville ou un code postal ex: Bordeaux, 33063";
        public Form1()
        {
            InitializeComponent();
            InitializeSearchBar();
        }

        private void InitializeSearchBar()
        {
            Barre_Recherche.Text = BaseText;
            Barre_Recherche.ForeColor = Color.Gray;

            Barre_Recherche.GotFocus += RetirerBaseText;
            Barre_Recherche.LostFocus += RajouterBaseText;
            ChargerVillesTest();
            Barre_Recherche.KeyDown += BarreRecherche_KeyDown;
        }

        private void RetirerBaseText(object sender, EventArgs e)
        {
            if (Barre_Recherche.Text == BaseText)
            {
                Barre_Recherche.Text = "";
                Barre_Recherche.ForeColor = Color.Gray;
            }
        }


        private void RajouterBaseText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Barre_Recherche.Text))
            {
                Barre_Recherche.Text = BaseText;
                Barre_Recherche.ForeColor = Color.Green;
            }
        }
        // Dans Form1.cs

        private void ChargerVillesTest()
        {
            // Création de la collection
            AutoCompleteStringCollection dataCollection = new AutoCompleteStringCollection();

            // Ajout manuel (juste pour tester le design)
            dataCollection.AddRange(new string[] {
        "Bordeaux", "Paris", "Lyon", "Marseille", "Lille",
        "Toulouse", "Nice", "Nantes", "Strasbourg", "Montpellier", "L'Étrat"
    });

            // Liaison avec la barre de recherche (txtRecherche est le nom de votre TextBox)
            Barre_Recherche.AutoCompleteCustomSource = dataCollection;
        }

        private void BoutonLoc_Click(object sender, EventArgs e)
        {
            DialogResult reponse = MessageBox.Show(
            "Pouvons-nous accéder à votre localisation ?",
            "Demande de localisation",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (reponse == DialogResult.Yes)
            {
                Barre_Recherche.Text = "Lille";
            }
        }

        // Fonction liée à l'événement KeyDown de votre TextBox (txtRecherche)
        private void BarreRecherche_KeyDown(object sender, KeyEventArgs e)
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
        private void AfficherMeteo(string ville)
        {
            // 1. Cacher l'écran d'accueil ("Tout s'efface")
            Panel_Accueil.Visible = false;

            // 2. Remplir les données (Simulé pour l'instant)
            // Ici, plus tard, vous appellerez votre API
            //lblVille.Text = ville;
            // lblTemperature.Text = "15°C"; 

            // 3. Afficher l'écran météo
            Panel_Accueil.Visible = true;

            // Optionnel : Changer le fond de la fenêtre si nécessaire
            // this.BackgroundImage = Properties.Resources.FondPluvieux;
        }





        // N'oubliez pas d'appeler cette fonction dans le constructeur public Form1() !

    }
}
