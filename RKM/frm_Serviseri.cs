using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RKM.ReklamacijeDSTableAdapters;
using System.Data.SqlClient;


namespace RKM
{
    public partial class frm_Serviseri : Form
    {        
        
        public static int _id_serviser { get; set; }
        public static int _indeksOdabranogZapisa { get; set; }
        private ReklamacijeDS.RKM_SERVISERRow izabraniServiser;



        public frm_Serviseri()
        {
            InitializeComponent();

            ucitajBrendove();
            txtBRAND.Text = frm_ListaBrendova._odabraniBrend;
            btnSnimiNovi.Visible = true;
        
        }
        //
        // U Č I T A V A N J E   F O R M E
        //
        private void frm_Serviseri_Load(object sender, EventArgs e)
        {
            


        }
        //
        // I Z M E N A   P O D A T A K A   O   S E R V I S E R U
        //
        public frm_Serviseri(int id_serviser, int indeksOdabranogZapisa)
        {
            InitializeComponent();

            btnSnimiIzmene.Visible = true;

            _id_serviser = id_serviser;
            _indeksOdabranogZapisa = indeksOdabranogZapisa;
            

            try
            {
                izabraniServiser =
                    PunDS.reklamacijeDS.RKM_SERVISER.FindByID_SERVISER(_id_serviser);

                txtBRAND.Text = izabraniServiser.BRAND;
                txtNAZIV.Text = izabraniServiser.NAZIV;
                txtADRESA.Text = izabraniServiser.ADRESA;
                txtMESTO.Text = izabraniServiser.MESTO;
                txtKONTAKT.Text = izabraniServiser.KONTAKT;
                txtTELEFON.Text = izabraniServiser.TELEFON;
                txtEMAIL.Text = izabraniServiser.EMAIL;
                txtNAPOMENA.Text = izabraniServiser.NAPOMENA;

            }
            catch (Exception)
            {
                MessageBox.Show("Greška - izmena podataka o serviseru","Greška");
                return;                
            }
        }
        //
        // I Z M E N A   P O D A T A K A 
        //
        private void btnIzmeniServ_Click(object sender, EventArgs e)
        {

            izabraniServiser.BRAND = txtBRAND.Text;
            izabraniServiser.NAZIV = txtNAZIV.Text;
            izabraniServiser.ADRESA = txtADRESA.Text;
            izabraniServiser.MESTO = txtMESTO.Text;
            izabraniServiser.KONTAKT = txtKONTAKT.Text;
            izabraniServiser.TELEFON = txtTELEFON.Text;
            izabraniServiser.EMAIL = txtEMAIL.Text;
            izabraniServiser.NAPOMENA = txtNAPOMENA.Text;
            
            PunDS.serviserTA.Update(PunDS.reklamacijeDS.RKM_SERVISER);
            MessageBox.Show("Podaci su snimljeni");
            this.Close();

        }     

        //
        // D O D A V A N J E   N O V O G   S E R V I S E R A  --> btnNoviServiser (OK)
        //
        private void dodajServisera()
        {
            
            
            ReklamacijeDS.RKM_SERVISERRow noviServiserRow =
                    (ReklamacijeDS.RKM_SERVISERRow)PunDS.reklamacijeDS.RKM_SERVISER.NewRow();

                if (string.IsNullOrEmpty(txtBRAND.Text))
                {
                    MessageBox.Show("Morate odabrati robnu marku iz liste","Greška");
                    return;
                }

                try
                {
                    noviServiserRow["BRAND"] = txtBRAND.Text;
                    noviServiserRow["NAZIV"] = txtNAZIV.Text;
                    noviServiserRow["ADRESA"] = txtADRESA.Text;
                    noviServiserRow["MESTO"] = txtMESTO.Text;
                    noviServiserRow["KONTAKT"] = txtKONTAKT.Text;
                    noviServiserRow["TELEFON"] = txtTELEFON.Text;
                    noviServiserRow["EMAIL"] = txtEMAIL.Text;
                    noviServiserRow["NAPOMENA"] = txtNAPOMENA.Text;

                    // dodaje novu vrstu u tabelu serviseri
                    PunDS.reklamacijeDS.RKM_SERVISER.Rows.Add(noviServiserRow);
                    PunDS.serviserTA.Update(PunDS.reklamacijeDS.RKM_SERVISER);

                    

                    MessageBox.Show("Zapis je dodat u tabelu", "Upis uspešan");
                    this.Close();
                }
                catch (Exception xcp)
                {
                    MessageBox.Show(xcp.Message, "Greška - void btnNoviServiser");
                    return;
                }
        }
        //
        //
        // 
        private void btnNoviServiser_Click(object sender, EventArgs e) // dugme OK
        {

            btnSnimiNovi.Visible = true;
            dodajServisera();
            this.Close();

        }
        //
        // B T N   O D U S T A N I 
        //
        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        //
        // E N T E R   I   E S C   T A S T E R I
        //
        private void frm_Serviseri_KeyDown(object sender, KeyEventArgs e)
        {
            Control nextControl;

            if (e.KeyCode == Keys.Enter)
            {
                nextControl = GetNextControl(ActiveControl, !e.Shift);
                if (nextControl == null)
                {
                    nextControl = GetNextControl(null, true);
                }
                nextControl.Focus();
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void txtBRAND_DoubleClick(object sender, EventArgs e)
        {
            ucitajBrendove();

            txtBRAND.Text = frm_ListaBrendova._odabraniBrend;
            txtNAZIV.Focus();
            
        }

        private void ucitajBrendove()
        {
            frm_ListaBrendova _ListaBrendova = new frm_ListaBrendova();
            _ListaBrendova.ShowDialog();
        }





    }
}
