namespace RKM
{
    partial class artikli
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
            this.datagridArtikli = new System.Windows.Forms.DataGridView();
            this.textPronadji = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelNemaPodataka = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagridArtikli)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridArtikli
            // 
            this.datagridArtikli.AllowUserToAddRows = false;
            this.datagridArtikli.AllowUserToDeleteRows = false;
            this.datagridArtikli.AllowUserToResizeColumns = false;
            this.datagridArtikli.AllowUserToResizeRows = false;
            this.datagridArtikli.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.datagridArtikli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.datagridArtikli.Location = new System.Drawing.Point(12, 100);
            this.datagridArtikli.Name = "datagridArtikli";
            this.datagridArtikli.ReadOnly = true;
            this.datagridArtikli.RowHeadersVisible = false;
            this.datagridArtikli.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.datagridArtikli.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridArtikli.Size = new System.Drawing.Size(410, 340);
            this.datagridArtikli.TabIndex = 1;
            this.datagridArtikli.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridArtikli_CellDoubleClick);
            // 
            // textPronadji
            // 
            this.textPronadji.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textPronadji.Location = new System.Drawing.Point(131, 71);
            this.textPronadji.Name = "textPronadji";
            this.textPronadji.Size = new System.Drawing.Size(180, 23);
            this.textPronadji.TabIndex = 0;
            this.textPronadji.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textPronadji.TextChanged += new System.EventHandler(this.textPronadji_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(347, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelNemaPodataka
            // 
            this.labelNemaPodataka.AutoSize = true;
            this.labelNemaPodataka.BackColor = System.Drawing.Color.Transparent;
            this.labelNemaPodataka.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNemaPodataka.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelNemaPodataka.Location = new System.Drawing.Point(102, 30);
            this.labelNemaPodataka.Name = "labelNemaPodataka";
            this.labelNemaPodataka.Size = new System.Drawing.Size(247, 30);
            this.labelNemaPodataka.TabIndex = 4;
            this.labelNemaPodataka.Text = "Nema traženih podataka. \r\nPritisni <Backspace> za poništavanje filtera.\r\n";
            this.labelNemaPodataka.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelNemaPodataka.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "UREĐAJI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Naziv ili deo naziva";
            // 
            // artikli
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 451);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelNemaPodataka);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textPronadji);
            this.Controls.Add(this.datagridArtikli);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(450, 490);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(450, 490);
            this.Name = "artikli";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Izbor uređaja";
            this.Activated += new System.EventHandler(this.artikli_Activated);
            this.Load += new System.EventHandler(this.artikli_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.artikli_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.datagridArtikli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridArtikli;
        private System.Windows.Forms.TextBox textPronadji;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelNemaPodataka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}