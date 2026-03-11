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
            Lbl_MeteoDesc = new Label();
            Lbl_Uv = new Label();
            Lbl_Temperature = new Label();
            Lbl_humidite = new Label();
            Lbl_MeteoDesc_apres_demain = new Label();
            Lbl_pressure = new Label();
            Lbl_Speed_wind = new Label();
            lbl_Apres_demain = new Label();
            Lbl_Uv_apres_demain = new Label();
            Aujourd_hui = new Label();
            Lbl_VilleNom = new Label();
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
            Panel_Accueil.Margin = new Padding(2, 4, 2, 4);
            Panel_Accueil.Name = "Panel_Accueil";
            Panel_Accueil.Size = new Size(1504, 855);
            Panel_Accueil.TabIndex = 0;
            // 
            // Barre_Recherche
            // 
            Barre_Recherche.AccessibleName = "Barre_Recherche";
            Barre_Recherche.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Barre_Recherche.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Barre_Recherche.Location = new Point(191, 144);
            Barre_Recherche.Margin = new Padding(2, 4, 2, 4);
            Barre_Recherche.Name = "Barre_Recherche";
            Barre_Recherche.ScrollBars = ScrollBars.Vertical;
            Barre_Recherche.Size = new Size(1123, 31);
            Barre_Recherche.TabIndex = 0;
            // 
            // Loupe
            // 
            Loupe.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Loupe.BackgroundImageLayout = ImageLayout.Stretch;
            Loupe.Image = (Image)resources.GetObject("Loupe.Image");
            Loupe.Location = new Point(1321, 144);
            Loupe.Margin = new Padding(2, 4, 2, 4);
            Loupe.Name = "Loupe";
            Loupe.Size = new Size(32, 36);
            Loupe.TabIndex = 2;
            Loupe.TabStop = false;
            Loupe.Click += Loupe_Click;
            // 
            // Bouton_Loc
            // 
            Bouton_Loc.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Bouton_Loc.Image = Properties.Resources.gps__3_;
            Bouton_Loc.Location = new Point(156, 144);
            Bouton_Loc.Margin = new Padding(2, 4, 2, 4);
            Bouton_Loc.Name = "Bouton_Loc";
            Bouton_Loc.Size = new Size(39, 40);
            Bouton_Loc.TabIndex = 1;
            Bouton_Loc.UseVisualStyleBackColor = true;
            Bouton_Loc.Click += Bouton_Loc_Click;
            // 
            // Panel_Meteo_Ville
            // 
            Panel_Meteo_Ville.Controls.Add(Lbl_VilleNom);
            Panel_Meteo_Ville.Controls.Add(Lbl_MeteoDesc);
            Panel_Meteo_Ville.Controls.Add(Lbl_Uv);
            Panel_Meteo_Ville.Controls.Add(Lbl_Temperature);
            Panel_Meteo_Ville.Controls.Add(Lbl_humidite);
            Panel_Meteo_Ville.Controls.Add(Lbl_MeteoDesc_apres_demain);
            Panel_Meteo_Ville.Controls.Add(Lbl_pressure);
            Panel_Meteo_Ville.Controls.Add(Lbl_Speed_wind);
            Panel_Meteo_Ville.Controls.Add(lbl_Apres_demain);
            Panel_Meteo_Ville.Controls.Add(Lbl_Uv_apres_demain);
            Panel_Meteo_Ville.Controls.Add(Aujourd_hui);
            Panel_Meteo_Ville.Dock = DockStyle.Fill;
            Panel_Meteo_Ville.Location = new Point(0, 0);
            Panel_Meteo_Ville.Margin = new Padding(4, 5, 4, 5);
            Panel_Meteo_Ville.Name = "Panel_Meteo_Ville";
            Panel_Meteo_Ville.Size = new Size(1504, 855);
            Panel_Meteo_Ville.TabIndex = 3;
            Panel_Meteo_Ville.Paint += Panel_Meteo_Ville_Paint;
            // 
            // Lbl_MeteoDesc
            // 
            Lbl_MeteoDesc.Location = new Point(605, 154);
            Lbl_MeteoDesc.Margin = new Padding(4, 0, 4, 0);
            Lbl_MeteoDesc.Name = "Lbl_MeteoDesc";
            Lbl_MeteoDesc.Size = new Size(218, 29);
            Lbl_MeteoDesc.TabIndex = 0;
            Lbl_MeteoDesc.Text = "Lbl_MeteoDesc";
            // 
            // Lbl_Uv
            // 
            Lbl_Uv.Location = new Point(366, 226);
            Lbl_Uv.Margin = new Padding(4, 0, 4, 0);
            Lbl_Uv.Name = "Lbl_Uv";
            Lbl_Uv.Size = new Size(125, 29);
            Lbl_Uv.TabIndex = 0;
            Lbl_Uv.Text = "Lbl_Uv";
            Lbl_Uv.Click += Lbl_Uv_Click;
            // 
            // Lbl_Temperature
            // 
            Lbl_Temperature.AutoEllipsis = true;
            Lbl_Temperature.AutoSize = true;
            Lbl_Temperature.Location = new Point(175, 126);
            Lbl_Temperature.Margin = new Padding(4, 0, 4, 0);
            Lbl_Temperature.Name = "Lbl_Temperature";
            Lbl_Temperature.Size = new Size(140, 25);
            Lbl_Temperature.TabIndex = 1;
            Lbl_Temperature.Text = "Lbl_Temperature";
            // 
            // Lbl_humidite
            // 
            Lbl_humidite.Location = new Point(1075, 282);
            Lbl_humidite.Margin = new Padding(4, 0, 4, 0);
            Lbl_humidite.Name = "Lbl_humidite";
            Lbl_humidite.Size = new Size(125, 29);
            Lbl_humidite.TabIndex = 0;
            Lbl_humidite.Text = "Lbl_humidite";
            // 
            // Lbl_MeteoDesc_apres_demain
            // 
            Lbl_MeteoDesc_apres_demain.Location = new Point(550, 318);
            Lbl_MeteoDesc_apres_demain.Margin = new Padding(4, 0, 4, 0);
            Lbl_MeteoDesc_apres_demain.Name = "Lbl_MeteoDesc_apres_demain";
            Lbl_MeteoDesc_apres_demain.Size = new Size(272, 29);
            Lbl_MeteoDesc_apres_demain.TabIndex = 0;
            Lbl_MeteoDesc_apres_demain.Text = "Lbl_MeteoDesc_apres_demain";
            // 
            // Lbl_pressure
            // 
            Lbl_pressure.Location = new Point(282, 349);
            Lbl_pressure.Margin = new Padding(4, 0, 4, 0);
            Lbl_pressure.Name = "Lbl_pressure";
            Lbl_pressure.Size = new Size(125, 29);
            Lbl_pressure.TabIndex = 0;
            Lbl_pressure.Text = "Lbl_pressure";
            // 
            // Lbl_Speed_wind
            // 
            Lbl_Speed_wind.Location = new Point(379, 121);
            Lbl_Speed_wind.Margin = new Padding(4, 0, 4, 0);
            Lbl_Speed_wind.Name = "Lbl_Speed_wind";
            Lbl_Speed_wind.Size = new Size(174, 29);
            Lbl_Speed_wind.TabIndex = 0;
            Lbl_Speed_wind.Text = "Lbl_Speed_wind";
            // 
            // lbl_Apres_demain
            // 
            lbl_Apres_demain.Location = new Point(586, 75);
            lbl_Apres_demain.Margin = new Padding(4, 0, 4, 0);
            lbl_Apres_demain.Name = "lbl_Apres_demain";
            lbl_Apres_demain.Size = new Size(212, 29);
            lbl_Apres_demain.TabIndex = 0;
            lbl_Apres_demain.Text = "lbl_Apres_demain";
            // 
            // Lbl_Uv_apres_demain
            // 
            Lbl_Uv_apres_demain.Location = new Point(685, 226);
            Lbl_Uv_apres_demain.Margin = new Padding(4, 0, 4, 0);
            Lbl_Uv_apres_demain.Name = "Lbl_Uv_apres_demain";
            Lbl_Uv_apres_demain.Size = new Size(198, 29);
            Lbl_Uv_apres_demain.TabIndex = 0;
            Lbl_Uv_apres_demain.Text = "Lbl_Uv_apres_demain";
            Lbl_Uv_apres_demain.Click += Lbl_Uv_apres_demain_Click;
            // 
            // Aujourd_hui
            // 
            Aujourd_hui.Location = new Point(499, 226);
            Aujourd_hui.Margin = new Padding(4, 0, 4, 0);
            Aujourd_hui.Name = "Aujourd_hui";
            Aujourd_hui.Size = new Size(125, 29);
            Aujourd_hui.TabIndex = 0;
            Aujourd_hui.Text = "Aujourd_hui";
            Aujourd_hui.Click += Aujourd_hui_Click;
            // 
            // Lbl_VilleNom
            // 
            Lbl_VilleNom.AutoSize = true;
            Lbl_VilleNom.Location = new Point(150, 20);
            Lbl_VilleNom.Name = "Lbl_VilleNom";
            Lbl_VilleNom.Size = new Size(114, 25);
            Lbl_VilleNom.TabIndex = 2;
            Lbl_VilleNom.Text = "Lbl_VilleNom";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1504, 855);
            Controls.Add(Panel_Meteo_Ville);
            Controls.Add(Panel_Accueil);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 4, 2, 4);
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
        private Label Lbl_VilleNom;
        private Label Lbl_Temperature;
        private Label Lbl_MeteoDesc;
        private PictureBox iconeMeteo = new PictureBox();
        private Label Lbl_humidite;
        private Label Lbl_Speed_wind;
        private Label Lbl_pressure;
        private Label Lbl_Uv;
        private Label Aujourd_hui;
        private Label lbl_Apres_demain;
        private Label Lbl_MeteoDesc_apres_demain;
        private Label Lbl_Uv_apres_demain;
        private Label Lbl_MeteoDesc_demain;
        private Label Lbl_Uv_demain;
        private PictureBox iconeMeteo_apres_demain = new PictureBox();
    }
}
