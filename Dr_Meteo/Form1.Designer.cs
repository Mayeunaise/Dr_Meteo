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
            tableLayoutPanel1 = new TableLayoutPanel();
            Lbl_j_3 = new Label();
            iconeMeteo_j6 = new PictureBox();
            Lbl_min_j3 = new Label();
            Lbl_max_j6 = new Label();
            Lbl_max_j3 = new Label();
            Lbl_min_j6 = new Label();
            iconeMeteo_j3 = new PictureBox();
            Lbl_j_6 = new Label();
            Lbl_j_4 = new Label();
            Lbl_min_j4 = new Label();
            iconeMeteo_j5 = new PictureBox();
            Lbl_max_j4 = new Label();
            Lbl_max_j5 = new Label();
            iconeMeteo_j4 = new PictureBox();
            Lbl_min_j5 = new Label();
            Lbl_j_5 = new Label();
            Lbl_j_7 = new Label();
            Lbl_min_j7 = new Label();
            Lbl_max_j7 = new Label();
            iconeMeteo_j7 = new PictureBox();
            iconeMeteo_apres_demain_bis = new PictureBox();
            Lbl_diff_sunset_apres_demain = new Label();
            Lbl_diff_sunset_demain = new Label();
            Lbl_diff_temp_ensoleilement_apres_demain = new Label();
            Lbl_diff_temp_ensoleilement_demain = new Label();
            Lbl_coucher_soleil = new Label();
            Lbl_lever_soleil = new Label();
            Lbl_temp_min = new Label();
            Lbl_temp_max = new Label();
            iconeMeteo_demain = new PictureBox();
            Lbl_Uv_demain = new Label();
            Lbl_temp_min_demain = new Label();
            Lbl_temp_max_demain = new Label();
            Lbl_MeteoDesc_demain = new Label();
            Lbl_Demain = new Label();
            Lbl_temp_min_apres_demain = new Label();
            Lbl_temp_max_apres_demain = new Label();
            Lbl_VilleNom = new Label();
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
            Panel_Accueil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Loupe).BeginInit();
            Panel_Meteo_Ville.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconeMeteo_j6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconeMeteo_j3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconeMeteo_j5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconeMeteo_j4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconeMeteo_j7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconeMeteo_apres_demain_bis).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconeMeteo_demain).BeginInit();
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
            Panel_Meteo_Ville.Controls.Add(tableLayoutPanel1);
            Panel_Meteo_Ville.Controls.Add(iconeMeteo_apres_demain_bis);
            Panel_Meteo_Ville.Controls.Add(Lbl_diff_sunset_apres_demain);
            Panel_Meteo_Ville.Controls.Add(Lbl_diff_sunset_demain);
            Panel_Meteo_Ville.Controls.Add(Lbl_diff_temp_ensoleilement_apres_demain);
            Panel_Meteo_Ville.Controls.Add(Lbl_diff_temp_ensoleilement_demain);
            Panel_Meteo_Ville.Controls.Add(Lbl_coucher_soleil);
            Panel_Meteo_Ville.Controls.Add(Lbl_lever_soleil);
            Panel_Meteo_Ville.Controls.Add(Lbl_temp_min);
            Panel_Meteo_Ville.Controls.Add(Lbl_temp_max);
            Panel_Meteo_Ville.Controls.Add(iconeMeteo_demain);
            Panel_Meteo_Ville.Controls.Add(Lbl_Uv_demain);
            Panel_Meteo_Ville.Controls.Add(Lbl_temp_min_demain);
            Panel_Meteo_Ville.Controls.Add(Lbl_temp_max_demain);
            Panel_Meteo_Ville.Controls.Add(Lbl_MeteoDesc_demain);
            Panel_Meteo_Ville.Controls.Add(Lbl_Demain);
            Panel_Meteo_Ville.Controls.Add(Lbl_temp_min_apres_demain);
            Panel_Meteo_Ville.Controls.Add(Lbl_temp_max_apres_demain);
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
            Panel_Meteo_Ville.Margin = new Padding(3, 4, 3, 4);
            Panel_Meteo_Ville.Name = "Panel_Meteo_Ville";
            Panel_Meteo_Ville.Size = new Size(1203, 684);
            Panel_Meteo_Ville.TabIndex = 3;
            Panel_Meteo_Ville.Paint += Panel_Meteo_Ville_Paint;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 10;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.5555553F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4.44444466F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.5555553F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4.44444466F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.5555553F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4.44444466F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.5555553F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4.44444466F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.5555553F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4.44444466F));
            tableLayoutPanel1.Controls.Add(Lbl_j_3, 0, 0);
            tableLayoutPanel1.Controls.Add(iconeMeteo_j6, 7, 0);
            tableLayoutPanel1.Controls.Add(Lbl_min_j3, 0, 1);
            tableLayoutPanel1.Controls.Add(Lbl_max_j6, 6, 2);
            tableLayoutPanel1.Controls.Add(Lbl_max_j3, 0, 2);
            tableLayoutPanel1.Controls.Add(Lbl_min_j6, 6, 1);
            tableLayoutPanel1.Controls.Add(iconeMeteo_j3, 1, 0);
            tableLayoutPanel1.Controls.Add(Lbl_j_6, 6, 0);
            tableLayoutPanel1.Controls.Add(Lbl_j_4, 2, 0);
            tableLayoutPanel1.Controls.Add(Lbl_min_j4, 2, 1);
            tableLayoutPanel1.Controls.Add(iconeMeteo_j5, 5, 0);
            tableLayoutPanel1.Controls.Add(Lbl_max_j4, 2, 2);
            tableLayoutPanel1.Controls.Add(Lbl_max_j5, 4, 2);
            tableLayoutPanel1.Controls.Add(iconeMeteo_j4, 3, 0);
            tableLayoutPanel1.Controls.Add(Lbl_min_j5, 4, 1);
            tableLayoutPanel1.Controls.Add(Lbl_j_5, 4, 0);
            tableLayoutPanel1.Controls.Add(Lbl_j_7, 8, 0);
            tableLayoutPanel1.Controls.Add(Lbl_min_j7, 8, 1);
            tableLayoutPanel1.Controls.Add(Lbl_max_j7, 8, 2);
            tableLayoutPanel1.Controls.Add(iconeMeteo_j7, 9, 0);
            tableLayoutPanel1.Location = new Point(46, 491);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(1145, 218);
            tableLayoutPanel1.TabIndex = 37;
            // 
            // Lbl_j_3
            // 
            Lbl_j_3.Dock = DockStyle.Fill;
            Lbl_j_3.Location = new Point(3, 0);
            Lbl_j_3.Name = "Lbl_j_3";
            Lbl_j_3.Size = new Size(172, 68);
            Lbl_j_3.TabIndex = 19;
            Lbl_j_3.Text = "Lbl_j_3";
            Lbl_j_3.Click += Lbl_j_3_Click;
            // 
            // iconeMeteo_j6
            // 
            iconeMeteo_j6.Location = new Point(865, 3);
            iconeMeteo_j6.Name = "iconeMeteo_j6";
            iconeMeteo_j6.Size = new Size(44, 54);
            iconeMeteo_j6.TabIndex = 36;
            iconeMeteo_j6.TabStop = false;
            // 
            // Lbl_min_j3
            // 
            Lbl_min_j3.Dock = DockStyle.Fill;
            Lbl_min_j3.Location = new Point(3, 68);
            Lbl_min_j3.Name = "Lbl_min_j3";
            Lbl_min_j3.Size = new Size(172, 60);
            Lbl_min_j3.TabIndex = 20;
            Lbl_min_j3.Text = "Lbl_min_j3";
            // 
            // Lbl_max_j6
            // 
            Lbl_max_j6.Dock = DockStyle.Fill;
            Lbl_max_j6.Location = new Point(687, 128);
            Lbl_max_j6.Name = "Lbl_max_j6";
            Lbl_max_j6.Size = new Size(172, 98);
            Lbl_max_j6.TabIndex = 35;
            Lbl_max_j6.Text = "Lbl_max_j6";
            // 
            // Lbl_max_j3
            // 
            Lbl_max_j3.Dock = DockStyle.Fill;
            Lbl_max_j3.Location = new Point(3, 128);
            Lbl_max_j3.Name = "Lbl_max_j3";
            Lbl_max_j3.Size = new Size(172, 98);
            Lbl_max_j3.TabIndex = 21;
            Lbl_max_j3.Text = "Lbl_max_j3";
            // 
            // Lbl_min_j6
            // 
            Lbl_min_j6.Dock = DockStyle.Fill;
            Lbl_min_j6.Location = new Point(687, 68);
            Lbl_min_j6.Name = "Lbl_min_j6";
            Lbl_min_j6.Size = new Size(172, 60);
            Lbl_min_j6.TabIndex = 34;
            Lbl_min_j6.Text = "Lbl_min_j6";
            // 
            // iconeMeteo_j3
            // 
            iconeMeteo_j3.Location = new Point(181, 3);
            iconeMeteo_j3.Name = "iconeMeteo_j3";
            iconeMeteo_j3.Size = new Size(44, 50);
            iconeMeteo_j3.TabIndex = 31;
            iconeMeteo_j3.TabStop = false;
            // 
            // Lbl_j_6
            // 
            Lbl_j_6.Dock = DockStyle.Fill;
            Lbl_j_6.Location = new Point(687, 0);
            Lbl_j_6.Name = "Lbl_j_6";
            Lbl_j_6.Size = new Size(172, 68);
            Lbl_j_6.TabIndex = 33;
            Lbl_j_6.Text = "Lbl_j_6";
            // 
            // Lbl_j_4
            // 
            Lbl_j_4.Dock = DockStyle.Fill;
            Lbl_j_4.Location = new Point(231, 0);
            Lbl_j_4.Name = "Lbl_j_4";
            Lbl_j_4.Size = new Size(172, 68);
            Lbl_j_4.TabIndex = 23;
            Lbl_j_4.Text = "Lbl_j_4";
            Lbl_j_4.Click += label3_Click;
            // 
            // Lbl_min_j4
            // 
            Lbl_min_j4.Dock = DockStyle.Fill;
            Lbl_min_j4.Location = new Point(231, 68);
            Lbl_min_j4.Name = "Lbl_min_j4";
            Lbl_min_j4.Size = new Size(172, 60);
            Lbl_min_j4.TabIndex = 24;
            Lbl_min_j4.Text = "Lbl_min_j4";
            Lbl_min_j4.Click += Lbl_min_j4_Click;
            // 
            // iconeMeteo_j5
            // 
            iconeMeteo_j5.Location = new Point(637, 3);
            iconeMeteo_j5.Name = "iconeMeteo_j5";
            iconeMeteo_j5.Size = new Size(44, 54);
            iconeMeteo_j5.TabIndex = 30;
            iconeMeteo_j5.TabStop = false;
            iconeMeteo_j5.Click += iconeMeteo_j5_Click;
            // 
            // Lbl_max_j4
            // 
            Lbl_max_j4.Dock = DockStyle.Fill;
            Lbl_max_j4.Location = new Point(231, 128);
            Lbl_max_j4.Name = "Lbl_max_j4";
            Lbl_max_j4.Size = new Size(172, 98);
            Lbl_max_j4.TabIndex = 25;
            Lbl_max_j4.Text = "Lbl_max_j4";
            // 
            // Lbl_max_j5
            // 
            Lbl_max_j5.Dock = DockStyle.Fill;
            Lbl_max_j5.Location = new Point(459, 128);
            Lbl_max_j5.Name = "Lbl_max_j5";
            Lbl_max_j5.Size = new Size(172, 98);
            Lbl_max_j5.TabIndex = 29;
            Lbl_max_j5.Text = "Lbl_max_j5";
            // 
            // iconeMeteo_j4
            // 
            iconeMeteo_j4.Location = new Point(409, 3);
            iconeMeteo_j4.Name = "iconeMeteo_j4";
            iconeMeteo_j4.Size = new Size(44, 54);
            iconeMeteo_j4.TabIndex = 26;
            iconeMeteo_j4.TabStop = false;
            // 
            // Lbl_min_j5
            // 
            Lbl_min_j5.Dock = DockStyle.Fill;
            Lbl_min_j5.Location = new Point(459, 68);
            Lbl_min_j5.Name = "Lbl_min_j5";
            Lbl_min_j5.Size = new Size(172, 60);
            Lbl_min_j5.TabIndex = 28;
            Lbl_min_j5.Text = "Lbl_min_j5";
            Lbl_min_j5.Click += Lbl_min_j5_Click;
            // 
            // Lbl_j_5
            // 
            Lbl_j_5.Dock = DockStyle.Fill;
            Lbl_j_5.Location = new Point(459, 0);
            Lbl_j_5.Name = "Lbl_j_5";
            Lbl_j_5.Size = new Size(172, 68);
            Lbl_j_5.TabIndex = 27;
            Lbl_j_5.Text = "Lbl_j_5";
            // 
            // Lbl_j_7
            // 
            Lbl_j_7.AutoSize = true;
            Lbl_j_7.Dock = DockStyle.Fill;
            Lbl_j_7.Location = new Point(915, 0);
            Lbl_j_7.Name = "Lbl_j_7";
            Lbl_j_7.Size = new Size(172, 68);
            Lbl_j_7.TabIndex = 37;
            Lbl_j_7.Text = "Lbl_j_7";
            // 
            // Lbl_min_j7
            // 
            Lbl_min_j7.AutoSize = true;
            Lbl_min_j7.Dock = DockStyle.Fill;
            Lbl_min_j7.Location = new Point(915, 68);
            Lbl_min_j7.Name = "Lbl_min_j7";
            Lbl_min_j7.Size = new Size(172, 60);
            Lbl_min_j7.TabIndex = 38;
            Lbl_min_j7.Text = "Lbl_min_j7";
            // 
            // Lbl_max_j7
            // 
            Lbl_max_j7.AutoSize = true;
            Lbl_max_j7.Dock = DockStyle.Fill;
            Lbl_max_j7.Location = new Point(915, 128);
            Lbl_max_j7.Name = "Lbl_max_j7";
            Lbl_max_j7.Size = new Size(172, 98);
            Lbl_max_j7.TabIndex = 39;
            Lbl_max_j7.Text = "Lbl_max_j7";
            // 
            // iconeMeteo_j7
            // 
            iconeMeteo_j7.Location = new Point(1093, 3);
            iconeMeteo_j7.Name = "iconeMeteo_j7";
            iconeMeteo_j7.Size = new Size(49, 62);
            iconeMeteo_j7.TabIndex = 40;
            iconeMeteo_j7.TabStop = false;
            // 
            // iconeMeteo_apres_demain_bis
            // 
            iconeMeteo_apres_demain_bis.Location = new Point(885, 72);
            iconeMeteo_apres_demain_bis.Name = "iconeMeteo_apres_demain_bis";
            iconeMeteo_apres_demain_bis.Size = new Size(125, 62);
            iconeMeteo_apres_demain_bis.TabIndex = 32;
            iconeMeteo_apres_demain_bis.TabStop = false;
            // 
            // Lbl_diff_sunset_apres_demain
            // 
            Lbl_diff_sunset_apres_demain.AutoSize = true;
            Lbl_diff_sunset_apres_demain.Location = new Point(649, 392);
            Lbl_diff_sunset_apres_demain.Name = "Lbl_diff_sunset_apres_demain";
            Lbl_diff_sunset_apres_demain.Size = new Size(203, 20);
            Lbl_diff_sunset_apres_demain.TabIndex = 18;
            Lbl_diff_sunset_apres_demain.Text = "Lbl_diff_sunset_apres_demain";
            // 
            // Lbl_diff_sunset_demain
            // 
            Lbl_diff_sunset_demain.AutoSize = true;
            Lbl_diff_sunset_demain.Location = new Point(323, 386);
            Lbl_diff_sunset_demain.Name = "Lbl_diff_sunset_demain";
            Lbl_diff_sunset_demain.Size = new Size(161, 20);
            Lbl_diff_sunset_demain.TabIndex = 17;
            Lbl_diff_sunset_demain.Text = "Lbl_diff_sunset_demain";
            // 
            // Lbl_diff_temp_ensoleilement_apres_demain
            // 
            Lbl_diff_temp_ensoleilement_apres_demain.AutoSize = true;
            Lbl_diff_temp_ensoleilement_apres_demain.Location = new Point(653, 358);
            Lbl_diff_temp_ensoleilement_apres_demain.Name = "Lbl_diff_temp_ensoleilement_apres_demain";
            Lbl_diff_temp_ensoleilement_apres_demain.Size = new Size(296, 20);
            Lbl_diff_temp_ensoleilement_apres_demain.TabIndex = 16;
            Lbl_diff_temp_ensoleilement_apres_demain.Text = "Lbl_diff_temp_ensoleilement_apres_demain";
            // 
            // Lbl_diff_temp_ensoleilement_demain
            // 
            Lbl_diff_temp_ensoleilement_demain.AutoSize = true;
            Lbl_diff_temp_ensoleilement_demain.Location = new Point(349, 359);
            Lbl_diff_temp_ensoleilement_demain.Name = "Lbl_diff_temp_ensoleilement_demain";
            Lbl_diff_temp_ensoleilement_demain.Size = new Size(254, 20);
            Lbl_diff_temp_ensoleilement_demain.TabIndex = 15;
            Lbl_diff_temp_ensoleilement_demain.Text = "Lbl_diff_temp_ensoleilement_demain";
            Lbl_diff_temp_ensoleilement_demain.Click += Lbl_diff_temp_ensoleilement_demain_Click;
            // 
            // Lbl_coucher_soleil
            // 
            Lbl_coucher_soleil.AutoSize = true;
            Lbl_coucher_soleil.Location = new Point(126, 438);
            Lbl_coucher_soleil.Name = "Lbl_coucher_soleil";
            Lbl_coucher_soleil.Size = new Size(128, 20);
            Lbl_coucher_soleil.TabIndex = 14;
            Lbl_coucher_soleil.Text = "Lbl_coucher_soleil";
            // 
            // Lbl_lever_soleil
            // 
            Lbl_lever_soleil.AutoSize = true;
            Lbl_lever_soleil.Location = new Point(125, 410);
            Lbl_lever_soleil.Name = "Lbl_lever_soleil";
            Lbl_lever_soleil.Size = new Size(108, 20);
            Lbl_lever_soleil.TabIndex = 13;
            Lbl_lever_soleil.Text = "Lbl_lever_soleil";
            // 
            // Lbl_temp_min
            // 
            Lbl_temp_min.AutoSize = true;
            Lbl_temp_min.Location = new Point(120, 87);
            Lbl_temp_min.Name = "Lbl_temp_min";
            Lbl_temp_min.Size = new Size(101, 20);
            Lbl_temp_min.TabIndex = 12;
            Lbl_temp_min.Text = "Lbl_temp_min";
            // 
            // Lbl_temp_max
            // 
            Lbl_temp_max.AutoSize = true;
            Lbl_temp_max.Location = new Point(119, 155);
            Lbl_temp_max.Name = "Lbl_temp_max";
            Lbl_temp_max.Size = new Size(104, 20);
            Lbl_temp_max.TabIndex = 11;
            Lbl_temp_max.Text = "Lbl_temp_max";
            // 
            // iconeMeteo_demain
            // 
            iconeMeteo_demain.Location = new Point(339, 85);
            iconeMeteo_demain.Name = "iconeMeteo_demain";
            iconeMeteo_demain.Size = new Size(125, 62);
            iconeMeteo_demain.TabIndex = 10;
            iconeMeteo_demain.TabStop = false;
            // 
            // Lbl_Uv_demain
            // 
            Lbl_Uv_demain.AutoSize = true;
            Lbl_Uv_demain.Location = new Point(356, 322);
            Lbl_Uv_demain.Name = "Lbl_Uv_demain";
            Lbl_Uv_demain.Size = new Size(108, 20);
            Lbl_Uv_demain.TabIndex = 9;
            Lbl_Uv_demain.Text = "Lbl_Uv_demain";
            // 
            // Lbl_temp_min_demain
            // 
            Lbl_temp_min_demain.AutoSize = true;
            Lbl_temp_min_demain.Location = new Point(350, 242);
            Lbl_temp_min_demain.Name = "Lbl_temp_min_demain";
            Lbl_temp_min_demain.Size = new Size(157, 20);
            Lbl_temp_min_demain.TabIndex = 8;
            Lbl_temp_min_demain.Text = "Lbl_temp_min_demain";
            // 
            // Lbl_temp_max_demain
            // 
            Lbl_temp_max_demain.AutoSize = true;
            Lbl_temp_max_demain.Location = new Point(350, 208);
            Lbl_temp_max_demain.Name = "Lbl_temp_max_demain";
            Lbl_temp_max_demain.Size = new Size(160, 20);
            Lbl_temp_max_demain.TabIndex = 7;
            Lbl_temp_max_demain.Text = "Lbl_temp_max_demain";
            // 
            // Lbl_MeteoDesc_demain
            // 
            Lbl_MeteoDesc_demain.AutoSize = true;
            Lbl_MeteoDesc_demain.Location = new Point(350, 171);
            Lbl_MeteoDesc_demain.Name = "Lbl_MeteoDesc_demain";
            Lbl_MeteoDesc_demain.Size = new Size(166, 20);
            Lbl_MeteoDesc_demain.TabIndex = 6;
            Lbl_MeteoDesc_demain.Text = "Lbl_MeteoDesc_demain";
            // 
            // Lbl_Demain
            // 
            Lbl_Demain.AutoSize = true;
            Lbl_Demain.Location = new Point(333, 60);
            Lbl_Demain.Name = "Lbl_Demain";
            Lbl_Demain.Size = new Size(87, 20);
            Lbl_Demain.TabIndex = 5;
            Lbl_Demain.Text = "Lbl_Demain";
            // 
            // Lbl_temp_min_apres_demain
            // 
            Lbl_temp_min_apres_demain.AutoSize = true;
            Lbl_temp_min_apres_demain.Location = new Point(652, 236);
            Lbl_temp_min_apres_demain.Name = "Lbl_temp_min_apres_demain";
            Lbl_temp_min_apres_demain.Size = new Size(199, 20);
            Lbl_temp_min_apres_demain.TabIndex = 4;
            Lbl_temp_min_apres_demain.Text = "Lbl_temp_min_apres_demain";
            // 
            // Lbl_temp_max_apres_demain
            // 
            Lbl_temp_max_apres_demain.AutoSize = true;
            Lbl_temp_max_apres_demain.Location = new Point(652, 202);
            Lbl_temp_max_apres_demain.Name = "Lbl_temp_max_apres_demain";
            Lbl_temp_max_apres_demain.Size = new Size(202, 20);
            Lbl_temp_max_apres_demain.TabIndex = 3;
            Lbl_temp_max_apres_demain.Text = "Lbl_temp_max_apres_demain";
            // 
            // Lbl_VilleNom
            // 
            Lbl_VilleNom.AutoSize = true;
            Lbl_VilleNom.Location = new Point(120, 16);
            Lbl_VilleNom.Margin = new Padding(2, 0, 2, 0);
            Lbl_VilleNom.Name = "Lbl_VilleNom";
            Lbl_VilleNom.Size = new Size(97, 20);
            Lbl_VilleNom.TabIndex = 2;
            Lbl_VilleNom.Text = "Lbl_VilleNom";
            // 
            // Lbl_MeteoDesc
            // 
            Lbl_MeteoDesc.Location = new Point(125, 176);
            Lbl_MeteoDesc.Name = "Lbl_MeteoDesc";
            Lbl_MeteoDesc.Size = new Size(174, 23);
            Lbl_MeteoDesc.TabIndex = 0;
            Lbl_MeteoDesc.Text = "Lbl_MeteoDesc";
            // 
            // Lbl_Uv
            // 
            Lbl_Uv.Location = new Point(125, 318);
            Lbl_Uv.Name = "Lbl_Uv";
            Lbl_Uv.Size = new Size(100, 23);
            Lbl_Uv.TabIndex = 0;
            Lbl_Uv.Text = "Lbl_Uv";
            Lbl_Uv.Click += Lbl_Uv_Click;
            // 
            // Lbl_Temperature
            // 
            Lbl_Temperature.AutoEllipsis = true;
            Lbl_Temperature.AutoSize = true;
            Lbl_Temperature.Location = new Point(125, 102);
            Lbl_Temperature.Name = "Lbl_Temperature";
            Lbl_Temperature.Size = new Size(119, 20);
            Lbl_Temperature.TabIndex = 1;
            Lbl_Temperature.Text = "Lbl_Temperature";
            // 
            // Lbl_humidite
            // 
            Lbl_humidite.Location = new Point(125, 376);
            Lbl_humidite.Name = "Lbl_humidite";
            Lbl_humidite.Size = new Size(100, 23);
            Lbl_humidite.TabIndex = 0;
            Lbl_humidite.Text = "Lbl_humidite";
            // 
            // Lbl_MeteoDesc_apres_demain
            // 
            Lbl_MeteoDesc_apres_demain.Location = new Point(647, 168);
            Lbl_MeteoDesc_apres_demain.Name = "Lbl_MeteoDesc_apres_demain";
            Lbl_MeteoDesc_apres_demain.Size = new Size(218, 23);
            Lbl_MeteoDesc_apres_demain.TabIndex = 0;
            Lbl_MeteoDesc_apres_demain.Text = "Lbl_MeteoDesc_apres_demain";
            // 
            // Lbl_pressure
            // 
            Lbl_pressure.Location = new Point(120, 268);
            Lbl_pressure.Name = "Lbl_pressure";
            Lbl_pressure.Size = new Size(100, 23);
            Lbl_pressure.TabIndex = 0;
            Lbl_pressure.Text = "Lbl_pressure";
            // 
            // Lbl_Speed_wind
            // 
            Lbl_Speed_wind.Location = new Point(125, 219);
            Lbl_Speed_wind.Name = "Lbl_Speed_wind";
            Lbl_Speed_wind.Size = new Size(139, 23);
            Lbl_Speed_wind.TabIndex = 0;
            Lbl_Speed_wind.Text = "Lbl_Speed_wind";
            Lbl_Speed_wind.Click += Lbl_Speed_wind_Click;
            // 
            // lbl_Apres_demain
            // 
            lbl_Apres_demain.Location = new Point(647, 60);
            lbl_Apres_demain.Name = "lbl_Apres_demain";
            lbl_Apres_demain.Size = new Size(170, 23);
            lbl_Apres_demain.TabIndex = 0;
            lbl_Apres_demain.Text = "lbl_Apres_demain";
            // 
            // Lbl_Uv_apres_demain
            // 
            Lbl_Uv_apres_demain.Location = new Point(647, 318);
            Lbl_Uv_apres_demain.Name = "Lbl_Uv_apres_demain";
            Lbl_Uv_apres_demain.Size = new Size(158, 23);
            Lbl_Uv_apres_demain.TabIndex = 0;
            Lbl_Uv_apres_demain.Text = "Lbl_Uv_apres_demain";
            Lbl_Uv_apres_demain.Click += Lbl_Uv_apres_demain_Click;
            // 
            // Aujourd_hui
            // 
            Aujourd_hui.Location = new Point(120, 60);
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
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconeMeteo_j6).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconeMeteo_j3).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconeMeteo_j5).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconeMeteo_j4).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconeMeteo_j7).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconeMeteo_apres_demain_bis).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconeMeteo_demain).EndInit();
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
        private Label Lbl_temp_max_apres_demain;
        private Label Lbl_temp_min_apres_demain;
        private Label Lbl_Demain;
        private Label Lbl_temp_min_demain;
        private Label Lbl_temp_max_demain;
        private PictureBox iconeMeteo_demain;
        private Label Lbl_temp_min;
        private Label Lbl_temp_max;
        private Label Lbl_coucher_soleil;
        private Label Lbl_lever_soleil;
        private Label Lbl_diff_temp_ensoleilement_demain;
        private Label Lbl_diff_temp_ensoleilement_apres_demain;
        private Label Lbl_diff_sunset_apres_demain;
        private Label Lbl_diff_sunset_demain;
        private Label Lbl_j_3;
        private Label Lbl_min_j3;
        private Label Lbl_max_j3;
        private PictureBox iconeMeteo_j3;
        private Label Lbl_max_j4;
        private Label Lbl_min_j4;
        private Label Lbl_j_4;
        private PictureBox iconeMeteo_j4;
        private Label Lbl_j_5;
        private Label Lbl_max_j5;
        private Label Lbl_min_j5;
        private PictureBox iconeMeteo_j5;
        private PictureBox iconeMeteo_apres_demain_bis;
        private Label Lbl_max_j6;
        private Label Lbl_min_j6;
        private Label Lbl_j_6;
        private PictureBox iconeMeteo_j6;
        private TableLayoutPanel tableLayoutPanel1;
        private Label Lbl_j_7;
        private Label Lbl_min_j7;
        private Label Lbl_max_j7;
        private PictureBox iconeMeteo_j7;
    }
}
