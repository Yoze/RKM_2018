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
    public partial class frm_Print : Form
    {                

        public frm_Print()
        {
            InitializeComponent();
        }


        private void frm_Print_Load(object sender, EventArgs e)
        {
                        
            RKM_POTVRDATableAdapter.Connection.ConnectionString = ElbsSqlKonekcija.ELBS_ReklamacijeConnString;
            RKM_ZAHTEVTableAdapter.Connection.ConnectionString = ElbsSqlKonekcija.ELBS_ReklamacijeConnString;


            if (String.IsNullOrEmpty(frmEditovanje.brPotvrde))
            {
                MessageBox.Show("Nema broja potvrde","Greška");
                return;
            }

            //this.RKM_POTVRDATableAdapter.FillByID_Potvrda(this.ReklamacijeDS.RKM_POTVRDA, frmEditovanje._idPotvrde);
            this.RKM_POTVRDATableAdapter.FillByBrojPotvrde(this.ReklamacijeDS.RKM_POTVRDA, frmEditovanje.brPotvrde);
            this.RKM_ZAHTEVTableAdapter.FillByID_Zahtev(this.ReklamacijeDS.RKM_ZAHTEV, frmEditovanje.idZahteva);


            this.reportViewer1.RefreshReport();
            reportViewer1.PrinterSettings.Copies = 3;
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.PageWidth;

        }
        //
        // Š T A M P A N J E   O D L U K E   P R E   Z A T V A R A N J A   F O R M E
        //
        private void frm_Print_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {                
                this.Close();
            }
        }

        private void frm_Print_FormClosing(object sender, FormClosingEventArgs e)
        {
            stampaOdluke();            
        }
        
        private void stampaOdluke()
        {
            DialogResult result = MessageBox.Show("Da li želite štampanje\nodluke o reklamaciji?", "Štampa odluke",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            switch (result)
            {
                case DialogResult.No:             
                    return;                    
                case DialogResult.Yes:
                    frm_PrintOdluka _frm_PrintOdluka = new frm_PrintOdluka();
                    _frm_PrintOdluka.ShowDialog();
                    break;
            }
        }

    }
}
