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
            tableLayoutPanel3 = new TableLayoutPanel();
            Lbl_VilleNom = new Label();
            Lbl_Temperature = new Label();
            Lbl_coucher_soleil = new Label();
            Lbl_lever_soleil = new Label();
            Lbl_humidite = new Label();
            Lbl_Uv = new Label();
            Lbl_pressure = new Label();
            Lbl_Speed_wind = new Label();
            Lbl_MeteoDesc = new Label();
            Lbl_temp_max = new Label();
            Lbl_temp_min = new Label();
            Aujourd_hui = new Label();
            iconeMeteo = new PictureBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            iconeMeteo_demain = new PictureBox();
            Lbl_Demain = new Label();
            Lbl_diff_sunset_demain = new Label();
            iconeMeteo_apres_demain_bis = new PictureBox();
            Lbl_diff_temp_ensoleilement_demain = new Label();
            Lbl_temp_min_demain = new Label();
            Lbl_Uv_demain = new Label();
            Lbl_temp_max_demain = new Label();
            Lbl_MeteoDesc_demain = new Label();
            lbl_Apres_demain = new Label();
            Lbl_MeteoDesc_apres_demain = new Label();
            Lbl_temp_max_apres_demain = new Label();
            Lbl_temp_min_apres_demain = new Label();
            Lbl_Uv_apres_demain = new Label();
            Lbl_diff_temp_ensoleilement_apres_demain = new Label();
            Lbl_diff_sunset_apres_demain = new Label();
            pictureBox2 = new PictureBox();
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
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconeMeteo).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconeMeteo_demain).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconeMeteo_apres_demain_bis).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            Panel_Accueil.Size = new Size(1791, 1050);
            Panel_Accueil.TabIndex = 0;
            // 
            // Barre_Recherche
            // 
            Barre_Recherche.AccessibleName = "Barre_Recherche";
            Barre_Recherche.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Barre_Recherche.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Barre_Recherche.Location = new Point(191, 142);
            Barre_Recherche.Margin = new Padding(2);
            Barre_Recherche.Name = "Barre_Recherche";
            Barre_Recherche.ScrollBars = ScrollBars.Vertical;
            Barre_Recherche.Size = new Size(1410, 31);
            Barre_Recherche.TabIndex = 0;
            // 
            // Loupe
            // 
            Loupe.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Loupe.BackgroundImageLayout = ImageLayout.Stretch;
            Loupe.Image = (Image)resources.GetObject("Loupe.Image");
            Loupe.Location = new Point(1609, 142);
            Loupe.Margin = new Padding(2);
            Loupe.Name = "Loupe";
            Loupe.Size = new Size(32, 38);
            Loupe.TabIndex = 2;
            Loupe.TabStop = false;
            Loupe.Click += Loupe_Click;
            // 
            // Bouton_Loc
            // 
            Bouton_Loc.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Bouton_Loc.Image = Properties.Resources.gps__3_;
            Bouton_Loc.Location = new Point(156, 142);
            Bouton_Loc.Margin = new Padding(2);
            Bouton_Loc.Name = "Bouton_Loc";
            Bouton_Loc.Size = new Size(39, 40);
            Bouton_Loc.TabIndex = 1;
            Bouton_Loc.UseVisualStyleBackColor = true;
            Bouton_Loc.Click += Bouton_Loc_Click;
            // 
            // Panel_Meteo_Ville
            // 
            Panel_Meteo_Ville.Controls.Add(tableLayoutPanel1);
            Panel_Meteo_Ville.Controls.Add(tableLayoutPanel3);
            Panel_Meteo_Ville.Controls.Add(tableLayoutPanel2);
            Panel_Meteo_Ville.Dock = DockStyle.Fill;
            Panel_Meteo_Ville.Location = new Point(0, 0);
            Panel_Meteo_Ville.Margin = new Padding(4, 5, 4, 5);
            Panel_Meteo_Ville.Name = "Panel_Meteo_Ville";
            Panel_Meteo_Ville.Size = new Size(1791, 1050);
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
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 26F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 26F));
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
            tableLayoutPanel1.Location = new Point(69, 682);
            tableLayoutPanel1.Margin = new Padding(4, 2, 4, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(1431, 272);
            tableLayoutPanel1.TabIndex = 37;
            // 
            // Lbl_j_3
            // 
            Lbl_j_3.Dock = DockStyle.Fill;
            Lbl_j_3.Location = new Point(4, 0);
            Lbl_j_3.Margin = new Padding(4, 0, 4, 0);
            Lbl_j_3.Name = "Lbl_j_3";
            Lbl_j_3.Size = new Size(270, 85);
            Lbl_j_3.TabIndex = 19;
            Lbl_j_3.Text = "Lbl_j_3";
            // 
            // iconeMeteo_j6
            // 
            iconeMeteo_j6.Location = new Point(1353, 2);
            iconeMeteo_j6.Margin = new Padding(4, 2, 4, 2);
            iconeMeteo_j6.Name = "iconeMeteo_j6";
            iconeMeteo_j6.Size = new Size(54, 68);
            iconeMeteo_j6.TabIndex = 36;
            iconeMeteo_j6.TabStop = false;
            // 
            // Lbl_min_j3
            // 
            Lbl_min_j3.Dock = DockStyle.Fill;
            Lbl_min_j3.Location = new Point(4, 85);
            Lbl_min_j3.Margin = new Padding(4, 0, 4, 0);
            Lbl_min_j3.Name = "Lbl_min_j3";
            Lbl_min_j3.Size = new Size(270, 75);
            Lbl_min_j3.TabIndex = 20;
            Lbl_min_j3.Text = "Lbl_min_j3";
            // 
            // Lbl_max_j6
            // 
            Lbl_max_j6.Dock = DockStyle.Fill;
            Lbl_max_j6.Location = new Point(1075, 160);
            Lbl_max_j6.Margin = new Padding(4, 0, 4, 0);
            Lbl_max_j6.Name = "Lbl_max_j6";
            Lbl_max_j6.Size = new Size(270, 122);
            Lbl_max_j6.TabIndex = 35;
            Lbl_max_j6.Text = "Lbl_max_j6";
            // 
            // Lbl_max_j3
            // 
            Lbl_max_j3.Dock = DockStyle.Fill;
            Lbl_max_j3.Location = new Point(4, 160);
            Lbl_max_j3.Margin = new Padding(4, 0, 4, 0);
            Lbl_max_j3.Name = "Lbl_max_j3";
            Lbl_max_j3.Size = new Size(270, 122);
            Lbl_max_j3.TabIndex = 21;
            Lbl_max_j3.Text = "Lbl_max_j3";
            // 
            // Lbl_min_j6
            // 
            Lbl_min_j6.Dock = DockStyle.Fill;
            Lbl_min_j6.Location = new Point(1075, 85);
            Lbl_min_j6.Margin = new Padding(4, 0, 4, 0);
            Lbl_min_j6.Name = "Lbl_min_j6";
            Lbl_min_j6.Size = new Size(270, 75);
            Lbl_min_j6.TabIndex = 34;
            Lbl_min_j6.Text = "Lbl_min_j6";
            // 
            // iconeMeteo_j3
            // 
            iconeMeteo_j3.Location = new Point(282, 2);
            iconeMeteo_j3.Margin = new Padding(4, 2, 4, 2);
            iconeMeteo_j3.Name = "iconeMeteo_j3";
            iconeMeteo_j3.Size = new Size(54, 62);
            iconeMeteo_j3.TabIndex = 31;
            iconeMeteo_j3.TabStop = false;
            // 
            // Lbl_j_6
            // 
            Lbl_j_6.Dock = DockStyle.Fill;
            Lbl_j_6.Location = new Point(1075, 0);
            Lbl_j_6.Margin = new Padding(4, 0, 4, 0);
            Lbl_j_6.Name = "Lbl_j_6";
            Lbl_j_6.Size = new Size(270, 85);
            Lbl_j_6.TabIndex = 33;
            Lbl_j_6.Text = "Lbl_j_6";
            // 
            // Lbl_j_4
            // 
            Lbl_j_4.Dock = DockStyle.Fill;
            Lbl_j_4.Location = new Point(361, 0);
            Lbl_j_4.Margin = new Padding(4, 0, 4, 0);
            Lbl_j_4.Name = "Lbl_j_4";
            Lbl_j_4.Size = new Size(270, 85);
            Lbl_j_4.TabIndex = 23;
            Lbl_j_4.Text = "Lbl_j_4";
            // 
            // Lbl_min_j4
            // 
            Lbl_min_j4.Dock = DockStyle.Fill;
            Lbl_min_j4.Location = new Point(361, 85);
            Lbl_min_j4.Margin = new Padding(4, 0, 4, 0);
            Lbl_min_j4.Name = "Lbl_min_j4";
            Lbl_min_j4.Size = new Size(270, 75);
            Lbl_min_j4.TabIndex = 24;
            Lbl_min_j4.Text = "Lbl_min_j4";
            // 
            // iconeMeteo_j5
            // 
            iconeMeteo_j5.Location = new Point(996, 2);
            iconeMeteo_j5.Margin = new Padding(4, 2, 4, 2);
            iconeMeteo_j5.Name = "iconeMeteo_j5";
            iconeMeteo_j5.Size = new Size(54, 68);
            iconeMeteo_j5.TabIndex = 30;
            iconeMeteo_j5.TabStop = false;
            // 
            // Lbl_max_j4
            // 
            Lbl_max_j4.Dock = DockStyle.Fill;
            Lbl_max_j4.Location = new Point(361, 160);
            Lbl_max_j4.Margin = new Padding(4, 0, 4, 0);
            Lbl_max_j4.Name = "Lbl_max_j4";
            Lbl_max_j4.Size = new Size(270, 122);
            Lbl_max_j4.TabIndex = 25;
            Lbl_max_j4.Text = "Lbl_max_j4";
            // 
            // Lbl_max_j5
            // 
            Lbl_max_j5.Dock = DockStyle.Fill;
            Lbl_max_j5.Location = new Point(718, 160);
            Lbl_max_j5.Margin = new Padding(4, 0, 4, 0);
            Lbl_max_j5.Name = "Lbl_max_j5";
            Lbl_max_j5.Size = new Size(270, 122);
            Lbl_max_j5.TabIndex = 29;
            Lbl_max_j5.Text = "Lbl_max_j5";
            // 
            // iconeMeteo_j4
            // 
            iconeMeteo_j4.Location = new Point(639, 2);
            iconeMeteo_j4.Margin = new Padding(4, 2, 4, 2);
            iconeMeteo_j4.Name = "iconeMeteo_j4";
            iconeMeteo_j4.Size = new Size(54, 68);
            iconeMeteo_j4.TabIndex = 26;
            iconeMeteo_j4.TabStop = false;
            // 
            // Lbl_min_j5
            // 
            Lbl_min_j5.Dock = DockStyle.Fill;
            Lbl_min_j5.Location = new Point(718, 85);
            Lbl_min_j5.Margin = new Padding(4, 0, 4, 0);
            Lbl_min_j5.Name = "Lbl_min_j5";
            Lbl_min_j5.Size = new Size(270, 75);
            Lbl_min_j5.TabIndex = 28;
            Lbl_min_j5.Text = "Lbl_min_j5";
            // 
            // Lbl_j_5
            // 
            Lbl_j_5.Dock = DockStyle.Fill;
            Lbl_j_5.Location = new Point(718, 0);
            Lbl_j_5.Margin = new Padding(4, 0, 4, 0);
            Lbl_j_5.Name = "Lbl_j_5";
            Lbl_j_5.Size = new Size(270, 85);
            Lbl_j_5.TabIndex = 27;
            Lbl_j_5.Text = "Lbl_j_5";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(Lbl_VilleNom, 0, 0);
            tableLayoutPanel3.Controls.Add(Lbl_Temperature, 0, 3);
            tableLayoutPanel3.Controls.Add(Lbl_coucher_soleil, 0, 11);
            tableLayoutPanel3.Controls.Add(Lbl_lever_soleil, 0, 10);
            tableLayoutPanel3.Controls.Add(Lbl_humidite, 0, 9);
            tableLayoutPanel3.Controls.Add(Lbl_Uv, 0, 8);
            tableLayoutPanel3.Controls.Add(Lbl_pressure, 0, 7);
            tableLayoutPanel3.Controls.Add(Lbl_Speed_wind, 0, 6);
            tableLayoutPanel3.Controls.Add(Lbl_MeteoDesc, 0, 5);
            tableLayoutPanel3.Controls.Add(Lbl_temp_max, 0, 4);
            tableLayoutPanel3.Controls.Add(Lbl_temp_min, 0, 2);
            tableLayoutPanel3.Controls.Add(Aujourd_hui, 0, 1);
            tableLayoutPanel3.Controls.Add(iconeMeteo, 1, 0);
            tableLayoutPanel3.Location = new Point(4, 42);
            tableLayoutPanel3.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 12;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333335F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333335F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333335F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333335F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333335F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333335F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333335F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333335F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333335F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333335F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333335F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333335F));
            tableLayoutPanel3.Size = new Size(472, 588);
            tableLayoutPanel3.TabIndex = 39;
            // 
            // Lbl_VilleNom
            // 
            Lbl_VilleNom.AutoSize = true;
            Lbl_VilleNom.Dock = DockStyle.Fill;
            Lbl_VilleNom.Location = new Point(2, 0);
            Lbl_VilleNom.Margin = new Padding(2, 0, 2, 0);
            Lbl_VilleNom.Name = "Lbl_VilleNom";
            Lbl_VilleNom.Size = new Size(232, 49);
            Lbl_VilleNom.TabIndex = 2;
            Lbl_VilleNom.Text = "Lbl_VilleNom";
            // 
            // Lbl_Temperature
            // 
            Lbl_Temperature.AutoEllipsis = true;
            Lbl_Temperature.AutoSize = true;
            Lbl_Temperature.BackColor = SystemColors.Control;
            Lbl_Temperature.Location = new Point(4, 147);
            Lbl_Temperature.Margin = new Padding(4, 0, 4, 0);
            Lbl_Temperature.Name = "Lbl_Temperature";
            Lbl_Temperature.Size = new Size(140, 25);
            Lbl_Temperature.TabIndex = 1;
            Lbl_Temperature.Text = "Lbl_Temperature";
            // 
            // Lbl_coucher_soleil
            // 
            Lbl_coucher_soleil.AutoSize = true;
            Lbl_coucher_soleil.BackColor = SystemColors.Control;
            Lbl_coucher_soleil.Location = new Point(4, 539);
            Lbl_coucher_soleil.Margin = new Padding(4, 0, 4, 0);
            Lbl_coucher_soleil.Name = "Lbl_coucher_soleil";
            Lbl_coucher_soleil.Size = new Size(151, 25);
            Lbl_coucher_soleil.TabIndex = 14;
            Lbl_coucher_soleil.Text = "Lbl_coucher_soleil";
            // 
            // Lbl_lever_soleil
            // 
            Lbl_lever_soleil.AutoSize = true;
            Lbl_lever_soleil.Location = new Point(4, 490);
            Lbl_lever_soleil.Margin = new Padding(4, 0, 4, 0);
            Lbl_lever_soleil.Name = "Lbl_lever_soleil";
            Lbl_lever_soleil.Size = new Size(126, 25);
            Lbl_lever_soleil.TabIndex = 13;
            Lbl_lever_soleil.Text = "Lbl_lever_soleil";
            // 
            // Lbl_humidite
            // 
            Lbl_humidite.AutoSize = true;
            Lbl_humidite.Location = new Point(4, 441);
            Lbl_humidite.Margin = new Padding(4, 0, 4, 0);
            Lbl_humidite.Name = "Lbl_humidite";
            Lbl_humidite.Size = new Size(112, 25);
            Lbl_humidite.TabIndex = 0;
            Lbl_humidite.Text = "Lbl_humidite";
            // 
            // Lbl_Uv
            // 
            Lbl_Uv.AutoSize = true;
            Lbl_Uv.Location = new Point(4, 392);
            Lbl_Uv.Margin = new Padding(4, 0, 4, 0);
            Lbl_Uv.Name = "Lbl_Uv";
            Lbl_Uv.Size = new Size(63, 25);
            Lbl_Uv.TabIndex = 0;
            Lbl_Uv.Text = "Lbl_Uv";
            // 
            // Lbl_pressure
            // 
            Lbl_pressure.AutoSize = true;
            Lbl_pressure.Location = new Point(4, 343);
            Lbl_pressure.Margin = new Padding(4, 0, 4, 0);
            Lbl_pressure.Name = "Lbl_pressure";
            Lbl_pressure.Size = new Size(109, 25);
            Lbl_pressure.TabIndex = 0;
            Lbl_pressure.Text = "Lbl_pressure";
            // 
            // Lbl_Speed_wind
            // 
            Lbl_Speed_wind.AutoSize = true;
            Lbl_Speed_wind.Location = new Point(4, 294);
            Lbl_Speed_wind.Margin = new Padding(4, 0, 4, 0);
            Lbl_Speed_wind.Name = "Lbl_Speed_wind";
            Lbl_Speed_wind.Size = new Size(137, 25);
            Lbl_Speed_wind.TabIndex = 0;
            Lbl_Speed_wind.Text = "Lbl_Speed_wind";
            // 
            // Lbl_MeteoDesc
            // 
            Lbl_MeteoDesc.AutoSize = true;
            Lbl_MeteoDesc.Location = new Point(4, 245);
            Lbl_MeteoDesc.Margin = new Padding(4, 0, 4, 0);
            Lbl_MeteoDesc.Name = "Lbl_MeteoDesc";
            Lbl_MeteoDesc.Size = new Size(131, 25);
            Lbl_MeteoDesc.TabIndex = 0;
            Lbl_MeteoDesc.Text = "Lbl_MeteoDesc";
            // 
            // Lbl_temp_max
            // 
            Lbl_temp_max.AutoSize = true;
            Lbl_temp_max.Location = new Point(4, 196);
            Lbl_temp_max.Margin = new Padding(4, 0, 4, 25);
            Lbl_temp_max.Name = "Lbl_temp_max";
            Lbl_temp_max.Size = new Size(124, 24);
            Lbl_temp_max.TabIndex = 11;
            Lbl_temp_max.Text = "Lbl_temp_max";
            // 
            // Lbl_temp_min
            // 
            Lbl_temp_min.AutoSize = true;
            Lbl_temp_min.Location = new Point(4, 98);
            Lbl_temp_min.Margin = new Padding(4, 0, 4, 25);
            Lbl_temp_min.Name = "Lbl_temp_min";
            Lbl_temp_min.Size = new Size(121, 24);
            Lbl_temp_min.TabIndex = 12;
            Lbl_temp_min.Text = "Lbl_temp_min";
            // 
            // Aujourd_hui
            // 
            Aujourd_hui.AutoSize = true;
            Aujourd_hui.Location = new Point(4, 49);
            Aujourd_hui.Margin = new Padding(4, 0, 4, 0);
            Aujourd_hui.Name = "Aujourd_hui";
            Aujourd_hui.Size = new Size(107, 25);
            Aujourd_hui.TabIndex = 0;
            Aujourd_hui.Text = "Aujourd_hui";
            // 
            // iconeMeteo
            // 
            iconeMeteo.Location = new Point(240, 4);
            iconeMeteo.Margin = new Padding(4);
            iconeMeteo.Name = "iconeMeteo";
            iconeMeteo.Size = new Size(156, 41);
            iconeMeteo.TabIndex = 15;
            iconeMeteo.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54.86111F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.13889F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 339F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 191F));
            tableLayoutPanel2.Controls.Add(pictureBox1, 1, 6);
            tableLayoutPanel2.Controls.Add(iconeMeteo_demain, 1, 0);
            tableLayoutPanel2.Controls.Add(Lbl_Demain, 0, 0);
            tableLayoutPanel2.Controls.Add(Lbl_diff_sunset_demain, 0, 6);
            tableLayoutPanel2.Controls.Add(iconeMeteo_apres_demain_bis, 3, 0);
            tableLayoutPanel2.Controls.Add(Lbl_diff_temp_ensoleilement_demain, 0, 5);
            tableLayoutPanel2.Controls.Add(Lbl_temp_min_demain, 0, 3);
            tableLayoutPanel2.Controls.Add(Lbl_Uv_demain, 0, 4);
            tableLayoutPanel2.Controls.Add(Lbl_temp_max_demain, 0, 2);
            tableLayoutPanel2.Controls.Add(Lbl_MeteoDesc_demain, 0, 1);
            tableLayoutPanel2.Controls.Add(lbl_Apres_demain, 2, 0);
            tableLayoutPanel2.Controls.Add(Lbl_MeteoDesc_apres_demain, 2, 1);
            tableLayoutPanel2.Controls.Add(Lbl_temp_max_apres_demain, 2, 2);
            tableLayoutPanel2.Controls.Add(Lbl_temp_min_apres_demain, 2, 3);
            tableLayoutPanel2.Controls.Add(Lbl_Uv_apres_demain, 2, 4);
            tableLayoutPanel2.Controls.Add(Lbl_diff_temp_ensoleilement_apres_demain, 2, 5);
            tableLayoutPanel2.Controls.Add(Lbl_diff_sunset_apres_demain, 2, 6);
            tableLayoutPanel2.Controls.Add(pictureBox2, 1, 1);
            tableLayoutPanel2.Location = new Point(478, 42);
            tableLayoutPanel2.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 7;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857132F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857132F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel2.Size = new Size(1022, 590);
            tableLayoutPanel2.TabIndex = 38;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(273, 508);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(145, 41);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // iconeMeteo_demain
            // 
            iconeMeteo_demain.Location = new Point(273, 4);
            iconeMeteo_demain.Margin = new Padding(4);
            iconeMeteo_demain.Name = "iconeMeteo_demain";
            iconeMeteo_demain.Size = new Size(156, 76);
            iconeMeteo_demain.TabIndex = 40;
            iconeMeteo_demain.TabStop = false;
            // 
            // Lbl_Demain
            // 
            Lbl_Demain.AutoSize = true;
            Lbl_Demain.Location = new Point(4, 0);
            Lbl_Demain.Margin = new Padding(4, 0, 4, 0);
            Lbl_Demain.Name = "Lbl_Demain";
            Lbl_Demain.Size = new Size(103, 25);
            Lbl_Demain.TabIndex = 5;
            Lbl_Demain.Text = "Lbl_Demain";
            // 
            // Lbl_diff_sunset_demain
            // 
            Lbl_diff_sunset_demain.AutoSize = true;
            Lbl_diff_sunset_demain.Dock = DockStyle.Fill;
            Lbl_diff_sunset_demain.Location = new Point(4, 504);
            Lbl_diff_sunset_demain.Margin = new Padding(4, 0, 4, 0);
            Lbl_diff_sunset_demain.Name = "Lbl_diff_sunset_demain";
            Lbl_diff_sunset_demain.Size = new Size(261, 86);
            Lbl_diff_sunset_demain.TabIndex = 17;
            Lbl_diff_sunset_demain.Text = "Lbl_diff_sunset_demain";
            // 
            // iconeMeteo_apres_demain_bis
            // 
            iconeMeteo_apres_demain_bis.Location = new Point(834, 2);
            iconeMeteo_apres_demain_bis.Margin = new Padding(4, 2, 4, 2);
            iconeMeteo_apres_demain_bis.Name = "iconeMeteo_apres_demain_bis";
            iconeMeteo_apres_demain_bis.Size = new Size(156, 78);
            iconeMeteo_apres_demain_bis.TabIndex = 32;
            iconeMeteo_apres_demain_bis.TabStop = false;
            // 
            // Lbl_diff_temp_ensoleilement_demain
            // 
            Lbl_diff_temp_ensoleilement_demain.AutoSize = true;
            Lbl_diff_temp_ensoleilement_demain.Dock = DockStyle.Fill;
            Lbl_diff_temp_ensoleilement_demain.Location = new Point(4, 420);
            Lbl_diff_temp_ensoleilement_demain.Margin = new Padding(4, 0, 4, 0);
            Lbl_diff_temp_ensoleilement_demain.Name = "Lbl_diff_temp_ensoleilement_demain";
            Lbl_diff_temp_ensoleilement_demain.Size = new Size(261, 84);
            Lbl_diff_temp_ensoleilement_demain.TabIndex = 15;
            Lbl_diff_temp_ensoleilement_demain.Text = "Lbl_diff_temp_ensoleilement_demain";
            // 
            // Lbl_temp_min_demain
            // 
            Lbl_temp_min_demain.AutoSize = true;
            Lbl_temp_min_demain.Dock = DockStyle.Fill;
            Lbl_temp_min_demain.Location = new Point(4, 252);
            Lbl_temp_min_demain.Margin = new Padding(4, 0, 4, 0);
            Lbl_temp_min_demain.Name = "Lbl_temp_min_demain";
            Lbl_temp_min_demain.Size = new Size(261, 84);
            Lbl_temp_min_demain.TabIndex = 8;
            Lbl_temp_min_demain.Text = "Lbl_temp_min_demain";
            // 
            // Lbl_Uv_demain
            // 
            Lbl_Uv_demain.AutoSize = true;
            Lbl_Uv_demain.Dock = DockStyle.Fill;
            Lbl_Uv_demain.Location = new Point(4, 336);
            Lbl_Uv_demain.Margin = new Padding(4, 0, 4, 0);
            Lbl_Uv_demain.Name = "Lbl_Uv_demain";
            Lbl_Uv_demain.Size = new Size(261, 84);
            Lbl_Uv_demain.TabIndex = 9;
            Lbl_Uv_demain.Text = "Lbl_Uv_demain";
            // 
            // Lbl_temp_max_demain
            // 
            Lbl_temp_max_demain.AutoSize = true;
            Lbl_temp_max_demain.Dock = DockStyle.Fill;
            Lbl_temp_max_demain.Location = new Point(4, 168);
            Lbl_temp_max_demain.Margin = new Padding(4, 0, 4, 0);
            Lbl_temp_max_demain.Name = "Lbl_temp_max_demain";
            Lbl_temp_max_demain.Size = new Size(261, 84);
            Lbl_temp_max_demain.TabIndex = 7;
            Lbl_temp_max_demain.Text = "Lbl_temp_max_demain";
            // 
            // Lbl_MeteoDesc_demain
            // 
            Lbl_MeteoDesc_demain.AutoSize = true;
            Lbl_MeteoDesc_demain.Dock = DockStyle.Fill;
            Lbl_MeteoDesc_demain.Location = new Point(4, 84);
            Lbl_MeteoDesc_demain.Margin = new Padding(4, 0, 4, 0);
            Lbl_MeteoDesc_demain.Name = "Lbl_MeteoDesc_demain";
            Lbl_MeteoDesc_demain.Size = new Size(261, 84);
            Lbl_MeteoDesc_demain.TabIndex = 6;
            Lbl_MeteoDesc_demain.Text = "Lbl_MeteoDesc_demain";
            // 
            // lbl_Apres_demain
            // 
            lbl_Apres_demain.Location = new Point(495, 0);
            lbl_Apres_demain.Margin = new Padding(4, 0, 4, 0);
            lbl_Apres_demain.Name = "lbl_Apres_demain";
            lbl_Apres_demain.Size = new Size(212, 28);
            lbl_Apres_demain.TabIndex = 0;
            lbl_Apres_demain.Text = "lbl_Apres_demain";
            // 
            // Lbl_MeteoDesc_apres_demain
            // 
            Lbl_MeteoDesc_apres_demain.Dock = DockStyle.Fill;
            Lbl_MeteoDesc_apres_demain.Location = new Point(495, 84);
            Lbl_MeteoDesc_apres_demain.Margin = new Padding(4, 0, 4, 0);
            Lbl_MeteoDesc_apres_demain.Name = "Lbl_MeteoDesc_apres_demain";
            Lbl_MeteoDesc_apres_demain.Size = new Size(331, 84);
            Lbl_MeteoDesc_apres_demain.TabIndex = 0;
            Lbl_MeteoDesc_apres_demain.Text = "Lbl_MeteoDesc_apres_demain";
            // 
            // Lbl_temp_max_apres_demain
            // 
            Lbl_temp_max_apres_demain.AutoSize = true;
            Lbl_temp_max_apres_demain.Dock = DockStyle.Fill;
            Lbl_temp_max_apres_demain.Location = new Point(495, 168);
            Lbl_temp_max_apres_demain.Margin = new Padding(4, 0, 4, 0);
            Lbl_temp_max_apres_demain.Name = "Lbl_temp_max_apres_demain";
            Lbl_temp_max_apres_demain.Size = new Size(331, 84);
            Lbl_temp_max_apres_demain.TabIndex = 3;
            Lbl_temp_max_apres_demain.Text = "Lbl_temp_max_apres_demain";
            // 
            // Lbl_temp_min_apres_demain
            // 
            Lbl_temp_min_apres_demain.AutoSize = true;
            Lbl_temp_min_apres_demain.Dock = DockStyle.Fill;
            Lbl_temp_min_apres_demain.Location = new Point(495, 252);
            Lbl_temp_min_apres_demain.Margin = new Padding(4, 0, 4, 0);
            Lbl_temp_min_apres_demain.Name = "Lbl_temp_min_apres_demain";
            Lbl_temp_min_apres_demain.Size = new Size(331, 84);
            Lbl_temp_min_apres_demain.TabIndex = 4;
            Lbl_temp_min_apres_demain.Text = "Lbl_temp_min_apres_demain";
            // 
            // Lbl_Uv_apres_demain
            // 
            Lbl_Uv_apres_demain.Dock = DockStyle.Fill;
            Lbl_Uv_apres_demain.Location = new Point(495, 336);
            Lbl_Uv_apres_demain.Margin = new Padding(4, 0, 4, 0);
            Lbl_Uv_apres_demain.Name = "Lbl_Uv_apres_demain";
            Lbl_Uv_apres_demain.Size = new Size(331, 84);
            Lbl_Uv_apres_demain.TabIndex = 0;
            Lbl_Uv_apres_demain.Text = "Lbl_Uv_apres_demain";
            // 
            // Lbl_diff_temp_ensoleilement_apres_demain
            // 
            Lbl_diff_temp_ensoleilement_apres_demain.AutoSize = true;
            Lbl_diff_temp_ensoleilement_apres_demain.Dock = DockStyle.Fill;
            Lbl_diff_temp_ensoleilement_apres_demain.Location = new Point(495, 420);
            Lbl_diff_temp_ensoleilement_apres_demain.Margin = new Padding(4, 0, 4, 0);
            Lbl_diff_temp_ensoleilement_apres_demain.Name = "Lbl_diff_temp_ensoleilement_apres_demain";
            Lbl_diff_temp_ensoleilement_apres_demain.Size = new Size(331, 84);
            Lbl_diff_temp_ensoleilement_apres_demain.TabIndex = 16;
            Lbl_diff_temp_ensoleilement_apres_demain.Text = "Lbl_diff_temp_ensoleilement_apres_demain";
            // 
            // Lbl_diff_sunset_apres_demain
            // 
            Lbl_diff_sunset_apres_demain.AutoSize = true;
            Lbl_diff_sunset_apres_demain.Dock = DockStyle.Fill;
            Lbl_diff_sunset_apres_demain.Location = new Point(495, 504);
            Lbl_diff_sunset_apres_demain.Margin = new Padding(4, 0, 4, 0);
            Lbl_diff_sunset_apres_demain.Name = "Lbl_diff_sunset_apres_demain";
            Lbl_diff_sunset_apres_demain.Size = new Size(331, 86);
            Lbl_diff_sunset_apres_demain.TabIndex = 18;
            Lbl_diff_sunset_apres_demain.Text = "Lbl_diff_sunset_apres_demain";
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(273, 88);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(156, 76);
            pictureBox2.TabIndex = 41;
            pictureBox2.TabStop = false;
            // 
            // Panel_Header
            // 
            Panel_Header.BackColor = Color.Transparent;
            Panel_Header.Controls.Add(toolBar);
            Panel_Header.Dock = DockStyle.Top;
            Panel_Header.Location = new Point(0, 0);
            Panel_Header.Margin = new Padding(4, 5, 4, 5);
            Panel_Header.Name = "Panel_Header";
            Panel_Header.Size = new Size(1791, 25);
            Panel_Header.TabIndex = 38;
            // 
            // toolBar
            // 
            toolBar.ContextMenuStrip = menuHamburger;
            toolBar.Dock = DockStyle.Left;
            toolBar.Image = Properties.Resources.menu_hamburger;
            toolBar.Location = new Point(0, 0);
            toolBar.Margin = new Padding(4, 5, 4, 5);
            toolBar.Name = "toolBar";
            toolBar.Size = new Size(40, 25);
            toolBar.TabIndex = 0;
            toolBar.TabStop = false;
            toolBar.Click += toolBar_Click;
            // 
            // menuHamburger
            // 
            menuHamburger.ImageScalingSize = new Size(24, 24);
            menuHamburger.Items.AddRange(new ToolStripItem[] { changerDeVilleToolStripMenuItem, sinscrireToolStripMenuItem, seConnecterToolStripMenuItem });
            menuHamburger.Name = "menuHamburger";
            menuHamburger.Size = new Size(211, 100);
            // 
            // changerDeVilleToolStripMenuItem
            // 
            changerDeVilleToolStripMenuItem.Name = "changerDeVilleToolStripMenuItem";
            changerDeVilleToolStripMenuItem.Size = new Size(210, 32);
            changerDeVilleToolStripMenuItem.Text = "Changer de ville";
            changerDeVilleToolStripMenuItem.Click += changerDeVilleToolStripMenuItem_Click;
            // 
            // sinscrireToolStripMenuItem
            // 
            sinscrireToolStripMenuItem.Name = "sinscrireToolStripMenuItem";
            sinscrireToolStripMenuItem.Size = new Size(210, 32);
            sinscrireToolStripMenuItem.Text = "S'inscrire";
            sinscrireToolStripMenuItem.Click += sinscrireToolStripMenuItem_Click;
            // 
            // seConnecterToolStripMenuItem
            // 
            seConnecterToolStripMenuItem.Name = "seConnecterToolStripMenuItem";
            seConnecterToolStripMenuItem.Size = new Size(210, 32);
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
            Panel_Inscription.Location = new Point(0, 0);
            Panel_Inscription.Margin = new Padding(4, 5, 4, 5);
            Panel_Inscription.Name = "Panel_Inscription";
            Panel_Inscription.Size = new Size(1791, 1050);
            Panel_Inscription.TabIndex = 38;
            // 
            // Lbl_Uname
            // 
            Lbl_Uname.AutoSize = true;
            Lbl_Uname.Location = new Point(56, 72);
            Lbl_Uname.Margin = new Padding(4, 0, 4, 0);
            Lbl_Uname.Name = "Lbl_Uname";
            Lbl_Uname.Size = new Size(265, 25);
            Lbl_Uname.TabIndex = 5;
            Lbl_Uname.Text = "Saissiez votre nom d'utilisateur :";
            // 
            // Lbl_Conf_Mdp
            // 
            Lbl_Conf_Mdp.AutoSize = true;
            Lbl_Conf_Mdp.Location = new Point(56, 360);
            Lbl_Conf_Mdp.Margin = new Padding(4, 0, 4, 0);
            Lbl_Conf_Mdp.Name = "Lbl_Conf_Mdp";
            Lbl_Conf_Mdp.Size = new Size(319, 25);
            Lbl_Conf_Mdp.TabIndex = 4;
            Lbl_Conf_Mdp.Text = "Veuillez confirmer votre mot de passe :";
            Lbl_Conf_Mdp.Visible = false;
            // 
            // Lbl_Mdp
            // 
            Lbl_Mdp.AutoSize = true;
            Lbl_Mdp.Location = new Point(56, 252);
            Lbl_Mdp.Margin = new Padding(4, 0, 4, 0);
            Lbl_Mdp.Name = "Lbl_Mdp";
            Lbl_Mdp.Size = new Size(248, 25);
            Lbl_Mdp.TabIndex = 3;
            Lbl_Mdp.Text = "Saisissez votre mot de passe :";
            Lbl_Mdp.Visible = false;
            // 
            // textBoxMdpConf
            // 
            textBoxMdpConf.Location = new Point(56, 390);
            textBoxMdpConf.Margin = new Padding(4, 5, 4, 5);
            textBoxMdpConf.Name = "textBoxMdpConf";
            textBoxMdpConf.Size = new Size(754, 31);
            textBoxMdpConf.TabIndex = 2;
            textBoxMdpConf.Visible = false;
            // 
            // textBoxMdp
            // 
            textBoxMdp.Location = new Point(56, 288);
            textBoxMdp.Margin = new Padding(4, 5, 4, 5);
            textBoxMdp.Name = "textBoxMdp";
            textBoxMdp.Size = new Size(754, 31);
            textBoxMdp.TabIndex = 1;
            textBoxMdp.Visible = false;
            // 
            // textBoxUname
            // 
            textBoxUname.Location = new Point(56, 102);
            textBoxUname.Margin = new Padding(4, 5, 4, 5);
            textBoxUname.Name = "textBoxUname";
            textBoxUname.Size = new Size(754, 31);
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
            Panel_Configuration.Location = new Point(0, 0);
            Panel_Configuration.Margin = new Padding(4, 5, 4, 5);
            Panel_Configuration.Name = "Panel_Configuration";
            Panel_Configuration.Size = new Size(1791, 1050);
            Panel_Configuration.TabIndex = 3;
            // 
            // Lbl_VilleFavorite
            // 
            Lbl_VilleFavorite.AutoSize = true;
            Lbl_VilleFavorite.Location = new Point(458, 295);
            Lbl_VilleFavorite.Margin = new Padding(4, 0, 4, 0);
            Lbl_VilleFavorite.Name = "Lbl_VilleFavorite";
            Lbl_VilleFavorite.Size = new Size(401, 25);
            Lbl_VilleFavorite.TabIndex = 3;
            Lbl_VilleFavorite.Text = "Veuillez saisir votre ville favorite afin d'être alerté :";
            Lbl_VilleFavorite.Visible = false;
            // 
            // Lbl_EMail
            // 
            Lbl_EMail.AutoSize = true;
            Lbl_EMail.Location = new Point(458, 72);
            Lbl_EMail.Margin = new Padding(4, 0, 4, 0);
            Lbl_EMail.Name = "Lbl_EMail";
            Lbl_EMail.Size = new Size(265, 25);
            Lbl_EMail.TabIndex = 2;
            Lbl_EMail.Text = "Saisissez votre addresse e-mail :";
            // 
            // textBoxVilleFavorite
            // 
            textBoxVilleFavorite.Location = new Point(458, 325);
            textBoxVilleFavorite.Margin = new Padding(4, 5, 4, 5);
            textBoxVilleFavorite.Name = "textBoxVilleFavorite";
            textBoxVilleFavorite.Size = new Size(814, 31);
            textBoxVilleFavorite.TabIndex = 1;
            textBoxVilleFavorite.Visible = false;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(458, 102);
            textBoxEmail.Margin = new Padding(4, 5, 4, 5);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(814, 31);
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
            Panel_Connection.Location = new Point(0, 0);
            Panel_Connection.Margin = new Padding(4, 5, 4, 5);
            Panel_Connection.Name = "Panel_Connection";
            Panel_Connection.Size = new Size(1791, 1050);
            Panel_Connection.TabIndex = 2;
            // 
            // Lbl_Mdp_Connection
            // 
            Lbl_Mdp_Connection.AutoSize = true;
            Lbl_Mdp_Connection.Location = new Point(169, 292);
            Lbl_Mdp_Connection.Margin = new Padding(4, 0, 4, 0);
            Lbl_Mdp_Connection.Name = "Lbl_Mdp_Connection";
            Lbl_Mdp_Connection.Size = new Size(282, 25);
            Lbl_Mdp_Connection.TabIndex = 3;
            Lbl_Mdp_Connection.Text = "Veuillez saisir votre mot de passe :";
            Lbl_Mdp_Connection.Visible = false;
            // 
            // Lbl_Uname_Connection
            // 
            Lbl_Uname_Connection.AutoSize = true;
            Lbl_Uname_Connection.Location = new Point(170, 68);
            Lbl_Uname_Connection.Margin = new Padding(4, 0, 4, 0);
            Lbl_Uname_Connection.Name = "Lbl_Uname_Connection";
            Lbl_Uname_Connection.Size = new Size(307, 25);
            Lbl_Uname_Connection.TabIndex = 2;
            Lbl_Uname_Connection.Text = "Veuillez saisir votre nom d'utilisateur :";
            // 
            // textBoxMdpConnection
            // 
            textBoxMdpConnection.Location = new Point(170, 322);
            textBoxMdpConnection.Margin = new Padding(4, 5, 4, 5);
            textBoxMdpConnection.Name = "textBoxMdpConnection";
            textBoxMdpConnection.Size = new Size(748, 31);
            textBoxMdpConnection.TabIndex = 1;
            textBoxMdpConnection.Visible = false;
            // 
            // textBoxUconnection
            // 
            textBoxUconnection.Location = new Point(170, 98);
            textBoxUconnection.Margin = new Padding(4, 5, 4, 5);
            textBoxUconnection.Name = "textBoxUconnection";
            textBoxUconnection.Size = new Size(748, 31);
            textBoxUconnection.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1791, 1050);
            Controls.Add(Panel_Header);
            Controls.Add(Panel_Meteo_Ville);
            Controls.Add(Panel_Connection);
            Controls.Add(Panel_Configuration);
            Controls.Add(Panel_Inscription);
            Controls.Add(Panel_Accueil);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            Panel_Accueil.ResumeLayout(false);
            Panel_Accueil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Loupe).EndInit();
            Panel_Meteo_Ville.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconeMeteo_j6).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconeMeteo_j3).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconeMeteo_j5).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconeMeteo_j4).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconeMeteo).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconeMeteo_demain).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconeMeteo_apres_demain_bis).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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

        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private PictureBox iconeMeteo_demain;
        private PictureBox pictureBox1;
        private PictureBox iconeMeteo;
        private PictureBox pictureBox2;
    }
}
