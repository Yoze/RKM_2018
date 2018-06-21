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
    public partial class artikli : Form
    {

        //  globalne varijable
        public static string _red; // skladišti vrednost odabranog reda iz tabele sa artiklima
        public static DataTable tbl; // tabela Artikli u okviru Dataset-a; koristi se kao izvor za DataView dv 
        public static DataView dv; // smešta se DataView tabele Artikli za potrebe filitritanja u datagridArtikli
        ElbsSqlKonekcija elbsSqlKonekcija;
        private SqlConnection sqlConnectionArtikli;
        
        public artikli()
        {
            InitializeComponent();

            elbsSqlKonekcija = new ElbsSqlKonekcija();

        }

        
        // U Č I T A V A N J E   P O D A T A K A  U   T A B E L U   A R T I K L I
        private DataTable citajArtikle()
        {           
            try
            {
                using (sqlConnectionArtikli = elbsSqlKonekcija.CreateElbsSqlConnection("elbraco", "elbsNK"))
                {
                    sqlConnectionArtikli.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT siframag, artikal, naziv, barcode, proizvodjac FROM artikli WHERE siframag='099'", sqlConnectionArtikli);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Artikli");
                    DataTable tbl = ds.Tables["Artikli"];
                    return tbl;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška u komunikaciji sa serverom.\r\nMolim vas kontaktirajte tehničku podršku.\r\nERR: " + ex.Message,"Greška u komunikaciji");
            }

            return null;            
        }

        
        private void kreirajDataVievArtikli099()
        {          
            dv = new DataView(tbl);
            datagridArtikli.DataSource = dv;
        }


        // F I L T R I R A N J E    P O D A T A K A
        private void artikli099()
        {
            // vrši filtriranje podataka po nazivu, a na osnovu vrednosti iz textPronadji

            labelNemaPodataka.Visible = false;

            //DataView dv = new DataView(tbl);          
            string filter = String.Format("naziv LIKE '%{0}%'", textPronadji.Text);
            dv.RowFilter = filter;

            if (dv.Count < 1)
            {
                labelNemaPodataka.Visible = true;
                return;
            }
            datagridArtikli.DataSource = dv;
        }


        private void textPronadji_TextChanged(object sender, EventArgs e)
        {
            artikli099();
        }


        private void artikli_Load(object sender, EventArgs e)
        {           
            tbl = citajArtikle();
            kreirajDataVievArtikli099();
            
            // podešavanje izgleda datagridview kontrole
            this.datagridArtikli.Columns["siframag"].Visible = false;
            //this.datagridArtikli.Columns[1].Visible = false;
            this.datagridArtikli.Columns["proizvodjac"].Visible = false;
            this.datagridArtikli.Width = 410;

            this.datagridArtikli.Columns["artikal"].Width = 80;
            this.datagridArtikli.Columns["naziv"].Width = 200;
            this.datagridArtikli.Columns["barcode"].Width = 110;
            
            //textPronadji.Focus();
        }

        
        // D U G M E   O K
        private void button1_Click(object sender, EventArgs e)
        {
          // puni varijablu _red tipa string odabranim artiklom iz datagridArtikli
            if (datagridArtikli.SelectedRows.Count > 0)
            {
                for (int i = 0; i < datagridArtikli.SelectedRows.Count; i++)
                {
                    DataGridViewRow red = (DataGridViewRow)datagridArtikli.SelectedRows[i];
                    _red = Convert.ToString(red.Cells["naziv"].Value);
                }
            }
            this.Close();
        }

        
        // E S C
        private void artikli_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void artikli_Activated(object sender, EventArgs e)
        {
            textPronadji.Focus();
        }


        private void datagridArtikli_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // puni varijablu _red tipa string odabranim artiklom iz datagridArtikli
            if (datagridArtikli.SelectedRows.Count > 0)
            {
                for (int i = 0; i < datagridArtikli.SelectedRows.Count; i++)
                {
                    DataGridViewRow red = (DataGridViewRow)datagridArtikli.SelectedRows[i];
                    _red = Convert.ToString(red.Cells["naziv"].Value);
                }
            }
            this.Close();
        }




    }
}
