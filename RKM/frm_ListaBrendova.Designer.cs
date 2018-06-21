namespace RKM
{
    partial class frm_ListaBrendova
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
            this.listBoxBrendovi = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label26 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxBrendovi
            // 
            this.listBoxBrendovi.ColumnWidth = 150;
            this.listBoxBrendovi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxBrendovi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxBrendovi.FormattingEnabled = true;
            this.listBoxBrendovi.ItemHeight = 16;
            this.listBoxBrendovi.Location = new System.Drawing.Point(3, 50);
            this.listBoxBrendovi.MultiColumn = true;
            this.listBoxBrendovi.Name = "listBoxBrendovi";
            this.listBoxBrendovi.Size = new System.Drawing.Size(666, 301);
            this.listBoxBrendovi.TabIndex = 0;
            this.listBoxBrendovi.DoubleClick += new System.EventHandler(this.listBoxBrendovi_DoubleClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label26, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.listBoxBrendovi, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(672, 354);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label26.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label26.Location = new System.Drawing.Point(10, 15);
            this.label26.Margin = new System.Windows.Forms.Padding(10, 15, 3, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(125, 17);
            this.label26.TabIndex = 13;
            this.label26.Text = "ODABERI BREND ";
            // 
            // frm_ListaBrendova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 354);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frm_ListaBrendova";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj novog servisera";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxBrendovi;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label26;
    }
}