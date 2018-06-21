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
    public partial class frm_ServiseriLista : Form
    {

        
        public string filterDGserviser { get; set; }  // filter datagrid na osnovu vrednosti iz comboa
        public static int odabraniServiserID { get; set; } // ID_SERVISER za polje txtID_SERVISERA -- frmEditovanje
        public DataView dvServiser { get; set; }



        public frm_ServiseriLista()
        {
            InitializeComponent();

            ucitajServisere();
        }


        private void ucitajServisere()
        {
           
            dvServiser = new DataView(PunDS.reklamacijeDS.RKM_SERVISER); 
            dataGridServiseri.DataSource = dvServiser;

            dataGridServiseri.Columns["ID_SERVISER"].Visible = false;
            dataGridServiseri.Columns["BRAND"].Visible = true;
            dataGridServiseri.Columns["NAZIV"].Visible = true;
            dataGridServiseri.Columns["ADRESA"].Visible = true;
            dataGridServiseri.Columns["MESTO"].Visible = true;
            dataGridServiseri.Columns["KONTAKT"].Visible = true;
            dataGridServiseri.Columns["TELEFON"].Visible = true;
            dataGridServiseri.Columns["EMAIL"].Visible = true;
            dataGridServiseri.Columns["NAPOMENA"].Visible = false;


        }
        //
        // F I L T E R   Z A   D A T A G R I D   S E R V I S E R
        //
        private void filterDataGridServiseri(string odabraniBrand)
        {

            filterDGserviser = String.Format("brand LIKE '%{0}%'", odabraniBrand);
            dvServiser.RowFilter = filterDGserviser;
            
        }
        //
        // D O D A V A N J E   S E R V I S E R A
        //
        private void btnDodajServisera_Click_1(object sender, EventArgs e)
        {
            
            frm_Serviseri _frmServiseri = new frm_Serviseri();
            _frmServiseri.ShowDialog();

        }
        //
        // O D A B I R   S E R V I S E R A   I Z   D A T A G R I D - A
        //
        private void dataGridServiseri_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // puni varijablu _red tipa string odabranim artiklom iz dataGridServiseri
            if (dataGridServiseri.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dataGridServiseri.SelectedRows.Count; i++)
                {
                    DataGridViewRow red = (DataGridViewRow)dataGridServiseri.SelectedRows[i];
                    odabraniServiserID = Convert.ToInt32(red.Cells["ID_SERVISER"].Value);
                }
            }
            this.Close();
        }
        //
        // ESC TASTER
        //
        private void frm_ServiseriLista_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        //
        // I Z M E N A   P O D A T A K A   O   S E R V I S E R U
        //
        private void btnIzmeniServisera_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridServiseri.SelectedRows.Count < 0)
                    return;
                int indeksOdabranogZapisa = dataGridServiseri.CurrentCell.RowIndex; //rowindex
                int idServisera = (int)dvServiser[indeksOdabranogZapisa]["ID_SERVISER"]; //idpotvrda

                if (idServisera == 28)
                {
                    MessageBox.Show("Ovo je predefinisan podatak i ne može se menjati!", "Greška - izmena nije moguća");
                    return;
                }

                frm_Serviseri _frmServiseri = new frm_Serviseri(idServisera, indeksOdabranogZapisa);
                _frmServiseri.ShowDialog();

            }
            catch (Exception)
            {
                MessageBox.Show("Morate odabrati podatak za izmenu.", "Greška - void btnIzmenaServisera");
                return;
            }
        }
        //
        // B R I S A N J E   S E R V I S E R A
        //
        private void btnObrisiServisera_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridServiseri.SelectedRows.Count < 0)
                return;

                // ID ODABRANOG ZAPISA ZA BRISANJE
                int x = (int)dataGridServiseri.CurrentRow.Cells[0].Value; 

                
                // PROVERAVA DA LI JE ID ZAPISA == 28 (predefinisani zapis) - AKO JESTE ONDA PREKIDA BRISANJE
                if (x == 28) // id za --nije odabran serviser
                {
                    MessageBox.Show("Ovo je predefinisani podatak i ne može biti obrisan!", "Greška - brisanje nije moguće!");
                    return;
                }
                

                
                DialogResult result = MessageBox.Show("Odabrani zapis će biti obrisan! \nDa li ste sigurni da želite brisanje?",
                    "Brisanje", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                switch (result)
                {
                    case DialogResult.Cancel:
                        break;

                    case DialogResult.OK:
                        {
                            try
                            {
                                

                              

                                ReklamacijeDS.RKM_SERVISERRow izabraniRedServiser =
                                    PunDS.reklamacijeDS.RKM_SERVISER.FindByID_SERVISER(x);

                                izabraniRedServiser.Delete();
                                PunDS.serviserTA.Update(PunDS.reklamacijeDS.RKM_SERVISER);

                                MessageBox.Show("Odabrani zapis je obrisan!", "Brisanje podataka");
                            }
                            catch (Exception xcp)
                            {
                                MessageBox.Show(xcp.Message, "xcp brisanje podataka o serviseru");
                                return;
                            }
                        }
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Morate odabrati podatak za brisanje.", "Greška - void btnBrisiServisera");
                return;
            }
        }

        private void frm_ServiseriLista_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (odabraniServiserID == 0)
            {
                odabraniServiserID = 28;
            }
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }





    }
}
