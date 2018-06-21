namespace RKM
{
    partial class frm_SendSMS
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnADMSEND = new System.Windows.Forms.Button();
            this.btnSEND = new System.Windows.Forms.Button();
            this.btnADMDELETE = new System.Windows.Forms.Button();
            this.btnIZLAZ = new System.Windows.Forms.Button();
            this.gboConnectionStatus = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.lblConnectionStatus = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.cboPortName = new System.Windows.Forms.ComboBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.dgSMSzahtevi = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkSablon3 = new System.Windows.Forms.LinkLabel();
            this.linkSablon2 = new System.Windows.Forms.LinkLabel();
            this.linkSablon1 = new System.Windows.Forms.LinkLabel();
            this.linkDETALJI = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDETALJI = new System.Windows.Forms.RichTextBox();
            this.txtSMS = new System.Windows.Forms.TextBox();
            this.lblRemChars = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.gboConnectionStatus.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSMSzahtevi)).BeginInit();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.statusStrip1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(772, 477);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel1, 2);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1, 1);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(770, 30);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pošalji SMS kupcu";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanel2.Controls.Add(this.btnADMSEND);
            this.flowLayoutPanel2.Controls.Add(this.btnSEND);
            this.flowLayoutPanel2.Controls.Add(this.btnADMDELETE);
            this.flowLayoutPanel2.Controls.Add(this.btnIZLAZ);
            this.flowLayoutPanel2.Controls.Add(this.gboConnectionStatus);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(1, 32);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(180, 413);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // btnADMSEND
            // 
            this.btnADMSEND.FlatAppearance.BorderSize = 0;
            this.btnADMSEND.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnADMSEND.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnADMSEND.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnADMSEND.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADMSEND.Location = new System.Drawing.Point(0, 0);
            this.btnADMSEND.Margin = new System.Windows.Forms.Padding(0);
            this.btnADMSEND.Name = "btnADMSEND";
            this.btnADMSEND.Size = new System.Drawing.Size(180, 40);
            this.btnADMSEND.TabIndex = 1;
            this.btnADMSEND.Text = "OK Pošalji";
            this.btnADMSEND.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnADMSEND.UseVisualStyleBackColor = true;
            this.btnADMSEND.Visible = false;
            this.btnADMSEND.Click += new System.EventHandler(this.btnADMSEND_Click);
            // 
            // btnSEND
            // 
            this.btnSEND.FlatAppearance.BorderSize = 0;
            this.btnSEND.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnSEND.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnSEND.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSEND.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSEND.Location = new System.Drawing.Point(0, 40);
            this.btnSEND.Margin = new System.Windows.Forms.Padding(0);
            this.btnSEND.Name = "btnSEND";
            this.btnSEND.Size = new System.Drawing.Size(180, 40);
            this.btnSEND.TabIndex = 0;
            this.btnSEND.Text = "Pošalji";
            this.btnSEND.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSEND.UseVisualStyleBackColor = true;
            this.btnSEND.Click += new System.EventHandler(this.btnSEND_Click);
            // 
            // btnADMDELETE
            // 
            this.btnADMDELETE.FlatAppearance.BorderSize = 0;
            this.btnADMDELETE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato;
            this.btnADMDELETE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.btnADMDELETE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnADMDELETE.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADMDELETE.ForeColor = System.Drawing.Color.Red;
            this.btnADMDELETE.Location = new System.Drawing.Point(0, 80);
            this.btnADMDELETE.Margin = new System.Windows.Forms.Padding(0);
            this.btnADMDELETE.Name = "btnADMDELETE";
            this.btnADMDELETE.Size = new System.Drawing.Size(180, 40);
            this.btnADMDELETE.TabIndex = 2;
            this.btnADMDELETE.Text = "Obriši";
            this.btnADMDELETE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnADMDELETE.UseVisualStyleBackColor = true;
            this.btnADMDELETE.Visible = false;
            this.btnADMDELETE.Click += new System.EventHandler(this.btnADMDELETE_Click);
            // 
            // btnIZLAZ
            // 
            this.btnIZLAZ.FlatAppearance.BorderSize = 0;
            this.btnIZLAZ.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnIZLAZ.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnIZLAZ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIZLAZ.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIZLAZ.Location = new System.Drawing.Point(0, 120);
            this.btnIZLAZ.Margin = new System.Windows.Forms.Padding(0);
            this.btnIZLAZ.Name = "btnIZLAZ";
            this.btnIZLAZ.Size = new System.Drawing.Size(180, 40);
            this.btnIZLAZ.TabIndex = 3;
            this.btnIZLAZ.Text = "Izlaz";
            this.btnIZLAZ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIZLAZ.UseVisualStyleBackColor = true;
            this.btnIZLAZ.Click += new System.EventHandler(this.btnIZLAZ_Click);
            // 
            // gboConnectionStatus
            // 
            this.gboConnectionStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gboConnectionStatus.BackColor = System.Drawing.Color.Transparent;
            this.gboConnectionStatus.Controls.Add(this.label2);
            this.gboConnectionStatus.Controls.Add(this.label23);
            this.gboConnectionStatus.Controls.Add(this.lblConnectionStatus);
            this.gboConnectionStatus.Controls.Add(this.button1);
            this.gboConnectionStatus.Controls.Add(this.btnOK);
            this.gboConnectionStatus.Controls.Add(this.cboPortName);
            this.gboConnectionStatus.Controls.Add(this.btnDisconnect);
            this.flowLayoutPanel2.SetFlowBreak(this.gboConnectionStatus, true);
            this.gboConnectionStatus.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboConnectionStatus.ForeColor = System.Drawing.Color.DodgerBlue;
            this.gboConnectionStatus.Location = new System.Drawing.Point(10, 180);
            this.gboConnectionStatus.Margin = new System.Windows.Forms.Padding(10, 20, 3, 3);
            this.gboConnectionStatus.Name = "gboConnectionStatus";
            this.gboConnectionStatus.Size = new System.Drawing.Size(156, 150);
            this.gboConnectionStatus.TabIndex = 42;
            this.gboConnectionStatus.TabStop = false;
            this.gboConnectionStatus.Text = "Veza sa GPRS modemom";
            this.gboConnectionStatus.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Port";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(8, 115);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(45, 13);
            this.label23.TabIndex = 37;
            this.label23.Text = "Status :";
            // 
            // lblConnectionStatus
            // 
            this.lblConnectionStatus.AutoSize = true;
            this.lblConnectionStatus.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnectionStatus.ForeColor = System.Drawing.Color.Red;
            this.lblConnectionStatus.Location = new System.Drawing.Point(8, 129);
            this.lblConnectionStatus.Name = "lblConnectionStatus";
            this.lblConnectionStatus.Size = new System.Drawing.Size(80, 13);
            this.lblConnectionStatus.TabIndex = 36;
            this.lblConnectionStatus.Text = "NIJE POVEZAN";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(259, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 4;
            this.button1.Text = "Disconnect";
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Gainsboro;
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(11, 72);
            this.btnOK.Margin = new System.Windows.Forms.Padding(5, 10, 3, 0);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(61, 30);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "Poveži";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // cboPortName
            // 
            this.cboPortName.FormattingEnabled = true;
            this.cboPortName.Location = new System.Drawing.Point(11, 41);
            this.cboPortName.Margin = new System.Windows.Forms.Padding(20, 40, 3, 0);
            this.cboPortName.Name = "cboPortName";
            this.cboPortName.Size = new System.Drawing.Size(133, 21);
            this.cboPortName.TabIndex = 4;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.FlatAppearance.BorderSize = 0;
            this.btnDisconnect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnDisconnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisconnect.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisconnect.Location = new System.Drawing.Point(78, 72);
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(66, 30);
            this.btnDisconnect.TabIndex = 6;
            this.btnDisconnect.Text = "Prekini";
            this.btnDisconnect.UseVisualStyleBackColor = false;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.Snow;
            this.flowLayoutPanel3.Controls.Add(this.dgSMSzahtevi);
            this.flowLayoutPanel3.Controls.Add(this.panel1);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(182, 32);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(589, 413);
            this.flowLayoutPanel3.TabIndex = 2;
            // 
            // dgSMSzahtevi
            // 
            this.dgSMSzahtevi.AllowUserToAddRows = false;
            this.dgSMSzahtevi.AllowUserToDeleteRows = false;
            this.dgSMSzahtevi.AllowUserToResizeRows = false;
            this.dgSMSzahtevi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgSMSzahtevi.BackgroundColor = System.Drawing.Color.White;
            this.dgSMSzahtevi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgSMSzahtevi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSMSzahtevi.EnableHeadersVisualStyles = false;
            this.dgSMSzahtevi.Location = new System.Drawing.Point(20, 10);
            this.dgSMSzahtevi.Margin = new System.Windows.Forms.Padding(20, 10, 0, 5);
            this.dgSMSzahtevi.MultiSelect = false;
            this.dgSMSzahtevi.Name = "dgSMSzahtevi";
            this.dgSMSzahtevi.ReadOnly = true;
            this.dgSMSzahtevi.RowHeadersVisible = false;
            this.dgSMSzahtevi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSMSzahtevi.ShowEditingIcon = false;
            this.dgSMSzahtevi.Size = new System.Drawing.Size(541, 168);
            this.dgSMSzahtevi.TabIndex = 6;
            this.dgSMSzahtevi.Visible = false;
            this.dgSMSzahtevi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSMSzahtevi_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.linkSablon3);
            this.panel1.Controls.Add(this.linkSablon2);
            this.panel1.Controls.Add(this.linkSablon1);
            this.panel1.Controls.Add(this.linkDETALJI);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtDETALJI);
            this.panel1.Controls.Add(this.txtSMS);
            this.panel1.Controls.Add(this.lblRemChars);
            this.panel1.Location = new System.Drawing.Point(20, 188);
            this.panel1.Margin = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(541, 208);
            this.panel1.TabIndex = 11;
            // 
            // linkSablon3
            // 
            this.linkSablon3.AutoSize = true;
            this.linkSablon3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkSablon3.ForeColor = System.Drawing.Color.DimGray;
            this.linkSablon3.Location = new System.Drawing.Point(468, 185);
            this.linkSablon3.Name = "linkSablon3";
            this.linkSablon3.Size = new System.Drawing.Size(52, 15);
            this.linkSablon3.TabIndex = 14;
            this.linkSablon3.TabStop = true;
            this.linkSablon3.Text = "Šablon 3";
            this.linkSablon3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSablon3_LinkClicked);
            // 
            // linkSablon2
            // 
            this.linkSablon2.AutoSize = true;
            this.linkSablon2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkSablon2.ForeColor = System.Drawing.Color.DimGray;
            this.linkSablon2.Location = new System.Drawing.Point(468, 146);
            this.linkSablon2.Name = "linkSablon2";
            this.linkSablon2.Size = new System.Drawing.Size(52, 15);
            this.linkSablon2.TabIndex = 13;
            this.linkSablon2.TabStop = true;
            this.linkSablon2.Text = "Šablon 2";
            this.linkSablon2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSablon2_LinkClicked);
            // 
            // linkSablon1
            // 
            this.linkSablon1.AutoSize = true;
            this.linkSablon1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkSablon1.ForeColor = System.Drawing.Color.DimGray;
            this.linkSablon1.Location = new System.Drawing.Point(468, 107);
            this.linkSablon1.Name = "linkSablon1";
            this.linkSablon1.Size = new System.Drawing.Size(52, 15);
            this.linkSablon1.TabIndex = 12;
            this.linkSablon1.TabStop = true;
            this.linkSablon1.Text = "Šablon 1";
            this.linkSablon1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSablon1_LinkClicked);
            // 
            // linkDETALJI
            // 
            this.linkDETALJI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkDETALJI.AutoSize = true;
            this.linkDETALJI.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkDETALJI.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkDETALJI.Location = new System.Drawing.Point(409, 14);
            this.linkDETALJI.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.linkDETALJI.Name = "linkDETALJI";
            this.linkDETALJI.Size = new System.Drawing.Size(40, 15);
            this.linkDETALJI.TabIndex = 10;
            this.linkDETALJI.TabStop = true;
            this.linkDETALJI.Text = "Detalji";
            this.linkDETALJI.Visible = false;
            this.linkDETALJI.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDETALJI_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(34, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "SMS";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDETALJI
            // 
            this.txtDETALJI.BackColor = System.Drawing.Color.Snow;
            this.txtDETALJI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDETALJI.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDETALJI.ForeColor = System.Drawing.Color.LightCoral;
            this.txtDETALJI.Location = new System.Drawing.Point(85, 9);
            this.txtDETALJI.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.txtDETALJI.Name = "txtDETALJI";
            this.txtDETALJI.ReadOnly = true;
            this.txtDETALJI.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtDETALJI.Size = new System.Drawing.Size(377, 93);
            this.txtDETALJI.TabIndex = 9;
            this.txtDETALJI.Text = "text";
            this.txtDETALJI.Visible = false;
            // 
            // txtSMS
            // 
            this.txtSMS.BackColor = System.Drawing.Color.White;
            this.txtSMS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSMS.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSMS.ForeColor = System.Drawing.Color.DarkRed;
            this.txtSMS.Location = new System.Drawing.Point(85, 106);
            this.txtSMS.Margin = new System.Windows.Forms.Padding(20, 3, 3, 10);
            this.txtSMS.MaxLength = 160;
            this.txtSMS.Multiline = true;
            this.txtSMS.Name = "txtSMS";
            this.txtSMS.Size = new System.Drawing.Size(377, 93);
            this.txtSMS.TabIndex = 2;
            this.txtSMS.TabStop = false;
            this.txtSMS.TextChanged += new System.EventHandler(this.txtSMS_TextChanged);
            // 
            // lblRemChars
            // 
            this.lblRemChars.AutoSize = true;
            this.lblRemChars.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemChars.ForeColor = System.Drawing.Color.Gray;
            this.lblRemChars.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblRemChars.Location = new System.Drawing.Point(20, 147);
            this.lblRemChars.Margin = new System.Windows.Forms.Padding(20, 5, 3, 1);
            this.lblRemChars.Name = "lblRemChars";
            this.lblRemChars.Size = new System.Drawing.Size(56, 15);
            this.lblRemChars.TabIndex = 5;
            this.lblRemChars.Text = "160 / 160";
            this.lblRemChars.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // statusStrip1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.statusStrip1, 2);
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(1, 454);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(770, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // frm_SendSMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 477);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_SendSMS";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMS";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_SendSMS_FormClosed);
            this.Load += new System.EventHandler(this.frm_SendSMS_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_SendSMS_KeyDown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.gboConnectionStatus.ResumeLayout(false);
            this.gboConnectionStatus.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgSMSzahtevi)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnSEND;
        private System.Windows.Forms.Button btnIZLAZ;
        private System.Windows.Forms.TextBox txtSMS;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label lblRemChars;
        private System.Windows.Forms.DataGridView dgSMSzahtevi;
        private System.Windows.Forms.Button btnADMSEND;
        private System.Windows.Forms.Button btnADMDELETE;
        private System.Windows.Forms.RichTextBox txtDETALJI;
        private System.Windows.Forms.LinkLabel linkDETALJI;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ComboBox cboPortName;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.GroupBox gboConnectionStatus;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lblConnectionStatus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkSablon3;
        private System.Windows.Forms.LinkLabel linkSablon2;
        private System.Windows.Forms.LinkLabel linkSablon1;
    }
}