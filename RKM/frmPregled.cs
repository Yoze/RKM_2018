using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RKM
{
    public partial class frmPregled : Form
    {

        private DataView dvGrid; // dataview za prikaz podataka u dataGridViewPrikaz...
        //private DataView dvDetails;
        private string filterSHPRO; // filter za prikaz podataka na osnovu šifre prodavnice (NEOPHODNO)

        private string filter; // filter podataka u dataGridViewPrikaz, samo ako je txtSearch korišćen, bez filtera po statusu        
        private string filter2; // filter kombinacija filter po statusu i txtSearch
        private string filterPoStatusu; // filter po statusu uređaja, radioButton
        private static int idPotvrda; // id odabranog zapisa iz dvGrid
        private static int nadjiID;
        private string LoggedUserName; //userID iz formLoginSQL textUser.Text

        
        
        public frmPregled(string user)
        {
            InitializeComponent();

            LoggedUserName = user;

        }


        //
        //  V I D L J I V O S T   K O L O N A   U   D A T A G R I D V I E W U
        private void frmPregled_Load(object sender, EventArgs e)
        {
            timer1.Start(); // pokretanje sata i datuma 


            lblPRODMESTO.Text =
                "Prodajno mesto " + formLoginSQL.PodaciProdajnogMesta[1] + " - Ulogovani ste kao: " + formLoginSQL.PodaciOperatera[1];

            
            // staviti na invisible pre publisha !!!
            //labelSQL.Text = Konekcija.novaKonekcija.ToString(); 


            // sifra prodavnice kao filter podataka u dataGridView samo za tu prodavnicu
            filterSHPRO =
                String.Format("shpro LIKE '%{0}%' AND is_deleted = 0", formLoginSQL.PodaciOperatera[0]);


            // punjenje dataset-a je u kreirajPregledDV
            kreirajPregledDV();
            btnBrisi.Enabled = false;
            btnIzmeni.Enabled = false;


            ////
            //// proverava ulogovanog korisnika; ako je admin SMS-a onda uključuje dugme za pregled poruka            
            //if (LoggedUserName == Properties.Settings.Default.UserID || LoggedUserName == Properties.Settings.Default.AdminID)
            //{
            //    btnSMSpregled.Visible = true;
            //    CheckSMSs();
            //}

            
            // Vidljive kolone
            dataGridViewPregledPoStatusu.Columns["SHPRO"].Visible = true;
            dataGridViewPregledPoStatusu.Columns["ID_POTVRDA"].Visible = false;
            dataGridViewPregledPoStatusu.Columns["BROJPOTVRDE"].Visible = true;
            dataGridViewPregledPoStatusu.Columns["PODNOSIOC"].Visible = true;
            dataGridViewPregledPoStatusu.Columns["MESTO"].Visible = true;
            dataGridViewPregledPoStatusu.Columns["TELEFON"].Visible = true;
            dataGridViewPregledPoStatusu.Columns["UREDJAJ"].Visible = true; // ne sme se isključivati zbog filtera !!!
            dataGridViewPregledPoStatusu.Columns["DATREKLAMACIJE"].Visible = true;
            dataGridViewPregledPoStatusu.Columns["OPISREKLAMACIJE"].Visible = true;
            dataGridViewPregledPoStatusu.Columns["ID_STATUS"].Visible = true;

            // Nevidljive kolone
            dataGridViewPregledPoStatusu.Columns["PMPRIJEMA"].Visible = false;
            dataGridViewPregledPoStatusu.Columns["PRIMIO"].Visible = false;
            dataGridViewPregledPoStatusu.Columns["ADRESA"].Visible = false;
            dataGridViewPregledPoStatusu.Columns["SN"].Visible = false;
            dataGridViewPregledPoStatusu.Columns["DATPRODAJE"].Visible = false;
            dataGridViewPregledPoStatusu.Columns["BROJFI"].Visible = false;
            dataGridViewPregledPoStatusu.Columns["PRIMEDBAPRODAVCA"].Visible = false;
            dataGridViewPregledPoStatusu.Columns["UGOVORENIROK"].Visible = false;
            dataGridViewPregledPoStatusu.Columns["NACINRESAVANJA"].Visible = false;
            dataGridViewPregledPoStatusu.Columns["DATUMRESAVANJA"].Visible = false;
            dataGridViewPregledPoStatusu.Columns["PRODUZROKA"].Visible = false;
            dataGridViewPregledPoStatusu.Columns["BELESKE"].Visible = false;
            dataGridViewPregledPoStatusu.Columns["DATUMSOMBOR"].Visible = false;
            dataGridViewPregledPoStatusu.Columns["DATUMODLUKE"].Visible = false;
            dataGridViewPregledPoStatusu.Columns["ODLUKA"].Visible = false;
            dataGridViewPregledPoStatusu.Columns["SERVISDATUM"].Visible = false;
            dataGridViewPregledPoStatusu.Columns["SERVISMISLJENJE"].Visible = false;
            dataGridViewPregledPoStatusu.Columns["BROJREZERVACIJE"].Visible = false;
            dataGridViewPregledPoStatusu.Columns["ID_ZAHTEV"].Visible = false;
            dataGridViewPregledPoStatusu.Columns["ID_SERVISER"].Visible = false;
            
        }

        //
        // I N I C I J A L N O   P U N J E N J E   D A T A S E T A   I   D A T A V I E W A
        private void kreirajPregledDV()
        {
            // PUNJENJE DATASET-a, dodeljivanje datasource-a datagridview kontroli
            PunDS.puniTabele(); // puni dataset
            //dataGridViewPregledPoStatusu.DataSource = PunDS.reklamacijeDS.RKM_POTVRDA; // u slučaju datatable umesto dataview

            dvGrid = new DataView(PunDS.reklamacijeDS.RKM_POTVRDA);
            dvGrid.RowFilter = filterSHPRO;
            dvGrid.Sort = "DATREKLAMACIJE DESC";

            dataGridViewPregledPoStatusu.DataSource = dvGrid;


            // proveriDataGrid();
        }

        //
        // B R O J A N J E   S M S 
        private void CheckSMSs()
        {
            // broji postojeće zapise u tabeli rkm_sms
            string SqlComm = "SELECT COUNT(*) FROM RKM_SMS WHERE ODOBRENAPORUKA='N'";

            string cSMSs = "0"; //broj zapisa u RKM_SMS
            //string Err = "Err";

            SqlConnection cnn = new SqlConnection(ElbsSqlKonekcija.ELBS_ConnString);

            SqlCommand komanda = new SqlCommand(SqlComm, cnn);

            try
            {
                cnn.Open();
                ConnectionState cnnState = cnn.State; // proverava stanje konekcije, da li je otvorena ili nije
                if (cnnState == ConnectionState.Open)
                {
                    SqlDataReader dr = komanda.ExecuteReader();
                    while (dr.Read())
                    {
                        cSMSs = dr[0].ToString();
                    }
                    dr.Close();
                }
                //string _cSMSs = CheckSMSs();
                btnSMSpregled.Text = "SMS Poruke" + " (" + cSMSs + ")";
                //return cSMSs;
            }
            catch (Exception)
            {
                MessageBox.Show("void CheckSMSs", "Greška DataReader");
                btnSMSpregled.Text = "Err";
            }
        }


        //
        // P R O V E R A   D A T A G R I D A   dvGrid
        private void proveriDataGrid()
        {
            // proverava podatke u dg-u, ako nema ništa onda isključuje dugme izmeni i obrnuto

            labelNemaPodataka.Visible = false;

            //if (dataGridViewPregledPoStatusu.Rows.Count < 1) // u slučaju datatable umesto dataview
            if (dvGrid.Count < 1)
            {
                btnIzmeni.Enabled = false;
                btnBrisi.Enabled = false;
                labelNemaPodataka.Visible = true;
                return;
            }
            if (dvGrid.Count >= 1)
            {
                btnIzmeni.Enabled = true;
                btnBrisi.Enabled = true;
                labelNemaPodataka.Visible = false;
            }
        }
        //
        // I Z M E N A   P O D A T A K A
        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            izmenaPodataka();
        }
        private void izmenaPodataka()
        {
            
            try
            {
                if (dataGridViewPregledPoStatusu.SelectedRows.Count < 0)
                    return;

                // row indeks odabrane vrste u datagrid-u
                nadjiID = dataGridViewPregledPoStatusu.CurrentCell.RowIndex;
                // id broj odabranog zapisa
                //int idPotvrda = (int)PunDS.reklamacijeDS.RKM_POTVRDA.Rows[nadjiID]["ID_POTVRDA"]; // slučaj sa datatable umesto dataview
                idPotvrda = (int)dvGrid[nadjiID]["ID_POTVRDA"];

                // argumenti konstruktora su vrednost kolone id_potvrda i indeks odabranog reda u dataGridViewPregled...
                frmEditovanje _frmEditovanje = new frmEditovanje(idPotvrda, nadjiID);
                _frmEditovanje.ShowDialog();
               // CheckSMSs();

                // resetuje filter u txtSearch            
                txtSearch.Text = "";
                filterPoStatusu = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Morate odabrati podatak za izmenu.", "Greška - void btnIzmeni");
                return;
            }
        }
        //
        // D O D A V A N J E   N O V O G   Z A P I S A
        private void btnNoviZapis_Click(object sender, EventArgs e)
        {
            // otvara formu za upis novih podataka
            frmEditovanje _frmNoviZapis = new frmEditovanje();
            _frmNoviZapis.ShowDialog();
           // CheckSMSs();

        }
        //
        // P R E T R A G A   P O M O Ć U   txtSearch textboxa
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // filtrira podatke u datagrid-u po koloni 'uredjaj'
            filterDataGrid();
        }
        //
        // B R I S A N J E   P O D A T A K A
        private void btnBrisi_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewPregledPoStatusu.SelectedRows.Count < 0)
                    return;

                // row indeks odabrane vrste u datagrid-u
                int nadjiID = dataGridViewPregledPoStatusu.CurrentCell.RowIndex;

                // id broj odabranog zapisa
                //int idPotvrda = (int)PunDS.reklamacijeDS.RKM_POTVRDA.Rows[nadjiID]["ID_POTVRDA"]; // slučaj sa datatable umesto dataview
                idPotvrda = (int)dvGrid[nadjiID]["ID_POTVRDA"];

                DialogResult result = MessageBox.Show("Odabrani zapis će biti obrisan! \nDa li ste sigurni da želite brisanje?",
                    "Brisanje", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                switch (result)
                {
                    case DialogResult.Cancel:
                        {
                            break;
                        }
                    case DialogResult.OK:
                        {
                            try
                            {
                                // izdvaja red na osnovu id-a zapisa
                                ReklamacijeDS.RKM_POTVRDARow izabraniRed =
                                    PunDS.reklamacijeDS.RKM_POTVRDA.FindByID_POTVRDA(idPotvrda);

                                //izabraniRed.Delete();
                                izabraniRed.is_deleted = 1;
                                PunDS.potvrdaTA.Update(PunDS.reklamacijeDS.RKM_POTVRDA);

                                

                                MessageBox.Show("Zapis je obrisan!");
                            }
                            catch (Exception xcp)
                            {
                                MessageBox.Show(xcp.Message, "xcp brisanje podataka");
                                return;
                            }
                            break;
                        }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Morate odabrati podatak za brisanje.", "Greška - void btnBrisi");
                return;
            }
        }
        //
        // F I L T E R I   P O   S T A T U S U   Z A   R A D I O   B T N   i   T E X T B O X
        private void btnNoFilter_Click(object sender, EventArgs e)
        {
            // poništava sve filtere u nad dvGrid i isključuje radio buttone

            foreach (Control selBttn in flowLayoutPanel3.Controls)
            {
                if (selBttn is RadioButton)
                {
                    if (((RadioButton)selBttn).Checked)
                    {
                        ((RadioButton)selBttn).Checked = false;
                    }
                }
            }
            txtSearch.Text = null;
            filter = null;
            filter2 = null;
            filterPoStatusu = null;
            dvGrid.RowFilter = filterSHPRO;
            labelNemaPodataka.Visible = false;
            proveriDataGrid();
            dataGridViewPregledPoStatusu.Refresh();
        }
        //
        // KOMBINOVANI FILTERI TXTsEARCH + PO STATUSU
        private void filterDataGrid()
        {
            // filtriranje podataka u koloni uredjaj na osnovu txtSearch
            // ako je uključen filter po statusu rowFilter je kombinacija filtera po statusu i txtSearch


            dvGrid.RowFilter = filterSHPRO; // filter podataka prodavnice u kojoj se korisnik logovao


            if (string.IsNullOrEmpty(filterPoStatusu) == true) // ako je filter po statusu prazan onda se primenjuje samo filter iz txtboxa
            {
                filter = String.Format("uredjaj LIKE '%{0}%'", txtSearch.Text); // pretraga polja UREDJAJ
                //dvGrid.RowFilter = filter;
                dvGrid.RowFilter = filterSHPRO + " AND " + filter;
            }
            if (!(string.IsNullOrEmpty(filterPoStatusu) == true)) // ako filt po stat nije prazan onda se kombinuje sa txtbox
            {
                filter = String.Format("uredjaj LIKE '%{0}%'", txtSearch.Text);
                //filter2 = filterPoStatusu + " AND " + filter;
                filter2 = filterSHPRO + " AND " + filterPoStatusu + " AND " + filter;
                dvGrid.RowFilter = filter2;

            }
            proveriDataGrid();
            dataGridViewPregledPoStatusu.DataSource = dvGrid;
        }
        #region FILTERI PO STATUSU
        //
        // R A D I O   B U T T O N   F I L T E R I   P O   S T A T U S U
        private void radioPrimljen_CheckedChanged(object sender, EventArgs e)
        {
            // primljen u prodavnicu            
            bool isChecked = radioPrimljen.Checked;
            if (isChecked)
            {
                txtSearch.Text = null;
                filter = null;
                filter2 = null;
                filterPoStatusu = "id_status = 1";
                //dvGrid.RowFilter = filterPoStatusu;
                dvGrid.RowFilter = filterSHPRO + " AND " + filterPoStatusu;
                proveriDataGrid();
                dataGridViewPregledPoStatusu.DataSource = dvGrid;
            }
        }

        private void radioServis_CheckedChanged(object sender, EventArgs e)
        {
            // poslat na servis
            bool isChecked = radioServis.Checked;
            if (isChecked)
            {
                txtSearch.Text = null;
                filter = null;
                filter2 = null;
                filterPoStatusu = "id_status = 16";
                //dvGrid.RowFilter = filterPoStatusu;
                dvGrid.RowFilter = filterSHPRO + " AND " + filterPoStatusu;
                proveriDataGrid();
                dataGridViewPregledPoStatusu.DataSource = dvGrid;
            }
        }

        private void radioPoslatSO_CheckedChanged(object sender, EventArgs e)
        {
            // poslat u sombor
            bool isChecked = radioPoslatSO.Checked;
            if (isChecked)
            {
                txtSearch.Text = null;
                filter = null;
                filter2 = null;
                filterPoStatusu = "id_status = 22";
                //dvGrid.RowFilter = filterPoStatusu;
                dvGrid.RowFilter = filterSHPRO + " AND " + filterPoStatusu;
                proveriDataGrid();
                dataGridViewPregledPoStatusu.DataSource = dvGrid;
            }
        }

        private void radioPopravljen1_CheckedChanged(object sender, EventArgs e)
        {
            // popravljen - vraćen sa servisa
            bool isChecked = radioPopravljen1.Checked;
            if (isChecked)
            {
                txtSearch.Text = null;
                filter = null;
                filter2 = null;
                filterPoStatusu = "id_status = 17";
                //dvGrid.RowFilter = filterPoStatusu;
                dvGrid.RowFilter = filterSHPRO + " AND " + filterPoStatusu;
                proveriDataGrid();
                dataGridViewPregledPoStatusu.DataSource = dvGrid;
            }
        }

        private void radioPopravljen2_CheckedChanged(object sender, EventArgs e)
        {
            // popravljen - uvoznik šalje
            bool isChecked = radioPopravljen2.Checked;
            if (isChecked)
            {
                txtSearch.Text = null;
                filter = null;
                filter2 = null;
                filterPoStatusu = "id_status = 18";
                //dvGrid.RowFilter = filterPoStatusu;
                dvGrid.RowFilter = filterSHPRO + " AND " + filterPoStatusu;
                proveriDataGrid();
                dataGridViewPregledPoStatusu.DataSource = dvGrid;
            }
        }

        private void radioNepopravljivZamena_CheckedChanged(object sender, EventArgs e)
        {
            // nepopravljiv - čeka zamenu
            bool isChecked = radioNepopravljivZamena.Checked;
            if (isChecked)
            {
                txtSearch.Text = null;
                filter = null;
                filter2 = null;
                filterPoStatusu = "id_status = 19";
                //dvGrid.RowFilter = filterPoStatusu;
                dvGrid.RowFilter = filterSHPRO + " AND " + filterPoStatusu;
                proveriDataGrid();
                dataGridViewPregledPoStatusu.DataSource = dvGrid;
            }
        }

        private void radioNepopravljivKO_CheckedChanged(object sender, EventArgs e)
        {
            // nepopravljiv - čeka K.O.
            bool isChecked = radioNepopravljivKO.Checked;
            if (isChecked)
            {
                txtSearch.Text = null;
                filter = null;
                filter2 = null;
                filterPoStatusu = "id_status = 20";
                //dvGrid.RowFilter = filterPoStatusu;
                dvGrid.RowFilter = filterSHPRO + " AND " + filterPoStatusu;
                proveriDataGrid();
                dataGridViewPregledPoStatusu.DataSource = dvGrid;
            }
        }

        private void radioResen_CheckedChanged(object sender, EventArgs e)
        {
            // rešen
            bool isChecked = radioResen.Checked;
            if (isChecked)
            {
                txtSearch.Text = null;
                filter = null;
                filter2 = null;
                filterPoStatusu = "id_status = 21";
                //dvGrid.RowFilter = filterPoStatusu;
                dvGrid.RowFilter = filterSHPRO + " AND " + filterPoStatusu;
                proveriDataGrid();
                dataGridViewPregledPoStatusu.DataSource = dvGrid;
            }
        }

        private void radioRezervacija_CheckedChanged(object sender, EventArgs e)
        {
            // rezervacija
            bool isChecked = radioRezervacija.Checked;
            if (isChecked)
            {
                txtSearch.Text = null;
                filter = null;
                filter2 = null;
                filterPoStatusu = "id_status = 23";
                //dvGrid.RowFilter = filterPoStatusu;
                dvGrid.RowFilter = filterSHPRO + " AND " + filterPoStatusu;
                proveriDataGrid();
                dataGridViewPregledPoStatusu.DataSource = dvGrid;
            }
        }
        #endregion
        //
        // I Z L A Z
        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //
        // KORISNIK MORA DA KLIKNE NA ZAPIS U DGRIDU DA BI AKTIVIRAO KONTROLE
        private void dataGridViewPregledPoStatusu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnBrisi.Enabled = true;
            btnIzmeni.Enabled = true;
        }

        //
        // P R I K A Z   S A T A   I   D A T U M A
        private void timer1_Tick(object sender, EventArgs e)
        {
            string t1 = DateTime.Now.ToLongTimeString();
            string d1 = DateTime.Now.ToShortDateString();

            label2.Text = t1 + "\n" + d1;
        }

        //
        // ADMIN PREGLED SMS PORUKA - DUGME SMS
        // vrši se verifikacija poruke i konačna potvrda za slanje menjanjem statusa u RKM_SMS
        private void btnSMSpregled_Click(object sender, EventArgs e)
        {


            frm_SendSMS _frm_SendSMS = new frm_SendSMS("Verifikacija SMS poruka", true);
            _frm_SendSMS.ShowDialog();
          //  CheckSMSs();


        }


        //
        // IZMENA PODATAKA ODABRANOG ZAPISA
        private void dataGridViewPregledPoStatusu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            izmenaPodataka();
        }

        private void frmPregled_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }




    }          
}
