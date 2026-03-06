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
            Lbl_VilleNom = new Label();
            iconeMeteo_apres_demain = new PictureBox();
            Panel_Accueil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Loupe).BeginInit();
            Panel_Meteo_Ville.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconeMeteo_apres_demain).BeginInit();
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
            Panel_Accueil.Size = new Size(1203, 684);
            Panel_Accueil.TabIndex = 0;
            // 
            // Barre_Recherche
            // 
            Barre_Recherche.AccessibleName = "Barre_Recherche";
            Barre_Recherche.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Barre_Recherche.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Barre_Recherche.Location = new Point(153, 114);
            Barre_Recherche.Margin = new Padding(2);
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
            Loupe.Location = new Point(1057, 114);
            Loupe.Margin = new Padding(2);
            Loupe.Name = "Loupe";
            Loupe.Size = new Size(26, 30);
            Loupe.TabIndex = 2;
            Loupe.TabStop = false;
            Loupe.Click += Loupe_Click;
            // 
            // Bouton_Loc
            // 
            Bouton_Loc.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Bouton_Loc.Image = Properties.Resources.gps__3_;
            Bouton_Loc.Location = new Point(125, 114);
            Bouton_Loc.Margin = new Padding(2);
            Bouton_Loc.Name = "Bouton_Loc";
            Bouton_Loc.Size = new Size(31, 32);
            Bouton_Loc.TabIndex = 1;
            Bouton_Loc.UseVisualStyleBackColor = true;
            Bouton_Loc.Click += Bouton_Loc_Click;
            // 
            // Panel_Meteo_Ville
            // 
            Panel_Meteo_Ville.Controls.Add(iconeMeteo_apres_demain);
            Panel_Meteo_Ville.Controls.Add(Lbl_Uv_apres_demain);
            Panel_Meteo_Ville.Controls.Add(Lbl_MeteoDesc_apres_demain);
            Panel_Meteo_Ville.Controls.Add(lbl_Apres_demain);
            Panel_Meteo_Ville.Controls.Add(Lbl_Uv);
            Panel_Meteo_Ville.Controls.Add(Lbl_pressure);
            Panel_Meteo_Ville.Controls.Add(Aujourd_hui);
            Panel_Meteo_Ville.Controls.Add(Lbl_Speed_wind);
            Panel_Meteo_Ville.Controls.Add(Lbl_humidite);
            Panel_Meteo_Ville.Controls.Add(Lbl_MeteoDesc);
            Panel_Meteo_Ville.Controls.Add(Lbl_Temperature);
            Panel_Meteo_Ville.Controls.Add(Lbl_VilleNom);
            Panel_Meteo_Ville.Dock = DockStyle.Fill;
            Panel_Meteo_Ville.Location = new Point(0, 0);
            Panel_Meteo_Ville.Margin = new Padding(3, 4, 3, 4);
            Panel_Meteo_Ville.Name = "Panel_Meteo_Ville";
            Panel_Meteo_Ville.Size = new Size(1203, 684);
            Panel_Meteo_Ville.TabIndex = 3;
            Panel_Meteo_Ville.Paint += Panel_Meteo_Ville_Paint;
            // 
            // Lbl_Uv_apres_demain
            // 
            Lbl_Uv_apres_demain.AutoSize = true;
            Lbl_Uv_apres_demain.Location = new Point(671, 348);
            Lbl_Uv_apres_demain.Name = "Lbl_Uv_apres_demain";
            Lbl_Uv_apres_demain.Size = new Size(150, 20);
            Lbl_Uv_apres_demain.TabIndex = 11;
            Lbl_Uv_apres_demain.Text = "Lbl_Uv_apres_demain";
            // 
            // Lbl_MeteoDesc_apres_demain
            // 
            Lbl_MeteoDesc_apres_demain.AutoSize = true;
            Lbl_MeteoDesc_apres_demain.Location = new Point(681, 111);
            Lbl_MeteoDesc_apres_demain.Name = "Lbl_MeteoDesc_apres_demain";
            Lbl_MeteoDesc_apres_demain.Size = new Size(208, 20);
            Lbl_MeteoDesc_apres_demain.TabIndex = 10;
            Lbl_MeteoDesc_apres_demain.Text = "Lbl_MeteoDesc_apres_demain";
            // 
            // lbl_Apres_demain
            // 
            lbl_Apres_demain.AutoSize = true;
            lbl_Apres_demain.Location = new Point(677, 79);
            lbl_Apres_demain.Name = "lbl_Apres_demain";
            lbl_Apres_demain.Size = new Size(126, 20);
            lbl_Apres_demain.TabIndex = 9;
            lbl_Apres_demain.Text = "lbl_Apres_demain";
            lbl_Apres_demain.Click += label2_Click;
            // 
            // Lbl_Uv
            // 
            Lbl_Uv.AutoSize = true;
            Lbl_Uv.Location = new Point(151, 357);
            Lbl_Uv.Name = "Lbl_Uv";
            Lbl_Uv.Size = new Size(52, 20);
            Lbl_Uv.TabIndex = 8;
            Lbl_Uv.Text = "Lbl_Uv";
            // 
            // Lbl_pressure
            // 
            Lbl_pressure.AutoSize = true;
            Lbl_pressure.Location = new Point(145, 318);
            Lbl_pressure.Name = "Lbl_pressure";
            Lbl_pressure.Size = new Size(90, 20);
            Lbl_pressure.TabIndex = 6;
            Lbl_pressure.Text = "Lbl_pressure";
            // 
            // Aujourd_hui
            // 
            Aujourd_hui.AutoSize = true;
            Aujourd_hui.Location = new Point(143, 79);
            Aujourd_hui.Name = "Aujourd_hui";
            Aujourd_hui.Size = new Size(85, 20);
            Aujourd_hui.TabIndex = 5;
            Aujourd_hui.Text = "Aujourd'hui";
            // 
            // Lbl_Speed_wind
            // 
            Lbl_Speed_wind.AutoSize = true;
            Lbl_Speed_wind.Location = new Point(153, 273);
            Lbl_Speed_wind.Name = "Lbl_Speed_wind";
            Lbl_Speed_wind.Size = new Size(115, 20);
            Lbl_Speed_wind.TabIndex = 4;
            Lbl_Speed_wind.Text = "Lbl_Speed_wind";
            // 
            // Lbl_humidite
            // 
            Lbl_humidite.AutoSize = true;
            Lbl_humidite.Location = new Point(153, 227);
            Lbl_humidite.Name = "Lbl_humidite";
            Lbl_humidite.Size = new Size(94, 20);
            Lbl_humidite.TabIndex = 3;
            Lbl_humidite.Text = "Lbl_humidite";
            // 
            // Lbl_MeteoDesc
            // 
            Lbl_MeteoDesc.AutoEllipsis = true;
            Lbl_MeteoDesc.AutoSize = true;
            Lbl_MeteoDesc.Location = new Point(150, 183);
            Lbl_MeteoDesc.Name = "Lbl_MeteoDesc";
            Lbl_MeteoDesc.Size = new Size(110, 20);
            Lbl_MeteoDesc.TabIndex = 2;
            Lbl_MeteoDesc.Text = "Lbl_MeteoDesc";
            // 
            // Lbl_Temperature
            // 
            Lbl_Temperature.AutoEllipsis = true;
            Lbl_Temperature.AutoSize = true;
            Lbl_Temperature.Location = new Point(143, 130);
            Lbl_Temperature.Name = "Lbl_Temperature";
            Lbl_Temperature.Size = new Size(119, 20);
            Lbl_Temperature.TabIndex = 1;
            Lbl_Temperature.Text = "Lbl_Temperature";
            Lbl_Temperature.Click += Lbl_Temperature_Click;
            // 
            // Lbl_VilleNom
            // 
            Lbl_VilleNom.AutoSize = true;
            Lbl_VilleNom.Location = new Point(105, 33);
            Lbl_VilleNom.Name = "Lbl_VilleNom";
            Lbl_VilleNom.Size = new Size(97, 20);
            Lbl_VilleNom.TabIndex = 0;
            Lbl_VilleNom.Text = "Lbl_VilleNom\r\n";
            // 
            // iconeMeteo_apres_demain
            // 
            iconeMeteo_apres_demain.Location = new Point(927, 114);
            iconeMeteo_apres_demain.Name = "iconeMeteo_apres_demain";
            iconeMeteo_apres_demain.Size = new Size(125, 62);
            iconeMeteo_apres_demain.TabIndex = 12;
            iconeMeteo_apres_demain.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1203, 684);
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
            ((System.ComponentModel.ISupportInitialize)iconeMeteo_apres_demain).EndInit();
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
        private Label Aujourd_hui;
        private Label Lbl_pressure;
        private Label Lbl_Uv;
        private Label lbl_Apres_demain;
        private Label Lbl_MeteoDesc_apres_demain;
        private Label Lbl_Uv_apres_demain;
        private PictureBox iconeMeteo_apres_demain;
    }
}
