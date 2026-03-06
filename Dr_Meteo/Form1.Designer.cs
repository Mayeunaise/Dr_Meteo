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
            Lbl_Temperature = new Label();
            Lbl_Uv = new Label();
            Lbl_humidite = new Label();
            Lbl_MeteoDesc = new Label();
            Lbl_MeteoDesc_apres_demain = new Label();
            Lbl_pressure = new Label();
            Lbl_Speed_wind = new Label();
            lbl_Apres_demain = new Label();
            Lbl_Uv_apres_demain = new Label();
            Aujourd_hui = new Label();
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
            Panel_Accueil.Margin = new Padding(2, 3, 2, 3);
            Panel_Accueil.Name = "Panel_Accueil";
            Panel_Accueil.Size = new Size(1203, 684);
            Panel_Accueil.TabIndex = 0;
            // 
            // Barre_Recherche
            // 
            Barre_Recherche.AccessibleName = "Barre_Recherche";
            Barre_Recherche.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Barre_Recherche.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Barre_Recherche.Location = new Point(153, 115);
            Barre_Recherche.Margin = new Padding(2, 3, 2, 3);
            Barre_Recherche.Name = "Barre_Recherche";
            Barre_Recherche.ScrollBars = ScrollBars.Vertical;
            Barre_Recherche.Size = new Size(899, 27);
            Barre_Recherche.TabIndex = 0;
            // 
            // Loupe
            // 
            Loupe.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Loupe.BackgroundImageLayout = ImageLayout.Stretch;
            Loupe.Image = (Image)resources.GetObject("Loupe.Image");
            Loupe.Location = new Point(1057, 115);
            Loupe.Margin = new Padding(2, 3, 2, 3);
            Loupe.Name = "Loupe";
            Loupe.Size = new Size(26, 29);
            Loupe.TabIndex = 2;
            Loupe.TabStop = false;
            Loupe.Click += Loupe_Click;
            // 
            // Bouton_Loc
            // 
            Bouton_Loc.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Bouton_Loc.Image = Properties.Resources.gps__3_;
            Bouton_Loc.Location = new Point(125, 115);
            Bouton_Loc.Margin = new Padding(2, 3, 2, 3);
            Bouton_Loc.Name = "Bouton_Loc";
            Bouton_Loc.Size = new Size(31, 32);
            Bouton_Loc.TabIndex = 1;
            Bouton_Loc.UseVisualStyleBackColor = true;
            Bouton_Loc.Click += Bouton_Loc_Click;
            // 
            // Panel_Meteo_Ville
            // 
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
            Panel_Meteo_Ville.Controls.Add(iconeMeteo);
            Panel_Meteo_Ville.Controls.Add(Lbl_VilleNom);
            Panel_Meteo_Ville.Controls.Add(iconeMeteo_apres_demain);
            Panel_Meteo_Ville.Controls.Add(Lbl_MeteoDesc_demain);
            Panel_Meteo_Ville.Controls.Add(Lbl_Uv_demain);
            
            Panel_Meteo_Ville.Dock = DockStyle.Fill;
            Panel_Meteo_Ville.Location = new Point(0, 0);
            Panel_Meteo_Ville.Margin = new Padding(3, 4, 3, 4);
            Panel_Meteo_Ville.Name = "Panel_Meteo_Ville";
            Panel_Meteo_Ville.Size = new Size(1203, 684);
            Panel_Meteo_Ville.TabIndex = 3;
            Panel_Meteo_Ville.Paint += Panel_Meteo_Ville_Paint;
            // 
            // Lbl_Temperature
            // 
            Lbl_Temperature.AutoEllipsis = true;
            Lbl_Temperature.AutoSize = true;
            Lbl_Temperature.Location = new Point(140, 101);
            Lbl_Temperature.Name = "Lbl_Temperature";
            Lbl_Temperature.Size = new Size(50, 20);
            Lbl_Temperature.TabIndex = 1;
            Lbl_Temperature.Text = "label1";
            // 
            // Lbl_Uv
            // 
            Lbl_Uv.Location = new Point(293, 181);
            Lbl_Uv.Name = "Lbl_Uv";
            Lbl_Uv.Size = new Size(100, 23);
            Lbl_Uv.TabIndex = 0;
            Lbl_Uv.Text = "Lbl_Uv";
            Lbl_Uv.Click += Lbl_Uv_Click;
            // 
            // Lbl_humidite
            // 
            Lbl_humidite.Location = new Point(860, 226);
            Lbl_humidite.Name = "Lbl_humidite";
            Lbl_humidite.Size = new Size(100, 23);
            Lbl_humidite.TabIndex = 0;
            Lbl_humidite.Text = "Lbl_humidite";
            // 
            // Lbl_MeteoDesc
            // 
            Lbl_MeteoDesc.Location = new Point(484, 123);
            Lbl_MeteoDesc.Name = "Lbl_MeteoDesc";
            Lbl_MeteoDesc.Size = new Size(174, 23);
            Lbl_MeteoDesc.TabIndex = 0;
            Lbl_MeteoDesc.Text = "Lbl_MeteoDesc";
            // 
            // Lbl_MeteoDesc_apres_demain
            // 
            Lbl_MeteoDesc_apres_demain.Location = new Point(440, 254);
            Lbl_MeteoDesc_apres_demain.Name = "Lbl_MeteoDesc_apres_demain";
            Lbl_MeteoDesc_apres_demain.Size = new Size(218, 23);
            Lbl_MeteoDesc_apres_demain.TabIndex = 0;
            Lbl_MeteoDesc_apres_demain.Text = "Lbl_MeteoDesc_apres_demain";
            // 
            // Lbl_pressure
            // 
            Lbl_pressure.Location = new Point(226, 279);
            Lbl_pressure.Name = "Lbl_pressure";
            Lbl_pressure.Size = new Size(100, 23);
            Lbl_pressure.TabIndex = 0;
            Lbl_pressure.Text = "Lbl_pressure";
            // 
            // Lbl_Speed_wind
            // 
            Lbl_Speed_wind.Location = new Point(303, 97);
            Lbl_Speed_wind.Name = "Lbl_Speed_wind";
            Lbl_Speed_wind.Size = new Size(139, 23);
            Lbl_Speed_wind.TabIndex = 0;
            Lbl_Speed_wind.Text = "Lbl_Speed_wind";
            // 
            // lbl_Apres_demain
            // 
            lbl_Apres_demain.Location = new Point(469, 60);
            lbl_Apres_demain.Name = "lbl_Apres_demain";
            lbl_Apres_demain.Size = new Size(170, 23);
            lbl_Apres_demain.TabIndex = 0;
            lbl_Apres_demain.Text = "lbl_Apres_demain";
            // 
            // Lbl_Uv_apres_demain
            // 
            Lbl_Uv_apres_demain.Location = new Point(548, 181);
            Lbl_Uv_apres_demain.Name = "Lbl_Uv_apres_demain";
            Lbl_Uv_apres_demain.Size = new Size(158, 23);
            Lbl_Uv_apres_demain.TabIndex = 0;
            Lbl_Uv_apres_demain.Text = "Lbl_Uv_apres_demain";
            Lbl_Uv_apres_demain.Click += Lbl_Uv_apres_demain_Click;
            // 
            // Aujourd_hui
            // 
            Aujourd_hui.Location = new Point(399, 181);
            Aujourd_hui.Name = "Aujourd_hui";
            Aujourd_hui.Size = new Size(100, 23);
            Aujourd_hui.TabIndex = 0;
            Aujourd_hui.Text = "Aujourd_hui";
            Aujourd_hui.Click += Aujourd_hui_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1203, 684);
            Controls.Add(Panel_Meteo_Ville);
            Controls.Add(Panel_Accueil);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 3, 2, 3);
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
