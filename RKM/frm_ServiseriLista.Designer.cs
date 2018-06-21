namespace RKM
{
    partial class frm_ServiseriLista
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
            this.dataGridServiseri = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label26 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDodajServisera = new System.Windows.Forms.Button();
            this.btnIzmServisera = new System.Windows.Forms.Button();
            this.btnBrisi = new System.Windows.Forms.Button();
            this.btnIzlaz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridServiseri)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridServiseri
            // 
            this.dataGridServiseri.AllowUserToAddRows = false;
            this.dataGridServiseri.AllowUserToDeleteRows = false;
            this.dataGridServiseri.AllowUserToOrderColumns = true;
            this.dataGridServiseri.AllowUserToResizeRows = false;
            this.dataGridServiseri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridServiseri.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridServiseri.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridServiseri.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridServiseri.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridServiseri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridServiseri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridServiseri.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridServiseri.EnableHeadersVisualStyles = false;
            this.dataGridServiseri.Location = new System.Drawing.Point(93, 50);
            this.dataGridServiseri.MultiSelect = false;
            this.dataGridServiseri.Name = "dataGridServiseri";
            this.dataGridServiseri.ReadOnly = true;
            this.dataGridServiseri.RowHeadersVisible = false;
            this.dataGridServiseri.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridServiseri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridServiseri.Size = new System.Drawing.Size(648, 348);
            this.dataGridServiseri.TabIndex = 0;
            this.dataGridServiseri.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridServiseri_CellDoubleClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridServiseri, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label26, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(744, 401);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label26.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label26.Location = new System.Drawing.Point(100, 15);
            this.label26.Margin = new System.Windows.Forms.Padding(10, 15, 3, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(218, 17);
            this.label26.TabIndex = 12;
            this.label26.Text = "LISTA OVLAŠĆENIH SERVISERA";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Gainsboro;
            this.flowLayoutPanel1.Controls.Add(this.btnDodajServisera);
            this.flowLayoutPanel1.Controls.Add(this.btnIzmServisera);
            this.flowLayoutPanel1.Controls.Add(this.btnBrisi);
            this.flowLayoutPanel1.Controls.Add(this.btnIzlaz);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.tableLayoutPanel1.SetRowSpan(this.flowLayoutPanel1, 2);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(84, 395);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnDodajServisera
            // 
            this.btnDodajServisera.FlatAppearance.BorderSize = 0;
            this.btnDodajServisera.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnDodajServisera.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnDodajServisera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajServisera.Image = global::RKM.Properties.Resources.add_file_26;
            this.btnDodajServisera.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDodajServisera.Location = new System.Drawing.Point(3, 3);
            this.btnDodajServisera.Name = "btnDodajServisera";
            this.btnDodajServisera.Size = new System.Drawing.Size(80, 56);
            this.btnDodajServisera.TabIndex = 4;
            this.btnDodajServisera.TabStop = false;
            this.btnDodajServisera.Text = "Novi serviser";
            this.btnDodajServisera.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDodajServisera.UseVisualStyleBackColor = true;
            this.btnDodajServisera.Click += new System.EventHandler(this.btnDodajServisera_Click_1);
            // 
            // btnIzmServisera
            // 
            this.btnIzmServisera.FlatAppearance.BorderSize = 0;
            this.btnIzmServisera.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnIzmServisera.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnIzmServisera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzmServisera.Image = global::RKM.Properties.Resources.edit_file_26;
            this.btnIzmServisera.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIzmServisera.Location = new System.Drawing.Point(3, 65);
            this.btnIzmServisera.Name = "btnIzmServisera";
            this.btnIzmServisera.Size = new System.Drawing.Size(80, 56);
            this.btnIzmServisera.TabIndex = 5;
            this.btnIzmServisera.TabStop = false;
            this.btnIzmServisera.Text = "Izmeni";
            this.btnIzmServisera.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIzmServisera.UseVisualStyleBackColor = true;
            this.btnIzmServisera.Click += new System.EventHandler(this.btnIzmeniServisera_Click);
            // 
            // btnBrisi
            // 
            this.btnBrisi.FlatAppearance.BorderSize = 0;
            this.btnBrisi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnBrisi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnBrisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrisi.ForeColor = System.Drawing.Color.Red;
            this.btnBrisi.Image = global::RKM.Properties.Resources.delete_file_26;
            this.btnBrisi.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBrisi.Location = new System.Drawing.Point(3, 127);
            this.btnBrisi.Name = "btnBrisi";
            this.btnBrisi.Size = new System.Drawing.Size(80, 56);
            this.btnBrisi.TabIndex = 6;
            this.btnBrisi.TabStop = false;
            this.btnBrisi.Text = "Obriši";
            this.btnBrisi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBrisi.UseVisualStyleBackColor = true;
            this.btnBrisi.Click += new System.EventHandler(this.btnObrisiServisera_Click);
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.FlatAppearance.BorderSize = 0;
            this.btnIzlaz.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnIzlaz.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnIzlaz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzlaz.Image = global::RKM.Properties.Resources.close_window_26;
            this.btnIzlaz.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIzlaz.Location = new System.Drawing.Point(3, 189);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(80, 56);
            this.btnIzlaz.TabIndex = 7;
            this.btnIzlaz.TabStop = false;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // frm_ServiseriLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(744, 401);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_ServiseriLista";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista ovlašćenih servisera";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_ServiseriLista_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_ServiseriLista_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridServiseri)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridServiseri;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnDodajServisera;
        private System.Windows.Forms.Button btnIzmServisera;
        private System.Windows.Forms.Button btnBrisi;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button btnIzlaz;
    }
}