namespace RKM
{
    partial class frm_Print
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Print));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.RKM_POTVRDABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReklamacijeDS = new RKM.ReklamacijeDS();
            this.RKM_ZAHTEVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RKM_POTVRDATableAdapter = new RKM.ReklamacijeDSTableAdapters.RKM_POTVRDATableAdapter();
            this.RKM_ZAHTEVTableAdapter = new RKM.ReklamacijeDSTableAdapters.RKM_ZAHTEVTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.RKM_POTVRDABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReklamacijeDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RKM_ZAHTEVBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.RKM_POTVRDABindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.RKM_ZAHTEVBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "RKM.ReportPotvrda.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ShowBackButton = false;
            this.reportViewer1.ShowCredentialPrompts = false;
            this.reportViewer1.ShowDocumentMapButton = false;
            this.reportViewer1.ShowFindControls = false;
            this.reportViewer1.ShowPromptAreaButton = false;
            this.reportViewer1.Size = new System.Drawing.Size(899, 620);
            this.reportViewer1.TabIndex = 0;
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
            // RKM_ZAHTEVBindingSource
            // 
            this.RKM_ZAHTEVBindingSource.DataMember = "RKM_ZAHTEV";
            this.RKM_ZAHTEVBindingSource.DataSource = this.ReklamacijeDS;
            // 
            // RKM_POTVRDATableAdapter
            // 
            this.RKM_POTVRDATableAdapter.ClearBeforeFill = true;
            // 
            // RKM_ZAHTEVTableAdapter
            // 
            this.RKM_ZAHTEVTableAdapter.ClearBeforeFill = true;
            // 
            // frm_Print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 620);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.Name = "frm_Print";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Štampanje potvrde o prijemu reklamacije";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Print_FormClosing);
            this.Load += new System.EventHandler(this.frm_Print_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_Print_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.RKM_POTVRDABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReklamacijeDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RKM_ZAHTEVBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource RKM_POTVRDABindingSource;
        private ReklamacijeDS ReklamacijeDS;
        private ReklamacijeDSTableAdapters.RKM_POTVRDATableAdapter RKM_POTVRDATableAdapter;
        private System.Windows.Forms.BindingSource RKM_ZAHTEVBindingSource;
        private ReklamacijeDSTableAdapters.RKM_ZAHTEVTableAdapter RKM_ZAHTEVTableAdapter;

    }
}