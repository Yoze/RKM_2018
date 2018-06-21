namespace RKM
{
    partial class frm_PrintOdluka
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_PrintOdluka));
            this.RKM_POTVRDABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReklamacijeDS = new RKM.ReklamacijeDS();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.RKM_POTVRDATableAdapter = new RKM.ReklamacijeDSTableAdapters.RKM_POTVRDATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.RKM_POTVRDABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReklamacijeDS)).BeginInit();
            this.SuspendLayout();
            // 
            // RKM_POTVRDABindingSource
            // 
            this.RKM_POTVRDABindingSource.DataMember = "RKM_POTVRDA";
            this.RKM_POTVRDABindingSource.DataSource = this.ReklamacijeDS;
            // 
            // ReklamacijeDS
            // 
            this.ReklamacijeDS.DataSetName = "ReklamacijeDS";
            this.ReklamacijeDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.RKM_POTVRDABindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "RKM.ReportOdluka.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(901, 672);
            this.reportViewer1.TabIndex = 0;
            // 
            // RKM_POTVRDATableAdapter
            // 
            this.RKM_POTVRDATableAdapter.ClearBeforeFill = true;
            // 
            // frm_PrintOdluka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 672);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.Name = "frm_PrintOdluka";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Štampanje  odluke o reklamaciji";
            this.Load += new System.EventHandler(this.frm_PrintOdluka_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_PrintOdluka_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.RKM_POTVRDABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReklamacijeDS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource RKM_POTVRDABindingSource;
        private ReklamacijeDS ReklamacijeDS;
        private ReklamacijeDSTableAdapters.RKM_POTVRDATableAdapter RKM_POTVRDATableAdapter;
    }
}