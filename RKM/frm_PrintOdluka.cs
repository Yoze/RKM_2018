using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting;
using Microsoft.Reporting.WinForms;
using RKM.ReklamacijeDSTableAdapters;

namespace RKM
{
    public partial class frm_PrintOdluka : Form
    {
        public frm_PrintOdluka()
        {
            InitializeComponent();
        }

        private void frm_PrintOdluka_Load(object sender, EventArgs e)
        {

            RKM_POTVRDATableAdapter.Connection.ConnectionString = ElbsSqlKonekcija.ELBS_ReklamacijeConnString;

            this.RKM_POTVRDATableAdapter.FillByBrojPotvrde(this.ReklamacijeDS.RKM_POTVRDA, frmEditovanje.brPotvrde);

            this.reportViewer1.RefreshReport();
            reportViewer1.PrinterSettings.Copies = 3;
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.PageWidth;

        }

        private void frm_PrintOdluka_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
