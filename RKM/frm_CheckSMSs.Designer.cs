namespace RKM
{
    partial class frm_CheckSMSs
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
            this.btnSEND = new System.Windows.Forms.Button();
            this.btnIZLAZ = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMOBTEL = new System.Windows.Forms.TextBox();
            this.lblRemChars = new System.Windows.Forms.Label();
            this.txtSMS = new System.Windows.Forms.TextBox();
            this.dgvPendingSMSs = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendingSMSs)).BeginInit();
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
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(854, 469);
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
            this.flowLayoutPanel1.Size = new System.Drawing.Size(852, 30);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Provera SMS poruka za slanje";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanel2.Controls.Add(this.btnSEND);
            this.flowLayoutPanel2.Controls.Add(this.btnIZLAZ);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(1, 32);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(180, 436);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // btnSEND
            // 
            this.btnSEND.FlatAppearance.BorderSize = 0;
            this.btnSEND.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnSEND.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnSEND.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSEND.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSEND.Location = new System.Drawing.Point(0, 0);
            this.btnSEND.Margin = new System.Windows.Forms.Padding(0);
            this.btnSEND.Name = "btnSEND";
            this.btnSEND.Size = new System.Drawing.Size(180, 40);
            this.btnSEND.TabIndex = 0;
            this.btnSEND.Text = "Pošalji";
            this.btnSEND.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSEND.UseVisualStyleBackColor = true;
            this.btnSEND.Click += new System.EventHandler(this.btnSEND_Click);
            // 
            // btnIZLAZ
            // 
            this.btnIZLAZ.FlatAppearance.BorderSize = 0;
            this.btnIZLAZ.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnIZLAZ.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnIZLAZ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIZLAZ.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIZLAZ.Location = new System.Drawing.Point(0, 40);
            this.btnIZLAZ.Margin = new System.Windows.Forms.Padding(0);
            this.btnIZLAZ.Name = "btnIZLAZ";
            this.btnIZLAZ.Size = new System.Drawing.Size(180, 40);
            this.btnIZLAZ.TabIndex = 1;
            this.btnIZLAZ.Text = "Izlaz";
            this.btnIZLAZ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIZLAZ.UseVisualStyleBackColor = true;
            this.btnIZLAZ.Click += new System.EventHandler(this.btnIZLAZ_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.Snow;
            this.flowLayoutPanel3.Controls.Add(this.label2);
            this.flowLayoutPanel3.Controls.Add(this.txtMOBTEL);
            this.flowLayoutPanel3.Controls.Add(this.lblRemChars);
            this.flowLayoutPanel3.Controls.Add(this.txtSMS);
            this.flowLayoutPanel3.Controls.Add(this.dgvPendingSMSs);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(182, 32);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(671, 436);
            this.flowLayoutPanel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(20, 25, 0, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Poruka za";
            // 
            // txtMOBTEL
            // 
            this.txtMOBTEL.BackColor = System.Drawing.Color.Snow;
            this.txtMOBTEL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMOBTEL.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMOBTEL.Location = new System.Drawing.Point(88, 20);
            this.txtMOBTEL.Margin = new System.Windows.Forms.Padding(10, 20, 20, 10);
            this.txtMOBTEL.MaxLength = 30;
            this.txtMOBTEL.Name = "txtMOBTEL";
            this.txtMOBTEL.ReadOnly = true;
            this.txtMOBTEL.Size = new System.Drawing.Size(167, 25);
            this.txtMOBTEL.TabIndex = 3;
            this.txtMOBTEL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblRemChars
            // 
            this.lblRemChars.AutoSize = true;
            this.lblRemChars.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemChars.Location = new System.Drawing.Point(325, 50);
            this.lblRemChars.Margin = new System.Windows.Forms.Padding(50, 50, 3, 0);
            this.lblRemChars.Name = "lblRemChars";
            this.lblRemChars.Size = new System.Drawing.Size(50, 15);
            this.lblRemChars.TabIndex = 5;
            this.lblRemChars.Text = "160/160";
            this.lblRemChars.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSMS
            // 
            this.txtSMS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSMS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSMS.Location = new System.Drawing.Point(20, 68);
            this.txtSMS.Margin = new System.Windows.Forms.Padding(20, 3, 20, 20);
            this.txtSMS.MaxLength = 160;
            this.txtSMS.Multiline = true;
            this.txtSMS.Name = "txtSMS";
            this.txtSMS.Size = new System.Drawing.Size(361, 121);
            this.txtSMS.TabIndex = 2;
            this.txtSMS.TextChanged += new System.EventHandler(this.txtSMS_TextChanged);
            // 
            // dgvPendingSMSs
            // 
            this.dgvPendingSMSs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPendingSMSs.Location = new System.Drawing.Point(3, 212);
            this.dgvPendingSMSs.Name = "dgvPendingSMSs";
            this.dgvPendingSMSs.Size = new System.Drawing.Size(585, 123);
            this.dgvPendingSMSs.TabIndex = 6;
            // 
            // frm_CheckSMSs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 469);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_CheckSMSs";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMS";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendingSMSs)).EndInit();
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
        private System.Windows.Forms.TextBox txtMOBTEL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRemChars;
        private System.Windows.Forms.DataGridView dgvPendingSMSs;
    }
}