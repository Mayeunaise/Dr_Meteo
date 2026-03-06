namespace Dr_Meteo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Panel_Accueil = new Panel();
            Barre_Recherche = new TextBox();
            Loupe = new PictureBox();
            Bouton_Loc = new Button();
            Panel_Meteo_Ville = new Panel();
            Lbl_Uv_apres_demain = new Label();
            Lbl_MeteoDesc_apres_demain = new Label();
            lbl_Apres_demain = new Label();
            Lbl_Uv = new Label();
            Lbl_pressure = new Label();
            Aujourd_hui = new Label();
            Lbl_Speed_wind = new Label();
            Lbl_humidite = new Label();
            Lbl_MeteoDesc = new Label();
            Lbl_Temperature = new Label();
            Panel_Accueil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Loupe).BeginInit();
            Panel_Meteo_Ville.SuspendLayout();
            SuspendLayout();
            // 
            // Panel_Accueil
            // 
            Panel_Accueil.BackColor = SystemColors.ActiveCaption;
            Panel_Accueil.Controls.Add(Barre_Recherche);
            Panel_Accueil.Controls.Add(Loupe);
            Panel_Accueil.Controls.Add(Bouton_Loc);
            Panel_Accueil.Dock = DockStyle.Fill;
            Panel_Accueil.Location = new Point(0, 0);
            Panel_Accueil.Margin = new Padding(2);
            Panel_Accueil.Name = "Panel_Accueil";
            Panel_Accueil.Size = new Size(1053, 513);
            Panel_Accueil.TabIndex = 0;
            // 
            // Barre_Recherche
            // 
            Barre_Recherche.AccessibleName = "Barre_Recherche";
            Barre_Recherche.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Barre_Recherche.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Barre_Recherche.Location = new Point(134, 86);
            Barre_Recherche.Margin = new Padding(2);
            Barre_Recherche.Name = "Barre_Recherche";
            Barre_Recherche.ScrollBars = ScrollBars.Vertical;
            Barre_Recherche.Size = new Size(787, 23);
            Barre_Recherche.TabIndex = 0;
            // 
            // Loupe
            // 
            Loupe.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Loupe.BackgroundImageLayout = ImageLayout.Stretch;
            Loupe.Image = (Image)resources.GetObject("Loupe.Image");
            Loupe.Location = new Point(925, 86);
            Loupe.Margin = new Padding(2);
            Loupe.Name = "Loupe";
            Loupe.Size = new Size(23, 22);
            Loupe.TabIndex = 2;
            Loupe.TabStop = false;
            Loupe.Click += Loupe_Click;
            // 
            // Bouton_Loc
            // 
            Bouton_Loc.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Bouton_Loc.Image = Properties.Resources.gps__3_;
            Bouton_Loc.Location = new Point(109, 86);
            Bouton_Loc.Margin = new Padding(2);
            Bouton_Loc.Name = "Bouton_Loc";
            Bouton_Loc.Size = new Size(27, 24);
            Bouton_Loc.TabIndex = 1;
            Bouton_Loc.UseVisualStyleBackColor = true;
            Bouton_Loc.Click += Bouton_Loc_Click;
            // 
            // Panel_Meteo_Ville
            // 
            Panel_Meteo_Ville.Controls.Add(Lbl_Temperature);
            Panel_Meteo_Ville.Controls.Add(Lbl_VilleNom);
            Panel_Meteo_Ville.Dock = DockStyle.Fill;
            Panel_Meteo_Ville.Location = new Point(0, 0);
            Panel_Meteo_Ville.Name = "Panel_Meteo_Ville";
            Panel_Meteo_Ville.Size = new Size(1053, 513);
            Panel_Meteo_Ville.TabIndex = 3;
            Panel_Meteo_Ville.Paint += Panel_Meteo_Ville_Paint;
            // 
            // Lbl_VilleNom
            // 
            Lbl_VilleNom.AutoSize = true;
            Lbl_VilleNom.Location = new Point(272, 76);
            Lbl_VilleNom.Name = "Lbl_VilleNom";
            Lbl_VilleNom.Size = new Size(97, 20);
            Lbl_VilleNom.TabIndex = 0;
            Lbl_VilleNom.Text = "Lbl_VilleNom\r\n";
            // 
            // iconeMeteo_apres_demain
            // 
            Lbl_Temperature.AutoEllipsis = true;
            Lbl_Temperature.AutoSize = true;
            Lbl_Temperature.Location = new Point(105, 194);
            Lbl_Temperature.Name = "Lbl_Temperature";
            Lbl_Temperature.Size = new Size(50, 20);
            Lbl_Temperature.TabIndex = 1;
            Lbl_Temperature.Text = "label1";
            // 
            // Lbl_VilleNom
            // 
            Lbl_VilleNom.AutoSize = true;
            Lbl_VilleNom.Location = new Point(238, 57);
            Lbl_VilleNom.Name = "Lbl_VilleNom";
            Lbl_VilleNom.Size = new Size(77, 15);
            Lbl_VilleNom.TabIndex = 0;
            Lbl_VilleNom.Text = "Lbl_VilleNom\r\n";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1053, 513);
            Controls.Add(Panel_Meteo_Ville);
            Controls.Add(Panel_Accueil);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            Panel_Accueil.ResumeLayout(false);
            Panel_Accueil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Loupe).EndInit();
            Panel_Meteo_Ville.ResumeLayout(false);
            Panel_Meteo_Ville.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel Panel_Accueil;
        private TextBox Barre_Recherche;
        private PictureBox Loupe;
        private Button Bouton_Loc;
        private Panel Panel_Meteo_Ville;
        //Pour éviter de te faire chier, les éléments que tu placeras dans le Panel_Meteo_Ville, tu les renommeras commme ci-dessous pour ceux que ça concerne
        private Label Lbl_VilleNom;
        private Label Lbl_Temperature;
        private Label Lbl_MeteoDesc;
        private PictureBox iconeMeteo = new PictureBox();
    }
}
