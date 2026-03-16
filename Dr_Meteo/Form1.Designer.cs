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
            iconeMeteo_demain = new PictureBox();
            Lbl_Demain = new Label();
            lbl_Apres_demain = new Label();
            Lbl_diff_sunset_apres_demain = new Label();
            Lbl_MeteoDesc_apres_demain = new Label();
            Lbl_diff_sunset_demain = new Label();
            Lbl_diff_temp_ensoleilement_apres_demain = new Label();
            Lbl_temp_max_apres_demain = new Label();
            Lbl_diff_temp_ensoleilement_demain = new Label();
            Lbl_temp_min_demain = new Label();
            Lbl_temp_min_apres_demain = new Label();
            Lbl_Uv_demain = new Label();
            Lbl_Uv_apres_demain = new Label();
            Lbl_temp_max_demain = new Label();
            Lbl_MeteoDesc_demain = new Label();
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
            Panel_Header = new Panel();
            toolBar = new PictureBox();
            menuHamburger = new ContextMenuStrip(components);
            changerDeVilleToolStripMenuItem = new ToolStripMenuItem();
            sinscrireToolStripMenuItem = new ToolStripMenuItem();
            seConnecterToolStripMenuItem = new ToolStripMenuItem();
            Panel_Inscription = new Panel();
            Lbl_Conf_Mdp = new Label();
            Lbl_Mdp = new Label();
            Lbl_Uname = new Label();
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
            Lbl_UConnection = new Label();
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
            Panel_Accueil.Location = new Point(0, 41);
            Panel_Accueil.Margin = new Padding(2, 4, 2, 4);
            Panel_Accueil.Name = "Panel_Accueil";
            Panel_Accueil.Size = new Size(1791, 1009);
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
            Barre_Recherche.Size = new Size(904, 31);
            Barre_Recherche.TabIndex = 0;
            // 
            // Loupe
            // 
            Loupe.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Loupe.BackgroundImageLayout = ImageLayout.Stretch;
            Loupe.Image = (Image)resources.GetObject("Loupe.Image");
            Loupe.Location = new Point(1099, 148);
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
            Panel_Meteo_Ville.Controls.Add(tableLayoutPanel1);
            Panel_Meteo_Ville.Controls.Add(iconeMeteo_apres_demain_bis);
            Panel_Meteo_Ville.Controls.Add(iconeMeteo_demain);
            Panel_Meteo_Ville.Dock = DockStyle.Fill;
            Panel_Meteo_Ville.Location = new Point(0, 41);
            Panel_Meteo_Ville.Margin = new Padding(4, 5, 4, 5);
            Panel_Meteo_Ville.Name = "Panel_Meteo_Ville";
            Panel_Meteo_Ville.Size = new Size(1791, 1009);
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
            tableLayoutPanel1.Location = new Point(69, 681);
            tableLayoutPanel1.Margin = new Padding(4, 4, 4, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(1431, 274);
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
            iconeMeteo_j6.Location = new Point(1353, 4);
            iconeMeteo_j6.Margin = new Padding(4, 4, 4, 4);
            iconeMeteo_j6.Name = "iconeMeteo_j6";
            iconeMeteo_j6.Size = new Size(54, 66);
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
            Lbl_max_j6.Size = new Size(270, 124);
            Lbl_max_j6.TabIndex = 35;
            Lbl_max_j6.Text = "Lbl_max_j6";
            // 
            // Lbl_max_j3
            // 
            Lbl_max_j3.Dock = DockStyle.Fill;
            Lbl_max_j3.Location = new Point(4, 160);
            Lbl_max_j3.Margin = new Padding(4, 0, 4, 0);
            Lbl_max_j3.Name = "Lbl_max_j3";
            Lbl_max_j3.Size = new Size(270, 124);
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
            iconeMeteo_j3.Location = new Point(282, 4);
            iconeMeteo_j3.Margin = new Padding(4, 4, 4, 4);
            iconeMeteo_j3.Name = "iconeMeteo_j3";
            iconeMeteo_j3.Size = new Size(54, 64);
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
            iconeMeteo_j5.Location = new Point(996, 4);
            iconeMeteo_j5.Margin = new Padding(4, 4, 4, 4);
            iconeMeteo_j5.Name = "iconeMeteo_j5";
            iconeMeteo_j5.Size = new Size(54, 66);
            iconeMeteo_j5.TabIndex = 30;
            iconeMeteo_j5.TabStop = false;
            // 
            // Lbl_max_j4
            // 
            Lbl_max_j4.Dock = DockStyle.Fill;
            Lbl_max_j4.Location = new Point(361, 160);
            Lbl_max_j4.Margin = new Padding(4, 0, 4, 0);
            Lbl_max_j4.Name = "Lbl_max_j4";
            Lbl_max_j4.Size = new Size(270, 124);
            Lbl_max_j4.TabIndex = 25;
            Lbl_max_j4.Text = "Lbl_max_j4";
            // 
            // Lbl_max_j5
            // 
            Lbl_max_j5.Dock = DockStyle.Fill;
            Lbl_max_j5.Location = new Point(718, 160);
            Lbl_max_j5.Margin = new Padding(4, 0, 4, 0);
            Lbl_max_j5.Name = "Lbl_max_j5";
            Lbl_max_j5.Size = new Size(270, 124);
            Lbl_max_j5.TabIndex = 29;
            Lbl_max_j5.Text = "Lbl_max_j5";
            // 
            // iconeMeteo_j4
            // 
            iconeMeteo_j4.Location = new Point(639, 4);
            iconeMeteo_j4.Margin = new Padding(4, 4, 4, 4);
            iconeMeteo_j4.Name = "iconeMeteo_j4";
            iconeMeteo_j4.Size = new Size(54, 66);
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
            // iconeMeteo_apres_demain_bis
            // 
            iconeMeteo_apres_demain_bis.Location = new Point(1264, 120);
            iconeMeteo_apres_demain_bis.Margin = new Padding(4, 5, 4, 5);
            iconeMeteo_apres_demain_bis.Name = "iconeMeteo_apres_demain_bis";
            iconeMeteo_apres_demain_bis.Size = new Size(156, 76);
            iconeMeteo_apres_demain_bis.TabIndex = 32;
            iconeMeteo_apres_demain_bis.TabStop = false;
            // 
            // iconeMeteo_demain
            // 
            iconeMeteo_demain.Location = new Point(484, 141);
            iconeMeteo_demain.Margin = new Padding(4, 5, 4, 5);
            iconeMeteo_demain.Name = "iconeMeteo_demain";
            iconeMeteo_demain.Size = new Size(179, 104);
            iconeMeteo_demain.TabIndex = 10;
            iconeMeteo_demain.TabStop = false;
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
            // lbl_Apres_demain
            // 
            lbl_Apres_demain.Location = new Point(647, 60);
            lbl_Apres_demain.Name = "lbl_Apres_demain";
            lbl_Apres_demain.Size = new Size(170, 23);
            lbl_Apres_demain.TabIndex = 0;
            lbl_Apres_demain.Text = "lbl_Apres_demain";
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
            // Lbl_MeteoDesc_apres_demain
            // 
            Lbl_MeteoDesc_apres_demain.Dock = DockStyle.Fill;
            Lbl_MeteoDesc_apres_demain.Location = new Point(647, 168);
            Lbl_MeteoDesc_apres_demain.Name = "Lbl_MeteoDesc_apres_demain";
            Lbl_MeteoDesc_apres_demain.Size = new Size(218, 23);
            Lbl_MeteoDesc_apres_demain.TabIndex = 0;
            Lbl_MeteoDesc_apres_demain.Text = "Lbl_MeteoDesc_apres_demain";
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
            // Lbl_temp_max_apres_demain
            // 
            Lbl_temp_max_apres_demain.AutoSize = true;
            Lbl_temp_max_apres_demain.Dock = DockStyle.Fill;
            Lbl_temp_max_apres_demain.Location = new Point(652, 202);
            Lbl_temp_max_apres_demain.Name = "Lbl_temp_max_apres_demain";
            Lbl_temp_max_apres_demain.Size = new Size(202, 20);
            Lbl_temp_max_apres_demain.TabIndex = 3;
            Lbl_temp_max_apres_demain.Text = "Lbl_temp_max_apres_demain";
            // 
            // Lbl_diff_temp_ensoleilement_demain
            // 
            Lbl_diff_temp_ensoleilement_demain.AutoSize = true;
            Lbl_diff_temp_ensoleilement_demain.Location = new Point(349, 359);
            Lbl_diff_temp_ensoleilement_demain.Name = "Lbl_diff_temp_ensoleilement_demain";
            Lbl_diff_temp_ensoleilement_demain.Size = new Size(254, 20);
            Lbl_diff_temp_ensoleilement_demain.TabIndex = 15;
            Lbl_diff_temp_ensoleilement_demain.Text = "Lbl_diff_temp_ensoleilement_demain";
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
            // Lbl_temp_min_apres_demain
            // 
            Lbl_temp_min_apres_demain.AutoSize = true;
            Lbl_temp_min_apres_demain.Location = new Point(652, 236);
            Lbl_temp_min_apres_demain.Name = "Lbl_temp_min_apres_demain";
            Lbl_temp_min_apres_demain.Size = new Size(199, 20);
            Lbl_temp_min_apres_demain.TabIndex = 4;
            Lbl_temp_min_apres_demain.Text = "Lbl_temp_min_apres_demain";
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
            // Lbl_Uv_apres_demain
            // 
            Lbl_Uv_apres_demain.Location = new Point(647, 318);
            Lbl_Uv_apres_demain.Name = "Lbl_Uv_apres_demain";
            Lbl_Uv_apres_demain.Size = new Size(158, 23);
            Lbl_Uv_apres_demain.TabIndex = 0;
            Lbl_Uv_apres_demain.Text = "Lbl_Uv_apres_demain";
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
            // Lbl_Temperature
            // 
            Lbl_Temperature.AutoEllipsis = true;
            Lbl_Temperature.AutoSize = true;
            Lbl_Temperature.Location = new Point(125, 102);
            Lbl_Temperature.Name = "Lbl_Temperature";
            Lbl_Temperature.Size = new Size(95, 15);
            Lbl_Temperature.TabIndex = 1;
            Lbl_Temperature.Text = "Lbl_Temperature";
            // 
            // Lbl_coucher_soleil
            // 
            Lbl_coucher_soleil.AutoSize = true;
            Lbl_coucher_soleil.BackColor = SystemColors.Control;
            Lbl_coucher_soleil.Location = new Point(3, 407);
            Lbl_coucher_soleil.Name = "Lbl_coucher_soleil";
            Lbl_coucher_soleil.Size = new Size(128, 20);
            Lbl_coucher_soleil.TabIndex = 14;
            Lbl_coucher_soleil.Text = "Lbl_coucher_soleil";
            // 
            // Lbl_lever_soleil
            // 
            Lbl_lever_soleil.AutoSize = true;
            Lbl_lever_soleil.Location = new Point(3, 370);
            Lbl_lever_soleil.Name = "Lbl_lever_soleil";
            Lbl_lever_soleil.Size = new Size(108, 20);
            Lbl_lever_soleil.TabIndex = 13;
            Lbl_lever_soleil.Text = "Lbl_lever_soleil";
            // 
            // Lbl_humidite
            // 
            Lbl_humidite.Location = new Point(125, 376);
            Lbl_humidite.Name = "Lbl_humidite";
            Lbl_humidite.Size = new Size(100, 23);
            Lbl_humidite.TabIndex = 0;
            Lbl_humidite.Text = "Lbl_humidite";
            // 
            // Lbl_Uv
            // 
            Lbl_Uv.Location = new Point(125, 318);
            Lbl_Uv.Name = "Lbl_Uv";
            Lbl_Uv.Size = new Size(100, 23);
            Lbl_Uv.TabIndex = 0;
            Lbl_Uv.Text = "Lbl_Uv";
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
            // 
            // Lbl_MeteoDesc
            // 
            Lbl_MeteoDesc.AutoSize = true;
            Lbl_MeteoDesc.Location = new Point(3, 185);
            Lbl_MeteoDesc.Name = "Lbl_MeteoDesc";
            Lbl_MeteoDesc.Size = new Size(110, 20);
            Lbl_MeteoDesc.TabIndex = 0;
            Lbl_MeteoDesc.Text = "Lbl_MeteoDesc";
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
            // Lbl_temp_min
            // 
            Lbl_temp_min.AutoSize = true;
            Lbl_temp_min.Location = new Point(120, 87);
            Lbl_temp_min.Name = "Lbl_temp_min";
            Lbl_temp_min.Size = new Size(101, 20);
            Lbl_temp_min.TabIndex = 12;
            Lbl_temp_min.Text = "Lbl_temp_min";
            // 
            // Aujourd_hui
            // 
            Aujourd_hui.Location = new Point(120, 60);
            Aujourd_hui.Name = "Aujourd_hui";
            Aujourd_hui.Size = new Size(100, 23);
            Aujourd_hui.TabIndex = 0;
            Aujourd_hui.Text = "Aujourd_hui";
            // 
            // Panel_Header
            // 
            Panel_Header.BackColor = Color.PeachPuff;
            Panel_Header.Controls.Add(toolBar);
            Panel_Header.Dock = DockStyle.Top;
            Panel_Header.Location = new Point(0, 0);
            Panel_Header.Margin = new Padding(4, 5, 4, 5);
            Panel_Header.Name = "Panel_Header";
            Panel_Header.Size = new Size(1791, 41);
            Panel_Header.TabIndex = 38;
            // 
            // toolBar
            // 
            toolBar.BackgroundImage = Properties.Resources.menu_hamburger;
            toolBar.ContextMenuStrip = menuHamburger;
            toolBar.Location = new Point(0, 0);
            toolBar.Margin = new Padding(4, 5, 4, 5);
            toolBar.Name = "toolBar";
            toolBar.Size = new Size(39, 41);
            toolBar.TabIndex = 0;
            toolBar.TabStop = false;
            toolBar.Click += toolBar_Click;
            // 
            // menuHamburger
            // 
            menuHamburger.ImageScalingSize = new Size(20, 20);
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
            Panel_Inscription.Controls.Add(Lbl_Conf_Mdp);
            Panel_Inscription.Controls.Add(Lbl_Mdp);
            Panel_Inscription.Controls.Add(Lbl_Uname);
            Panel_Inscription.Controls.Add(textBoxMdpConf);
            Panel_Inscription.Controls.Add(textBoxMdp);
            Panel_Inscription.Controls.Add(textBoxUname);
            Panel_Inscription.Dock = DockStyle.Fill;
            Panel_Inscription.Location = new Point(0, 41);
            Panel_Inscription.Margin = new Padding(4, 5, 4, 5);
            Panel_Inscription.Name = "Panel_Inscription";
            Panel_Inscription.Size = new Size(1791, 1009);
            Panel_Inscription.TabIndex = 38;
            // 
            // Lbl_Conf_Mdp
            // 
            Lbl_Conf_Mdp.AutoSize = true;
            Lbl_Conf_Mdp.Location = new Point(88, 414);
            Lbl_Conf_Mdp.Margin = new Padding(4, 0, 4, 0);
            Lbl_Conf_Mdp.Name = "Lbl_Conf_Mdp";
            Lbl_Conf_Mdp.Size = new Size(259, 25);
            Lbl_Conf_Mdp.TabIndex = 5;
            Lbl_Conf_Mdp.Text = "Confirmer votre mot de passe :";
            Lbl_Conf_Mdp.Visible = false;
            // 
            // Lbl_Mdp
            // 
            Lbl_Mdp.AutoSize = true;
            Lbl_Mdp.Location = new Point(88, 285);
            Lbl_Mdp.Margin = new Padding(4, 0, 4, 0);
            Lbl_Mdp.Name = "Lbl_Mdp";
            Lbl_Mdp.Size = new Size(248, 25);
            Lbl_Mdp.TabIndex = 4;
            Lbl_Mdp.Text = "Saisissez votre mot de passe :";
            Lbl_Mdp.Visible = false;
            // 
            // Lbl_Uname
            // 
            Lbl_Uname.AutoSize = true;
            Lbl_Uname.Location = new Point(88, 89);
            Lbl_Uname.Margin = new Padding(4, 0, 4, 0);
            Lbl_Uname.Name = "Lbl_Uname";
            Lbl_Uname.Size = new Size(451, 25);
            Lbl_Uname.TabIndex = 3;
            Lbl_Uname.Text = "Saissiez le nom d'utilisateur que vous souhaitez utiliser :";
            // 
            // textBoxMdpConf
            // 
            textBoxMdpConf.Location = new Point(88, 444);
            textBoxMdpConf.Margin = new Padding(4, 5, 4, 5);
            textBoxMdpConf.Name = "textBoxMdpConf";
            textBoxMdpConf.Size = new Size(840, 31);
            textBoxMdpConf.TabIndex = 2;
            textBoxMdpConf.Visible = false;
            // 
            // textBoxMdp
            // 
            textBoxMdp.Location = new Point(88, 315);
            textBoxMdp.Margin = new Padding(4, 5, 4, 5);
            textBoxMdp.Name = "textBoxMdp";
            textBoxMdp.Size = new Size(840, 31);
            textBoxMdp.TabIndex = 1;
            textBoxMdp.Visible = false;
            // 
            // textBoxUname
            // 
            textBoxUname.Location = new Point(88, 119);
            textBoxUname.Margin = new Padding(4, 5, 4, 5);
            textBoxUname.Name = "textBoxUname";
            textBoxUname.Size = new Size(840, 31);
            textBoxUname.TabIndex = 0;
            // 
            // Panel_Configuration
            // 
            Panel_Configuration.Controls.Add(Lbl_VilleFavorite);
            Panel_Configuration.Controls.Add(Lbl_EMail);
            Panel_Configuration.Controls.Add(textBoxVilleFavorite);
            Panel_Configuration.Controls.Add(textBoxEmail);
            Panel_Configuration.Dock = DockStyle.Fill;
            Panel_Configuration.Location = new Point(0, 41);
            Panel_Configuration.Margin = new Padding(4, 5, 4, 5);
            Panel_Configuration.Name = "Panel_Configuration";
            Panel_Configuration.Size = new Size(1791, 1009);
            Panel_Configuration.TabIndex = 6;
            // 
            // Lbl_VilleFavorite
            // 
            Lbl_VilleFavorite.AutoSize = true;
            Lbl_VilleFavorite.Location = new Point(448, 236);
            Lbl_VilleFavorite.Margin = new Padding(4, 0, 4, 0);
            Lbl_VilleFavorite.Name = "Lbl_VilleFavorite";
            Lbl_VilleFavorite.Size = new Size(673, 25);
            Lbl_VilleFavorite.TabIndex = 3;
            Lbl_VilleFavorite.Text = "Veuillez saisir la ville pour laquelle vous souhaitez être informer par mail des alertes :";
            Lbl_VilleFavorite.Visible = false;
            // 
            // Lbl_EMail
            // 
            Lbl_EMail.AutoSize = true;
            Lbl_EMail.Location = new Point(448, 86);
            Lbl_EMail.Margin = new Padding(4, 0, 4, 0);
            Lbl_EMail.Name = "Lbl_EMail";
            Lbl_EMail.Size = new Size(254, 25);
            Lbl_EMail.TabIndex = 2;
            Lbl_EMail.Text = "Saisissez votre adresse e-mail :";
            // 
            // textBoxVilleFavorite
            // 
            textBoxVilleFavorite.Location = new Point(448, 266);
            textBoxVilleFavorite.Margin = new Padding(4, 5, 4, 5);
            textBoxVilleFavorite.Name = "textBoxVilleFavorite";
            textBoxVilleFavorite.Size = new Size(638, 31);
            textBoxVilleFavorite.TabIndex = 1;
            textBoxVilleFavorite.Visible = false;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(448, 116);
            textBoxEmail.Margin = new Padding(4, 5, 4, 5);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(638, 31);
            textBoxEmail.TabIndex = 0;
            // 
            // Panel_Connection
            // 
            Panel_Connection.Controls.Add(Lbl_Mdp_Connection);
            Panel_Connection.Controls.Add(Lbl_UConnection);
            Panel_Connection.Controls.Add(textBoxMdpConnection);
            Panel_Connection.Controls.Add(textBoxUconnection);
            Panel_Connection.Dock = DockStyle.Fill;
            Panel_Connection.Location = new Point(0, 41);
            Panel_Connection.Margin = new Padding(4, 5, 4, 5);
            Panel_Connection.Name = "Panel_Connection";
            Panel_Connection.Size = new Size(1791, 1009);
            Panel_Connection.TabIndex = 4;
            // 
            // Lbl_Mdp_Connection
            // 
            Lbl_Mdp_Connection.AutoSize = true;
            Lbl_Mdp_Connection.Location = new Point(156, 285);
            Lbl_Mdp_Connection.Margin = new Padding(4, 0, 4, 0);
            Lbl_Mdp_Connection.Name = "Lbl_Mdp_Connection";
            Lbl_Mdp_Connection.Size = new Size(248, 25);
            Lbl_Mdp_Connection.TabIndex = 3;
            Lbl_Mdp_Connection.Text = "Saisissez votre mot de passe :";
            Lbl_Mdp_Connection.Visible = false;
            // 
            // Lbl_UConnection
            // 
            Lbl_UConnection.AutoSize = true;
            Lbl_UConnection.Location = new Point(154, 84);
            Lbl_UConnection.Margin = new Padding(4, 0, 4, 0);
            Lbl_UConnection.Name = "Lbl_UConnection";
            Lbl_UConnection.Size = new Size(273, 25);
            Lbl_UConnection.TabIndex = 2;
            Lbl_UConnection.Text = "Saisissez votre nom d'utilisateur :";
            // 
            // textBoxMdpConnection
            // 
            textBoxMdpConnection.Location = new Point(154, 315);
            textBoxMdpConnection.Margin = new Padding(4, 5, 4, 5);
            textBoxMdpConnection.Name = "textBoxMdpConnection";
            textBoxMdpConnection.Size = new Size(674, 31);
            textBoxMdpConnection.TabIndex = 1;
            textBoxMdpConnection.Visible = false;
            // 
            // textBoxUconnection
            // 
            textBoxUconnection.Location = new Point(154, 114);
            textBoxUconnection.Margin = new Padding(4, 5, 4, 5);
            textBoxUconnection.Name = "textBoxUconnection";
            textBoxUconnection.Size = new Size(674, 31);
            textBoxUconnection.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1791, 1050);
            Controls.Add(Panel_Accueil);
            Controls.Add(Panel_Meteo_Ville);
            Controls.Add(Panel_Inscription);
            Controls.Add(Panel_Configuration);
            Controls.Add(Panel_Connection);
            Controls.Add(Panel_Header);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 4, 2, 4);
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
        private PictureBox toolBar;
        private ContextMenuStrip menuHamburger;
        private ToolStripMenuItem changerDeVilleToolStripMenuItem;
        private ToolStripMenuItem sinscrireToolStripMenuItem;
        private ToolStripMenuItem seConnecterToolStripMenuItem;
        private Panel Panel_Inscription;
        private Label Lbl_Uname;
        private TextBox textBoxMdpConf;
        private TextBox textBoxMdp;
        private TextBox textBoxUname;
        private Label Lbl_Conf_Mdp;
        private Label Lbl_Mdp;
        private Panel Panel_Configuration;
        private Label Lbl_VilleFavorite;
        private Label Lbl_EMail;
        private TextBox textBoxVilleFavorite;
        private TextBox textBoxEmail;
        private Panel Panel_Connection;
        private Label Lbl_UConnection;
        private TextBox textBoxMdpConnection;
        private TextBox textBoxUconnection;
        private Label Lbl_Mdp_Connection;
    }
}
