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
    public partial class frm_ListaBrendova : Form
    {

        List<string> listaBrendova = new List<string>();
        public static string _odabraniBrend;


        public frm_ListaBrendova()
        {
            InitializeComponent();

            puniBrendove();
        }


        private void puniBrendove()
        {
            SqlConnection cnn = new SqlConnection(ElbsSqlKonekcija.ELBS_ConnString);
            //SqlConnection cnn = new SqlConnection(Properties.Settings.Default.testELBS2015);
            string command = "SELECT proizvodjac FROM brand";
            SqlCommand komanda = new SqlCommand(command, cnn);

            try
            {
                cnn.Open();
                ConnectionState cnnState = cnn.State;
                if (cnnState == ConnectionState.Open)
                {
                    SqlDataReader dr = komanda.ExecuteReader();

                    while (dr.Read())
                    {
                        listaBrendova.Add(dr[0].ToString());
                    }

                    dr.Close();
                    cnn.Close();
                    listBoxBrendovi.DataSource = listaBrendova;
                    //MessageBox.Show("Brendovi su učitani", "Poruka");
                }
            }
            catch (Exception xcp)
            {
                MessageBox.Show(xcp.Message, "Greška - void puniBrendove");
                return;
            }
        }

        


        private void listBoxBrendovi_DoubleClick(object sender, EventArgs e)
        {

            foreach (string odabraniBrend in listBoxBrendovi.SelectedItems)
            {
               _odabraniBrend = odabraniBrend.TrimEnd(); // mora se trimovati kraj stringa
            }
            this.Close();

        }


    }
}
