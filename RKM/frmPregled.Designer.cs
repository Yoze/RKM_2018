namespace RKM
{
    partial class frmPregled
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPregled));
            this.dataGridViewPregledPoStatusu = new System.Windows.Forms.DataGridView();
            this.radioRezervacija = new System.Windows.Forms.RadioButton();
            this.radioPoslatSO = new System.Windows.Forms.RadioButton();
            this.radioResen = new System.Windows.Forms.RadioButton();
            this.radioNepopravljivKO = new System.Windows.Forms.RadioButton();
            this.radioNepopravljivZamena = new System.Windows.Forms.RadioButton();
            this.radioPopravljen2 = new System.Windows.Forms.RadioButton();
            this.radioPopravljen1 = new System.Windows.Forms.RadioButton();
            this.radioServis = new System.Windows.Forms.RadioButton();
            this.radioPrimljen = new System.Windows.Forms.RadioButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNoviZapis = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnBrisi = new System.Windows.Forms.Button();
            this.btnSMSpregled = new System.Windows.Forms.Button();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNoFilter = new System.Windows.Forms.Button();
            this.labelNemaPodataka = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblPRODMESTO = new System.Windows.Forms.Label();
            this.labelSQL = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPregledPoStatusu)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewPregledPoStatusu
            // 
            this.dataGridViewPregledPoStatusu.AllowUserToAddRows = false;
            this.dataGridViewPregledPoStatusu.AllowUserToDeleteRows = false;
            this.dataGridViewPregledPoStatusu.AllowUserToResizeRows = false;
            this.dataGridViewPregledPoStatusu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewPregledPoStatusu.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewPregledPoStatusu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewPregledPoStatusu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewPregledPoStatusu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPregledPoStatusu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPregledPoStatusu.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewPregledPoStatusu.EnableHeadersVisualStyles = false;
            this.dataGridViewPregledPoStatusu.Location = new System.Drawing.Point(180, 45);
            this.dataGridViewPregledPoStatusu.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewPregledPoStatusu.MultiSelect = false;
            this.dataGridViewPregledPoStatusu.Name = "dataGridViewPregledPoStatusu";
            this.dataGridViewPregledPoStatusu.ReadOnly = true;
            this.dataGridViewPregledPoStatusu.RowHeadersVisible = false;
            this.dataGridViewPregledPoStatusu.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewPregledPoStatusu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPregledPoStatusu.Size = new System.Drawing.Size(541, 508);
            this.dataGridViewPregledPoStatusu.TabIndex = 0;
            this.dataGridViewPregledPoStatusu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPregledPoStatusu_CellClick);
            this.dataGridViewPregledPoStatusu.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPregledPoStatusu_CellDoubleClick);
            // 
            // radioRezervacija
            // 
            this.radioRezervacija.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioRezervacija.AutoSize = true;
            this.radioRezervacija.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioRezervacija.Location = new System.Drawing.Point(3, 336);
            this.radioRezervacija.Name = "radioRezervacija";
            this.radioRezervacija.Size = new System.Drawing.Size(87, 23);
            this.radioRezervacija.TabIndex = 8;
            this.radioRezervacija.TabStop = true;
            this.radioRezervacija.Text = "REZERVACIJA";
            this.radioRezervacija.UseVisualStyleBackColor = true;
            this.radioRezervacija.CheckedChanged += new System.EventHandler(this.radioRezervacija_CheckedChanged);
            // 
            // radioPoslatSO
            // 
            this.radioPoslatSO.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioPoslatSO.AutoSize = true;
            this.radioPoslatSO.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioPoslatSO.Location = new System.Drawing.Point(3, 162);
            this.radioPoslatSO.Name = "radioPoslatSO";
            this.radioPoslatSO.Size = new System.Drawing.Size(116, 23);
            this.radioPoslatSO.TabIndex = 7;
            this.radioPoslatSO.TabStop = true;
            this.radioPoslatSO.Text = "POSLAT U SOMBOR";
            this.radioPoslatSO.UseVisualStyleBackColor = true;
            this.radioPoslatSO.CheckedChanged += new System.EventHandler(this.radioPoslatSO_CheckedChanged);
            // 
            // radioResen
            // 
            this.radioResen.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioResen.AutoSize = true;
            this.radioResen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioResen.Location = new System.Drawing.Point(3, 307);
            this.radioResen.Name = "radioResen";
            this.radioResen.Size = new System.Drawing.Size(52, 23);
            this.radioResen.TabIndex = 6;
            this.radioResen.TabStop = true;
            this.radioResen.Text = "REŠEN";
            this.radioResen.UseVisualStyleBackColor = true;
            this.radioResen.CheckedChanged += new System.EventHandler(this.radioResen_CheckedChanged);
            // 
            // radioNepopravljivKO
            // 
            this.radioNepopravljivKO.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioNepopravljivKO.AutoSize = true;
            this.radioNepopravljivKO.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioNepopravljivKO.Location = new System.Drawing.Point(3, 278);
            this.radioNepopravljivKO.Name = "radioNepopravljivKO";
            this.radioNepopravljivKO.Size = new System.Drawing.Size(156, 23);
            this.radioNepopravljivKO.TabIndex = 5;
            this.radioNepopravljivKO.TabStop = true;
            this.radioNepopravljivKO.Text = "NEPOPRAVLJIV - ČEKA K.O.";
            this.radioNepopravljivKO.UseVisualStyleBackColor = true;
            this.radioNepopravljivKO.CheckedChanged += new System.EventHandler(this.radioNepopravljivKO_CheckedChanged);
            // 
            // radioNepopravljivZamena
            // 
            this.radioNepopravljivZamena.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioNepopravljivZamena.AutoSize = true;
            this.radioNepopravljivZamena.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioNepopravljivZamena.Location = new System.Drawing.Point(3, 249);
            this.radioNepopravljivZamena.Name = "radioNepopravljivZamena";
            this.radioNepopravljivZamena.Size = new System.Drawing.Size(178, 23);
            this.radioNepopravljivZamena.TabIndex = 4;
            this.radioNepopravljivZamena.TabStop = true;
            this.radioNepopravljivZamena.Text = "NEPOPRAVLJIV - ČEKA ZAMENU";
            this.radioNepopravljivZamena.UseVisualStyleBackColor = true;
            this.radioNepopravljivZamena.CheckedChanged += new System.EventHandler(this.radioNepopravljivZamena_CheckedChanged);
            // 
            // radioPopravljen2
            // 
            this.radioPopravljen2.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioPopravljen2.AutoSize = true;
            this.radioPopravljen2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioPopravljen2.Location = new System.Drawing.Point(3, 220);
            this.radioPopravljen2.Name = "radioPopravljen2";
            this.radioPopravljen2.Size = new System.Drawing.Size(174, 23);
            this.radioPopravljen2.TabIndex = 3;
            this.radioPopravljen2.TabStop = true;
            this.radioPopravljen2.Text = "POPRAVLJEN - UVOZNIK ŠALJE";
            this.radioPopravljen2.UseVisualStyleBackColor = true;
            this.radioPopravljen2.CheckedChanged += new System.EventHandler(this.radioPopravljen2_CheckedChanged);
            // 
            // radioPopravljen1
            // 
            this.radioPopravljen1.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioPopravljen1.AutoSize = true;
            this.radioPopravljen1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioPopravljen1.Location = new System.Drawing.Point(3, 191);
            this.radioPopravljen1.Name = "radioPopravljen1";
            this.radioPopravljen1.Size = new System.Drawing.Size(201, 23);
            this.radioPopravljen1.TabIndex = 2;
            this.radioPopravljen1.TabStop = true;
            this.radioPopravljen1.Text = "POPRAVLJEN - VRAĆEN SA SERVISA";
            this.radioPopravljen1.UseVisualStyleBackColor = true;
            this.radioPopravljen1.CheckedChanged += new System.EventHandler(this.radioPopravljen1_CheckedChanged);
            // 
            // radioServis
            // 
            this.radioServis.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioServis.AutoSize = true;
            this.radioServis.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioServis.Location = new System.Drawing.Point(3, 133);
            this.radioServis.Name = "radioServis";
            this.radioServis.Size = new System.Drawing.Size(115, 23);
            this.radioServis.TabIndex = 1;
            this.radioServis.TabStop = true;
            this.radioServis.Text = "POSLAT NA SERVIS";
            this.radioServis.UseVisualStyleBackColor = true;
            this.radioServis.CheckedChanged += new System.EventHandler(this.radioServis_CheckedChanged);
            // 
            // radioPrimljen
            // 
            this.radioPrimljen.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioPrimljen.AutoSize = true;
            this.radioPrimljen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioPrimljen.Location = new System.Drawing.Point(3, 104);
            this.radioPrimljen.Name = "radioPrimljen";
            this.radioPrimljen.Size = new System.Drawing.Size(149, 23);
            this.radioPrimljen.TabIndex = 0;
            this.radioPrimljen.TabStop = true;
            this.radioPrimljen.Text = "PRIMLJEN U PRODAVNICU";
            this.radioPrimljen.UseVisualStyleBackColor = true;
            this.radioPrimljen.CheckedChanged += new System.EventHandler(this.radioPrimljen_CheckedChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSearch.Location = new System.Drawing.Point(24, 10);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(145, 25);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 215F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewPregledPoStatusu, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel5, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(936, 583);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Snow;
            this.flowLayoutPanel1.Controls.Add(this.btnNoviZapis);
            this.flowLayoutPanel1.Controls.Add(this.btnIzmeni);
            this.flowLayoutPanel1.Controls.Add(this.btnBrisi);
            this.flowLayoutPanel1.Controls.Add(this.btnSMSpregled);
            this.flowLayoutPanel1.Controls.Add(this.btnIzlaz);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 45);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(180, 508);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnNoviZapis
            // 
            this.btnNoviZapis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNoviZapis.FlatAppearance.BorderSize = 0;
            this.btnNoviZapis.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnNoviZapis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnNoviZapis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNoviZapis.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoviZapis.ForeColor = System.Drawing.Color.Indigo;
            this.btnNoviZapis.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNoviZapis.Location = new System.Drawing.Point(0, 0);
            this.btnNoviZapis.Margin = new System.Windows.Forms.Padding(0);
            this.btnNoviZapis.Name = "btnNoviZapis";
            this.btnNoviZapis.Size = new System.Drawing.Size(180, 40);
            this.btnNoviZapis.TabIndex = 2;
            this.btnNoviZapis.Text = "Dodaj";
            this.btnNoviZapis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNoviZapis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNoviZapis.UseVisualStyleBackColor = true;
            this.btnNoviZapis.Click += new System.EventHandler(this.btnNoviZapis_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnIzmeni.FlatAppearance.BorderSize = 0;
            this.btnIzmeni.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnIzmeni.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnIzmeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzmeni.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeni.ForeColor = System.Drawing.Color.Indigo;
            this.btnIzmeni.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIzmeni.Location = new System.Drawing.Point(0, 40);
            this.btnIzmeni.Margin = new System.Windows.Forms.Padding(0);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(180, 40);
            this.btnIzmeni.TabIndex = 5;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIzmeni.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnBrisi
            // 
            this.btnBrisi.FlatAppearance.BorderSize = 0;
            this.btnBrisi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnBrisi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnBrisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrisi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrisi.ForeColor = System.Drawing.Color.Red;
            this.btnBrisi.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBrisi.Location = new System.Drawing.Point(0, 80);
            this.btnBrisi.Margin = new System.Windows.Forms.Padding(0);
            this.btnBrisi.Name = "btnBrisi";
            this.btnBrisi.Size = new System.Drawing.Size(180, 40);
            this.btnBrisi.TabIndex = 12;
            this.btnBrisi.Text = "Obriši";
            this.btnBrisi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrisi.UseVisualStyleBackColor = true;
            this.btnBrisi.Click += new System.EventHandler(this.btnBrisi_Click);
            // 
            // btnSMSpregled
            // 
            this.btnSMSpregled.FlatAppearance.BorderSize = 0;
            this.btnSMSpregled.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btnSMSpregled.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnSMSpregled.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSMSpregled.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSMSpregled.ForeColor = System.Drawing.Color.Indigo;
            this.btnSMSpregled.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSMSpregled.Location = new System.Drawing.Point(0, 120);
            this.btnSMSpregled.Margin = new System.Windows.Forms.Padding(0);
            this.btnSMSpregled.Name = "btnSMSpregled";
            this.btnSMSpregled.Size = new System.Drawing.Size(180, 40);
            this.btnSMSpregled.TabIndex = 13;
            this.btnSMSpregled.Text = "SMS";
            this.btnSMSpregled.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSMSpregled.UseVisualStyleBackColor = true;
            this.btnSMSpregled.Visible = false;
            this.btnSMSpregled.Click += new System.EventHandler(this.btnSMSpregled_Click);
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.FlatAppearance.BorderSize = 0;
            this.btnIzlaz.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnIzlaz.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnIzlaz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzlaz.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzlaz.ForeColor = System.Drawing.Color.Indigo;
            this.btnIzlaz.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIzlaz.Location = new System.Drawing.Point(0, 160);
            this.btnIzlaz.Margin = new System.Windows.Forms.Padding(0);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(180, 40);
            this.btnIzlaz.TabIndex = 11;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.Snow;
            this.flowLayoutPanel3.Controls.Add(this.label2);
            this.flowLayoutPanel3.Controls.Add(this.btnNoFilter);
            this.flowLayoutPanel3.Controls.Add(this.radioPrimljen);
            this.flowLayoutPanel3.Controls.Add(this.radioServis);
            this.flowLayoutPanel3.Controls.Add(this.radioPoslatSO);
            this.flowLayoutPanel3.Controls.Add(this.radioPopravljen1);
            this.flowLayoutPanel3.Controls.Add(this.radioPopravljen2);
            this.flowLayoutPanel3.Controls.Add(this.radioNepopravljivZamena);
            this.flowLayoutPanel3.Controls.Add(this.radioNepopravljivKO);
            this.flowLayoutPanel3.Controls.Add(this.radioResen);
            this.flowLayoutPanel3.Controls.Add(this.radioRezervacija);
            this.flowLayoutPanel3.Controls.Add(this.labelNemaPodataka);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(721, 45);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(215, 508);
            this.flowLayoutPanel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.MaximumSize = new System.Drawing.Size(214, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.label2.Size = new System.Drawing.Size(207, 43);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNoFilter
            // 
            this.btnNoFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNoFilter.FlatAppearance.BorderSize = 0;
            this.btnNoFilter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnNoFilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnNoFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNoFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNoFilter.ForeColor = System.Drawing.Color.Indigo;
            this.btnNoFilter.Image = global::RKM.Properties.Resources.empty_filter_26;
            this.btnNoFilter.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNoFilter.Location = new System.Drawing.Point(3, 48);
            this.btnNoFilter.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.btnNoFilter.Name = "btnNoFilter";
            this.btnNoFilter.Size = new System.Drawing.Size(201, 50);
            this.btnNoFilter.TabIndex = 9;
            this.btnNoFilter.Text = "Poništi filter";
            this.btnNoFilter.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNoFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNoFilter.UseVisualStyleBackColor = true;
            this.btnNoFilter.Click += new System.EventHandler(this.btnNoFilter_Click);
            // 
            // labelNemaPodataka
            // 
            this.labelNemaPodataka.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNemaPodataka.AutoSize = true;
            this.labelNemaPodataka.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNemaPodataka.ForeColor = System.Drawing.Color.Red;
            this.labelNemaPodataka.Location = new System.Drawing.Point(3, 372);
            this.labelNemaPodataka.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.labelNemaPodataka.Name = "labelNemaPodataka";
            this.labelNemaPodataka.Size = new System.Drawing.Size(201, 18);
            this.labelNemaPodataka.TabIndex = 5;
            this.labelNemaPodataka.Text = "Nema traženih podataka";
            this.labelNemaPodataka.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelNemaPodataka.Visible = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.flowLayoutPanel2.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel2.Controls.Add(this.txtSearch);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(721, 0);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(215, 45);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::RKM.Properties.Resources.search_26;
            this.pictureBox1.Location = new System.Drawing.Point(175, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel4, 2);
            this.flowLayoutPanel4.Controls.Add(this.label1);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(721, 45);
            this.flowLayoutPanel4.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "REKLAMACIJE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel5, 3);
            this.flowLayoutPanel5.Controls.Add(this.lblPRODMESTO);
            this.flowLayoutPanel5.Controls.Add(this.labelSQL);
            this.flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(0, 553);
            this.flowLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(936, 30);
            this.flowLayoutPanel5.TabIndex = 8;
            // 
            // lblPRODMESTO
            // 
            this.lblPRODMESTO.AutoSize = true;
            this.lblPRODMESTO.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblPRODMESTO.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPRODMESTO.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lblPRODMESTO.Location = new System.Drawing.Point(3, 0);
            this.lblPRODMESTO.Name = "lblPRODMESTO";
            this.lblPRODMESTO.Padding = new System.Windows.Forms.Padding(3);
            this.lblPRODMESTO.Size = new System.Drawing.Size(56, 25);
            this.lblPRODMESTO.TabIndex = 6;
            this.lblPRODMESTO.Text = "label3";
            this.lblPRODMESTO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSQL
            // 
            this.labelSQL.AutoSize = true;
            this.labelSQL.Location = new System.Drawing.Point(65, 0);
            this.labelSQL.Name = "labelSQL";
            this.labelSQL.Size = new System.Drawing.Size(35, 13);
            this.labelSQL.TabIndex = 6;
            this.labelSQL.Text = "label3";
            this.labelSQL.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmPregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(936, 583);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPregled";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ELBS RKM 2015";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPregled_FormClosed);
            this.Load += new System.EventHandler(this.frmPregled_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPregledPoStatusu)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPregledPoStatusu;
        private System.Windows.Forms.RadioButton radioPoslatSO;
        private System.Windows.Forms.RadioButton radioResen;
        private System.Windows.Forms.RadioButton radioNepopravljivKO;
        private System.Windows.Forms.RadioButton radioNepopravljivZamena;
        private System.Windows.Forms.RadioButton radioPopravljen2;
        private System.Windows.Forms.RadioButton radioPopravljen1;
        private System.Windows.Forms.RadioButton radioServis;
        private System.Windows.Forms.RadioButton radioPrimljen;
        private System.Windows.Forms.RadioButton radioRezervacija;
        private System.Windows.Forms.Button btnNoviZapis;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button btnNoFilter;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrisi;
        private System.Windows.Forms.Label labelNemaPodataka;
        private System.Windows.Forms.Button btnSMSpregled;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblPRODMESTO;
        private System.Windows.Forms.Label labelSQL;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
    }
}