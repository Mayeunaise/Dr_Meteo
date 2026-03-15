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
            components = new System.ComponentModel.Container();
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
            Panel_Header = new Panel();
            toolBar = new PictureBox();
            menuHamburger = new ContextMenuStrip(components);
            changerDeVilleToolStripMenuItem = new ToolStripMenuItem();
            sinscrireToolStripMenuItem = new ToolStripMenuItem();
            seConnecterToolStripMenuItem = new ToolStripMenuItem();
            Panel_Inscription = new Panel();
            Lbl_Uname = new Label();
            Lbl_Conf_Mdp = new Label();
            Lbl_Mdp = new Label();
            textBoxMdpConf = new TextBox();
            textBoxMdp = new TextBox();
            textBoxUname = new TextBox();
            Panel_Configuration = new Panel();
            Lbl_VilleFavorite = new Label();
            Lbl_EMail = new Label();
            textBoxVilleFavorite = new TextBox();
            textBoxEmail = new TextBox();
            Panel_Connection = new Panel();
            Lbl_Mdp_Connection = new Label();
            Lbl_Uname_Connection = new Label();
            textBoxMdpConnection = new TextBox();
            textBoxUconnection = new TextBox();
            Panel_Accueil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Loupe).BeginInit();
            Panel_Meteo_Ville.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconeMeteo_j6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconeMeteo_j3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconeMeteo_j5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconeMeteo_j4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconeMeteo_apres_demain_bis).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconeMeteo_demain).BeginInit();
            Panel_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)toolBar).BeginInit();
            menuHamburger.SuspendLayout();
            Panel_Inscription.SuspendLayout();
            Panel_Configuration.SuspendLayout();
            Panel_Connection.SuspendLayout();
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
            Panel_Accueil.Size = new Size(1254, 632);
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
            Barre_Recherche.Size = new Size(988, 23);
            Barre_Recherche.TabIndex = 0;
            // 
            // Loupe
            // 
            Loupe.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Loupe.BackgroundImageLayout = ImageLayout.Stretch;
            Loupe.Image = (Image)resources.GetObject("Loupe.Image");
            Loupe.Location = new Point(1126, 86);
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
            Panel_Meteo_Ville.Name = "Panel_Meteo_Ville";
            Panel_Meteo_Ville.Size = new Size(1254, 632);
            Panel_Meteo_Ville.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 8;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.44445F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.555556F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.4444447F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.555556F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.4444447F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.555556F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.4444447F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.5555563F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 18F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 18F));
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
            tableLayoutPanel1.Location = new Point(48, 409);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(1002, 164);
            tableLayoutPanel1.TabIndex = 37;
            // 
            // Lbl_j_3
            // 
            Lbl_j_3.Dock = DockStyle.Fill;
            Lbl_j_3.Location = new Point(3, 0);
            Lbl_j_3.Name = "Lbl_j_3";
            Lbl_j_3.Size = new Size(188, 51);
            Lbl_j_3.TabIndex = 19;
            Lbl_j_3.Text = "Lbl_j_3";
            // 
            // iconeMeteo_j6
            // 
            iconeMeteo_j6.Location = new Point(944, 2);
            iconeMeteo_j6.Margin = new Padding(3, 2, 3, 2);
            iconeMeteo_j6.Name = "iconeMeteo_j6";
            iconeMeteo_j6.Size = new Size(38, 40);
            iconeMeteo_j6.TabIndex = 36;
            iconeMeteo_j6.TabStop = false;
            // 
            // Lbl_min_j3
            // 
            Lbl_min_j3.Dock = DockStyle.Fill;
            Lbl_min_j3.Location = new Point(3, 51);
            Lbl_min_j3.Name = "Lbl_min_j3";
            Lbl_min_j3.Size = new Size(188, 45);
            Lbl_min_j3.TabIndex = 20;
            Lbl_min_j3.Text = "Lbl_min_j3";
            // 
            // Lbl_max_j6
            // 
            Lbl_max_j6.Dock = DockStyle.Fill;
            Lbl_max_j6.Location = new Point(750, 96);
            Lbl_max_j6.Name = "Lbl_max_j6";
            Lbl_max_j6.Size = new Size(188, 74);
            Lbl_max_j6.TabIndex = 35;
            Lbl_max_j6.Text = "Lbl_max_j6";
            // 
            // Lbl_max_j3
            // 
            Lbl_max_j3.Dock = DockStyle.Fill;
            Lbl_max_j3.Location = new Point(3, 96);
            Lbl_max_j3.Name = "Lbl_max_j3";
            Lbl_max_j3.Size = new Size(188, 74);
            Lbl_max_j3.TabIndex = 21;
            Lbl_max_j3.Text = "Lbl_max_j3";
            // 
            // Lbl_min_j6
            // 
            Lbl_min_j6.Dock = DockStyle.Fill;
            Lbl_min_j6.Location = new Point(750, 51);
            Lbl_min_j6.Name = "Lbl_min_j6";
            Lbl_min_j6.Size = new Size(188, 45);
            Lbl_min_j6.TabIndex = 34;
            Lbl_min_j6.Text = "Lbl_min_j6";
            // 
            // iconeMeteo_j3
            // 
            iconeMeteo_j3.Location = new Point(197, 2);
            iconeMeteo_j3.Margin = new Padding(3, 2, 3, 2);
            iconeMeteo_j3.Name = "iconeMeteo_j3";
            iconeMeteo_j3.Size = new Size(38, 38);
            iconeMeteo_j3.TabIndex = 31;
            iconeMeteo_j3.TabStop = false;
            // 
            // Lbl_j_6
            // 
            Lbl_j_6.Dock = DockStyle.Fill;
            Lbl_j_6.Location = new Point(750, 0);
            Lbl_j_6.Name = "Lbl_j_6";
            Lbl_j_6.Size = new Size(188, 51);
            Lbl_j_6.TabIndex = 33;
            Lbl_j_6.Text = "Lbl_j_6";
            // 
            // Lbl_j_4
            // 
            Lbl_j_4.Dock = DockStyle.Fill;
            Lbl_j_4.Location = new Point(252, 0);
            Lbl_j_4.Name = "Lbl_j_4";
            Lbl_j_4.Size = new Size(188, 51);
            Lbl_j_4.TabIndex = 23;
            Lbl_j_4.Text = "Lbl_j_4";
            // 
            // Lbl_min_j4
            // 
            Lbl_min_j4.Dock = DockStyle.Fill;
            Lbl_min_j4.Location = new Point(252, 51);
            Lbl_min_j4.Name = "Lbl_min_j4";
            Lbl_min_j4.Size = new Size(188, 45);
            Lbl_min_j4.TabIndex = 24;
            Lbl_min_j4.Text = "Lbl_min_j4";
            // 
            // iconeMeteo_j5
            // 
            iconeMeteo_j5.Location = new Point(695, 2);
            iconeMeteo_j5.Margin = new Padding(3, 2, 3, 2);
            iconeMeteo_j5.Name = "iconeMeteo_j5";
            iconeMeteo_j5.Size = new Size(38, 40);
            iconeMeteo_j5.TabIndex = 30;
            iconeMeteo_j5.TabStop = false;
            // 
            // Lbl_max_j4
            // 
            Lbl_max_j4.Dock = DockStyle.Fill;
            Lbl_max_j4.Location = new Point(252, 96);
            Lbl_max_j4.Name = "Lbl_max_j4";
            Lbl_max_j4.Size = new Size(188, 74);
            Lbl_max_j4.TabIndex = 25;
            Lbl_max_j4.Text = "Lbl_max_j4";
            // 
            // Lbl_max_j5
            // 
            Lbl_max_j5.Dock = DockStyle.Fill;
            Lbl_max_j5.Location = new Point(501, 96);
            Lbl_max_j5.Name = "Lbl_max_j5";
            Lbl_max_j5.Size = new Size(188, 74);
            Lbl_max_j5.TabIndex = 29;
            Lbl_max_j5.Text = "Lbl_max_j5";
            // 
            // iconeMeteo_j4
            // 
            iconeMeteo_j4.Location = new Point(446, 2);
            iconeMeteo_j4.Margin = new Padding(3, 2, 3, 2);
            iconeMeteo_j4.Name = "iconeMeteo_j4";
            iconeMeteo_j4.Size = new Size(38, 40);
            iconeMeteo_j4.TabIndex = 26;
            iconeMeteo_j4.TabStop = false;
            // 
            // Lbl_min_j5
            // 
            Lbl_min_j5.Dock = DockStyle.Fill;
            Lbl_min_j5.Location = new Point(501, 51);
            Lbl_min_j5.Name = "Lbl_min_j5";
            Lbl_min_j5.Size = new Size(188, 45);
            Lbl_min_j5.TabIndex = 28;
            Lbl_min_j5.Text = "Lbl_min_j5";
            // 
            // Lbl_j_5
            // 
            Lbl_j_5.Dock = DockStyle.Fill;
            Lbl_j_5.Location = new Point(501, 0);
            Lbl_j_5.Name = "Lbl_j_5";
            Lbl_j_5.Size = new Size(188, 51);
            Lbl_j_5.TabIndex = 27;
            Lbl_j_5.Text = "Lbl_j_5";
            // 
            // iconeMeteo_apres_demain_bis
            // 
            iconeMeteo_apres_demain_bis.Location = new Point(782, 95);
            iconeMeteo_apres_demain_bis.Margin = new Padding(3, 2, 3, 2);
            iconeMeteo_apres_demain_bis.Name = "iconeMeteo_apres_demain_bis";
            iconeMeteo_apres_demain_bis.Size = new Size(109, 46);
            iconeMeteo_apres_demain_bis.TabIndex = 32;
            iconeMeteo_apres_demain_bis.TabStop = false;
            // 
            // Lbl_diff_sunset_apres_demain
            // 
            Lbl_diff_sunset_apres_demain.AutoSize = true;
            Lbl_diff_sunset_apres_demain.Location = new Point(576, 335);
            Lbl_diff_sunset_apres_demain.Name = "Lbl_diff_sunset_apres_demain";
            Lbl_diff_sunset_apres_demain.Size = new Size(163, 15);
            Lbl_diff_sunset_apres_demain.TabIndex = 18;
            Lbl_diff_sunset_apres_demain.Text = "Lbl_diff_sunset_apres_demain";
            // 
            // Lbl_diff_sunset_demain
            // 
            Lbl_diff_sunset_demain.AutoSize = true;
            Lbl_diff_sunset_demain.Location = new Point(291, 331);
            Lbl_diff_sunset_demain.Name = "Lbl_diff_sunset_demain";
            Lbl_diff_sunset_demain.Size = new Size(130, 15);
            Lbl_diff_sunset_demain.TabIndex = 17;
            Lbl_diff_sunset_demain.Text = "Lbl_diff_sunset_demain";
            // 
            // Lbl_diff_temp_ensoleilement_apres_demain
            // 
            Lbl_diff_temp_ensoleilement_apres_demain.AutoSize = true;
            Lbl_diff_temp_ensoleilement_apres_demain.Location = new Point(579, 309);
            Lbl_diff_temp_ensoleilement_apres_demain.Name = "Lbl_diff_temp_ensoleilement_apres_demain";
            Lbl_diff_temp_ensoleilement_apres_demain.Size = new Size(236, 15);
            Lbl_diff_temp_ensoleilement_apres_demain.TabIndex = 16;
            Lbl_diff_temp_ensoleilement_apres_demain.Text = "Lbl_diff_temp_ensoleilement_apres_demain";
            // 
            // Lbl_diff_temp_ensoleilement_demain
            // 
            Lbl_diff_temp_ensoleilement_demain.AutoSize = true;
            Lbl_diff_temp_ensoleilement_demain.Location = new Point(313, 310);
            Lbl_diff_temp_ensoleilement_demain.Name = "Lbl_diff_temp_ensoleilement_demain";
            Lbl_diff_temp_ensoleilement_demain.Size = new Size(203, 15);
            Lbl_diff_temp_ensoleilement_demain.TabIndex = 15;
            Lbl_diff_temp_ensoleilement_demain.Text = "Lbl_diff_temp_ensoleilement_demain";
            // 
            // Lbl_coucher_soleil
            // 
            Lbl_coucher_soleil.AutoSize = true;
            Lbl_coucher_soleil.Location = new Point(118, 388);
            Lbl_coucher_soleil.Name = "Lbl_coucher_soleil";
            Lbl_coucher_soleil.Size = new Size(103, 15);
            Lbl_coucher_soleil.TabIndex = 14;
            Lbl_coucher_soleil.Text = "Lbl_coucher_soleil";
            // 
            // Lbl_lever_soleil
            // 
            Lbl_lever_soleil.AutoSize = true;
            Lbl_lever_soleil.Location = new Point(117, 368);
            Lbl_lever_soleil.Name = "Lbl_lever_soleil";
            Lbl_lever_soleil.Size = new Size(85, 15);
            Lbl_lever_soleil.TabIndex = 13;
            Lbl_lever_soleil.Text = "Lbl_lever_soleil";
            // 
            // Lbl_temp_min
            // 
            Lbl_temp_min.AutoSize = true;
            Lbl_temp_min.Location = new Point(113, 125);
            Lbl_temp_min.Name = "Lbl_temp_min";
            Lbl_temp_min.Size = new Size(82, 15);
            Lbl_temp_min.TabIndex = 12;
            Lbl_temp_min.Text = "Lbl_temp_min";
            // 
            // Lbl_temp_max
            // 
            Lbl_temp_max.AutoSize = true;
            Lbl_temp_max.Location = new Point(112, 176);
            Lbl_temp_max.Name = "Lbl_temp_max";
            Lbl_temp_max.Size = new Size(83, 15);
            Lbl_temp_max.TabIndex = 11;
            Lbl_temp_max.Text = "Lbl_temp_max";
            // 
            // iconeMeteo_demain
            // 
            iconeMeteo_demain.Location = new Point(305, 105);
            iconeMeteo_demain.Margin = new Padding(3, 2, 3, 2);
            iconeMeteo_demain.Name = "iconeMeteo_demain";
            iconeMeteo_demain.Size = new Size(109, 46);
            iconeMeteo_demain.TabIndex = 10;
            iconeMeteo_demain.TabStop = false;
            // 
            // Lbl_Uv_demain
            // 
            Lbl_Uv_demain.AutoSize = true;
            Lbl_Uv_demain.Location = new Point(320, 283);
            Lbl_Uv_demain.Name = "Lbl_Uv_demain";
            Lbl_Uv_demain.Size = new Size(87, 15);
            Lbl_Uv_demain.TabIndex = 9;
            Lbl_Uv_demain.Text = "Lbl_Uv_demain";
            // 
            // Lbl_temp_min_demain
            // 
            Lbl_temp_min_demain.AutoSize = true;
            Lbl_temp_min_demain.Location = new Point(314, 223);
            Lbl_temp_min_demain.Name = "Lbl_temp_min_demain";
            Lbl_temp_min_demain.Size = new Size(127, 15);
            Lbl_temp_min_demain.TabIndex = 8;
            Lbl_temp_min_demain.Text = "Lbl_temp_min_demain";
            // 
            // Lbl_temp_max_demain
            // 
            Lbl_temp_max_demain.AutoSize = true;
            Lbl_temp_max_demain.Location = new Point(314, 197);
            Lbl_temp_max_demain.Name = "Lbl_temp_max_demain";
            Lbl_temp_max_demain.Size = new Size(128, 15);
            Lbl_temp_max_demain.TabIndex = 7;
            Lbl_temp_max_demain.Text = "Lbl_temp_max_demain";
            // 
            // Lbl_MeteoDesc_demain
            // 
            Lbl_MeteoDesc_demain.AutoSize = true;
            Lbl_MeteoDesc_demain.Location = new Point(314, 169);
            Lbl_MeteoDesc_demain.Name = "Lbl_MeteoDesc_demain";
            Lbl_MeteoDesc_demain.Size = new Size(132, 15);
            Lbl_MeteoDesc_demain.TabIndex = 6;
            Lbl_MeteoDesc_demain.Text = "Lbl_MeteoDesc_demain";
            // 
            // Lbl_Demain
            // 
            Lbl_Demain.AutoSize = true;
            Lbl_Demain.Location = new Point(299, 86);
            Lbl_Demain.Name = "Lbl_Demain";
            Lbl_Demain.Size = new Size(69, 15);
            Lbl_Demain.TabIndex = 5;
            Lbl_Demain.Text = "Lbl_Demain";
            // 
            // Lbl_temp_min_apres_demain
            // 
            Lbl_temp_min_apres_demain.AutoSize = true;
            Lbl_temp_min_apres_demain.Location = new Point(578, 218);
            Lbl_temp_min_apres_demain.Name = "Lbl_temp_min_apres_demain";
            Lbl_temp_min_apres_demain.Size = new Size(160, 15);
            Lbl_temp_min_apres_demain.TabIndex = 4;
            Lbl_temp_min_apres_demain.Text = "Lbl_temp_min_apres_demain";
            // 
            // Lbl_temp_max_apres_demain
            // 
            Lbl_temp_max_apres_demain.AutoSize = true;
            Lbl_temp_max_apres_demain.Location = new Point(578, 193);
            Lbl_temp_max_apres_demain.Name = "Lbl_temp_max_apres_demain";
            Lbl_temp_max_apres_demain.Size = new Size(161, 15);
            Lbl_temp_max_apres_demain.TabIndex = 3;
            Lbl_temp_max_apres_demain.Text = "Lbl_temp_max_apres_demain";
            // 
            // Lbl_VilleNom
            // 
            Lbl_VilleNom.AutoSize = true;
            Lbl_VilleNom.Location = new Point(112, 69);
            Lbl_VilleNom.Margin = new Padding(2, 0, 2, 0);
            Lbl_VilleNom.Name = "Lbl_VilleNom";
            Lbl_VilleNom.Size = new Size(77, 15);
            Lbl_VilleNom.TabIndex = 2;
            Lbl_VilleNom.Text = "Lbl_VilleNom";
            // 
            // Lbl_MeteoDesc
            // 
            Lbl_MeteoDesc.Location = new Point(117, 192);
            Lbl_MeteoDesc.Name = "Lbl_MeteoDesc";
            Lbl_MeteoDesc.Size = new Size(152, 17);
            Lbl_MeteoDesc.TabIndex = 0;
            Lbl_MeteoDesc.Text = "Lbl_MeteoDesc";
            // 
            // Lbl_Uv
            // 
            Lbl_Uv.Location = new Point(117, 298);
            Lbl_Uv.Name = "Lbl_Uv";
            Lbl_Uv.Size = new Size(88, 17);
            Lbl_Uv.TabIndex = 0;
            Lbl_Uv.Text = "Lbl_Uv";
            // 
            // Lbl_Temperature
            // 
            Lbl_Temperature.AutoEllipsis = true;
            Lbl_Temperature.AutoSize = true;
            Lbl_Temperature.Location = new Point(117, 136);
            Lbl_Temperature.Name = "Lbl_Temperature";
            Lbl_Temperature.Size = new Size(95, 15);
            Lbl_Temperature.TabIndex = 1;
            Lbl_Temperature.Text = "Lbl_Temperature";
            // 
            // Lbl_humidite
            // 
            Lbl_humidite.Location = new Point(117, 342);
            Lbl_humidite.Name = "Lbl_humidite";
            Lbl_humidite.Size = new Size(88, 17);
            Lbl_humidite.TabIndex = 0;
            Lbl_humidite.Text = "Lbl_humidite";
            // 
            // Lbl_MeteoDesc_apres_demain
            // 
            Lbl_MeteoDesc_apres_demain.Location = new Point(574, 167);
            Lbl_MeteoDesc_apres_demain.Name = "Lbl_MeteoDesc_apres_demain";
            Lbl_MeteoDesc_apres_demain.Size = new Size(191, 17);
            Lbl_MeteoDesc_apres_demain.TabIndex = 0;
            Lbl_MeteoDesc_apres_demain.Text = "Lbl_MeteoDesc_apres_demain";
            // 
            // Lbl_pressure
            // 
            Lbl_pressure.Location = new Point(113, 261);
            Lbl_pressure.Name = "Lbl_pressure";
            Lbl_pressure.Size = new Size(88, 17);
            Lbl_pressure.TabIndex = 0;
            Lbl_pressure.Text = "Lbl_pressure";
            // 
            // Lbl_Speed_wind
            // 
            Lbl_Speed_wind.Location = new Point(117, 224);
            Lbl_Speed_wind.Name = "Lbl_Speed_wind";
            Lbl_Speed_wind.Size = new Size(122, 17);
            Lbl_Speed_wind.TabIndex = 0;
            Lbl_Speed_wind.Text = "Lbl_Speed_wind";
            // 
            // lbl_Apres_demain
            // 
            lbl_Apres_demain.Location = new Point(574, 86);
            lbl_Apres_demain.Name = "lbl_Apres_demain";
            lbl_Apres_demain.Size = new Size(149, 17);
            lbl_Apres_demain.TabIndex = 0;
            lbl_Apres_demain.Text = "lbl_Apres_demain";
            // 
            // Lbl_Uv_apres_demain
            // 
            Lbl_Uv_apres_demain.Location = new Point(574, 279);
            Lbl_Uv_apres_demain.Name = "Lbl_Uv_apres_demain";
            Lbl_Uv_apres_demain.Size = new Size(138, 17);
            Lbl_Uv_apres_demain.TabIndex = 0;
            Lbl_Uv_apres_demain.Text = "Lbl_Uv_apres_demain";
            // 
            // Aujourd_hui
            // 
            Aujourd_hui.Location = new Point(113, 105);
            Aujourd_hui.Name = "Aujourd_hui";
            Aujourd_hui.Size = new Size(88, 17);
            Aujourd_hui.TabIndex = 0;
            Aujourd_hui.Text = "Aujourd_hui";
            // 
            // Panel_Header
            // 
            Panel_Header.BackColor = SystemColors.ButtonFace;
            Panel_Header.Controls.Add(toolBar);
            Panel_Header.Dock = DockStyle.Top;
            Panel_Header.Location = new Point(0, 0);
            Panel_Header.Name = "Panel_Header";
            Panel_Header.Size = new Size(1254, 25);
            Panel_Header.TabIndex = 38;
            // 
            // toolBar
            // 
            toolBar.ContextMenuStrip = menuHamburger;
            toolBar.Dock = DockStyle.Left;
            toolBar.Image = Properties.Resources.menu_hamburger;
            toolBar.Location = new Point(0, 0);
            toolBar.Name = "toolBar";
            toolBar.Size = new Size(28, 25);
            toolBar.TabIndex = 0;
            toolBar.TabStop = false;
            toolBar.Click += toolBar_Click;
            // 
            // menuHamburger
            // 
            menuHamburger.Items.AddRange(new ToolStripItem[] { changerDeVilleToolStripMenuItem, sinscrireToolStripMenuItem, seConnecterToolStripMenuItem });
            menuHamburger.Name = "menuHamburger";
            menuHamburger.Size = new Size(160, 70);
            // 
            // changerDeVilleToolStripMenuItem
            // 
            changerDeVilleToolStripMenuItem.Name = "changerDeVilleToolStripMenuItem";
            changerDeVilleToolStripMenuItem.Size = new Size(159, 22);
            changerDeVilleToolStripMenuItem.Text = "Changer de ville";
            changerDeVilleToolStripMenuItem.Click += changerDeVilleToolStripMenuItem_Click;
            // 
            // sinscrireToolStripMenuItem
            // 
            sinscrireToolStripMenuItem.Name = "sinscrireToolStripMenuItem";
            sinscrireToolStripMenuItem.Size = new Size(159, 22);
            sinscrireToolStripMenuItem.Text = "S'inscrire";
            sinscrireToolStripMenuItem.Click += sinscrireToolStripMenuItem_Click;
            // 
            // seConnecterToolStripMenuItem
            // 
            seConnecterToolStripMenuItem.Name = "seConnecterToolStripMenuItem";
            seConnecterToolStripMenuItem.Size = new Size(159, 22);
            seConnecterToolStripMenuItem.Text = "Se connecter";
            seConnecterToolStripMenuItem.Click += seConnecterToolStripMenuItem_Click;
            // 
            // Panel_Inscription
            // 
            Panel_Inscription.BackColor = Color.Transparent;
            Panel_Inscription.Controls.Add(Lbl_Uname);
            Panel_Inscription.Controls.Add(Lbl_Conf_Mdp);
            Panel_Inscription.Controls.Add(Lbl_Mdp);
            Panel_Inscription.Controls.Add(textBoxMdpConf);
            Panel_Inscription.Controls.Add(textBoxMdp);
            Panel_Inscription.Controls.Add(textBoxUname);
            Panel_Inscription.Dock = DockStyle.Fill;
            Panel_Inscription.Location = new Point(0, 25);
            Panel_Inscription.Name = "Panel_Inscription";
            Panel_Inscription.Size = new Size(1254, 607);
            Panel_Inscription.TabIndex = 38;
            // 
            // Lbl_Uname
            // 
            Lbl_Uname.AutoSize = true;
            Lbl_Uname.Location = new Point(39, 44);
            Lbl_Uname.Name = "Lbl_Uname";
            Lbl_Uname.Size = new Size(175, 15);
            Lbl_Uname.TabIndex = 5;
            Lbl_Uname.Text = "Saissiez votre nom d'utilisateur :";
            // 
            // Lbl_Conf_Mdp
            // 
            Lbl_Conf_Mdp.AutoSize = true;
            Lbl_Conf_Mdp.Location = new Point(39, 216);
            Lbl_Conf_Mdp.Name = "Lbl_Conf_Mdp";
            Lbl_Conf_Mdp.Size = new Size(210, 15);
            Lbl_Conf_Mdp.TabIndex = 4;
            Lbl_Conf_Mdp.Text = "Veuillez confirmer votre mot de passe :";
            Lbl_Conf_Mdp.Visible = false;
            // 
            // Lbl_Mdp
            // 
            Lbl_Mdp.AutoSize = true;
            Lbl_Mdp.Location = new Point(39, 151);
            Lbl_Mdp.Name = "Lbl_Mdp";
            Lbl_Mdp.Size = new Size(160, 15);
            Lbl_Mdp.TabIndex = 3;
            Lbl_Mdp.Text = "Saisissez votre mot de passe :";
            Lbl_Mdp.Visible = false;
            // 
            // textBoxMdpConf
            // 
            textBoxMdpConf.Location = new Point(39, 234);
            textBoxMdpConf.Name = "textBoxMdpConf";
            textBoxMdpConf.Size = new Size(529, 23);
            textBoxMdpConf.TabIndex = 2;
            textBoxMdpConf.Visible = false;
            // 
            // textBoxMdp
            // 
            textBoxMdp.Location = new Point(39, 172);
            textBoxMdp.Name = "textBoxMdp";
            textBoxMdp.Size = new Size(529, 23);
            textBoxMdp.TabIndex = 1;
            textBoxMdp.Visible = false;
            // 
            // textBoxUname
            // 
            textBoxUname.Location = new Point(39, 62);
            textBoxUname.Name = "textBoxUname";
            textBoxUname.Size = new Size(529, 23);
            textBoxUname.TabIndex = 0;
            // 
            // Panel_Configuration
            // 
            Panel_Configuration.BackColor = Color.Transparent;
            Panel_Configuration.Controls.Add(Lbl_VilleFavorite);
            Panel_Configuration.Controls.Add(Lbl_EMail);
            Panel_Configuration.Controls.Add(textBoxVilleFavorite);
            Panel_Configuration.Controls.Add(textBoxEmail);
            Panel_Configuration.Dock = DockStyle.Fill;
            Panel_Configuration.Location = new Point(0, 25);
            Panel_Configuration.Name = "Panel_Configuration";
            Panel_Configuration.Size = new Size(1254, 607);
            Panel_Configuration.TabIndex = 3;
            // 
            // Lbl_VilleFavorite
            // 
            Lbl_VilleFavorite.AutoSize = true;
            Lbl_VilleFavorite.Location = new Point(320, 177);
            Lbl_VilleFavorite.Name = "Lbl_VilleFavorite";
            Lbl_VilleFavorite.Size = new Size(266, 15);
            Lbl_VilleFavorite.TabIndex = 3;
            Lbl_VilleFavorite.Text = "Veuillez saisir votre ville favorite afin d'être alerté :";
            Lbl_VilleFavorite.Visible = false;
            // 
            // Lbl_EMail
            // 
            Lbl_EMail.AutoSize = true;
            Lbl_EMail.Location = new Point(320, 44);
            Lbl_EMail.Name = "Lbl_EMail";
            Lbl_EMail.Size = new Size(173, 15);
            Lbl_EMail.TabIndex = 2;
            Lbl_EMail.Text = "Saisissez votre addresse e-mail :";
            // 
            // textBoxVilleFavorite
            // 
            textBoxVilleFavorite.Location = new Point(320, 195);
            textBoxVilleFavorite.Name = "textBoxVilleFavorite";
            textBoxVilleFavorite.Size = new Size(571, 23);
            textBoxVilleFavorite.TabIndex = 1;
            textBoxVilleFavorite.Visible = false;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(320, 61);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(571, 23);
            textBoxEmail.TabIndex = 0;
            // 
            // Panel_Connection
            // 
            Panel_Connection.BackColor = Color.Transparent;
            Panel_Connection.Controls.Add(Lbl_Mdp_Connection);
            Panel_Connection.Controls.Add(Lbl_Uname_Connection);
            Panel_Connection.Controls.Add(textBoxMdpConnection);
            Panel_Connection.Controls.Add(textBoxUconnection);
            Panel_Connection.Dock = DockStyle.Fill;
            Panel_Connection.Location = new Point(0, 25);
            Panel_Connection.Name = "Panel_Connection";
            Panel_Connection.Size = new Size(1254, 607);
            Panel_Connection.TabIndex = 2;
            // 
            // Lbl_Mdp_Connection
            // 
            Lbl_Mdp_Connection.AutoSize = true;
            Lbl_Mdp_Connection.Location = new Point(118, 175);
            Lbl_Mdp_Connection.Name = "Lbl_Mdp_Connection";
            Lbl_Mdp_Connection.Size = new Size(184, 15);
            Lbl_Mdp_Connection.TabIndex = 3;
            Lbl_Mdp_Connection.Text = "Veuillez saisir votre mot de passe :";
            Lbl_Mdp_Connection.Visible = false;
            // 
            // Lbl_Uname_Connection
            // 
            Lbl_Uname_Connection.AutoSize = true;
            Lbl_Uname_Connection.Location = new Point(119, 41);
            Lbl_Uname_Connection.Name = "Lbl_Uname_Connection";
            Lbl_Uname_Connection.Size = new Size(204, 15);
            Lbl_Uname_Connection.TabIndex = 2;
            Lbl_Uname_Connection.Text = "Veuillez saisir votre nom d'utilisateur :";
            // 
            // textBoxMdpConnection
            // 
            textBoxMdpConnection.Location = new Point(119, 193);
            textBoxMdpConnection.Name = "textBoxMdpConnection";
            textBoxMdpConnection.Size = new Size(525, 23);
            textBoxMdpConnection.TabIndex = 1;
            textBoxMdpConnection.Visible = false;
            // 
            // textBoxUconnection
            // 
            textBoxUconnection.Location = new Point(119, 59);
            textBoxUconnection.Name = "textBoxUconnection";
            textBoxUconnection.Size = new Size(525, 23);
            textBoxUconnection.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1254, 632);
            Controls.Add(Panel_Connection);
            Controls.Add(Panel_Configuration);
            Controls.Add(Panel_Inscription);
            Controls.Add(Panel_Header);
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
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconeMeteo_j6).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconeMeteo_j3).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconeMeteo_j5).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconeMeteo_j4).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconeMeteo_apres_demain_bis).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconeMeteo_demain).EndInit();
            Panel_Header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)toolBar).EndInit();
            menuHamburger.ResumeLayout(false);
            Panel_Inscription.ResumeLayout(false);
            Panel_Inscription.PerformLayout();
            Panel_Configuration.ResumeLayout(false);
            Panel_Configuration.PerformLayout();
            Panel_Connection.ResumeLayout(false);
            Panel_Connection.PerformLayout();
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
        private Panel Panel_Header;
        private ContextMenuStrip menuHamburger;
        private ToolStripMenuItem changerDeVilleToolStripMenuItem;
        private ToolStripMenuItem sinscrireToolStripMenuItem;
        private ToolStripMenuItem seConnecterToolStripMenuItem;
        private PictureBox toolBar;
        private Panel Panel_Inscription;
        private TextBox textBoxMdpConf;
        private TextBox textBoxMdp;
        private TextBox textBoxUname;
        private Panel Panel_Configuration;
        private TextBox textBoxVilleFavorite;
        private TextBox textBoxEmail;
        private Panel Panel_Connection;
        private TextBox textBoxMdpConnection;
        private TextBox textBoxUconnection;
        private Label Lbl_Uname;
        private Label Lbl_Conf_Mdp;
        private Label Lbl_Mdp;
        private Label Lbl_VilleFavorite;
        private Label Lbl_EMail;
        private Label Lbl_Uname_Connection;
        private Label Lbl_Mdp_Connection;
    }
}
