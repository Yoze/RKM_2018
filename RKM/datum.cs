using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace RKM
{
    public partial class datum : Form
    {

        
        
        
        public datum()
        {
            InitializeComponent();            
        }


        private void datum_Load(object sender, EventArgs e)
        {
            maskedTextBox1.Mask = "99/99/9999";

            timer1.Start();

        }


        private void maskedTextBox1_Leave(object sender, EventArgs e)
        {
            Regex obj = new Regex("(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)[0-9]{2}");


            if (string.IsNullOrEmpty(maskedTextBox1.Text))
            {
                //DateTime? datumNull = null;
                //MessageBox.Show(datumNull.ToString());
            }
            if (obj.IsMatch(maskedTextBox1.Text))
            {
                DateTime? datum = DateTime.Parse(maskedTextBox1.Text);
                MessageBox.Show(datum.ToString());
                maskedTextBox1.Text = datum.ToString();

            }
            else
            {
                DateTime? datumNull = null; 
                MessageBox.Show(datumNull.ToString());

                MessageBox.Show(obj.IsMatch(maskedTextBox1.Text).ToString() + "Greška, pokušaj ponovo", "Greška");
                maskedTextBox1.Focus();

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string dt = DateTime.Now.ToLongTimeString();
            
            label1.Text = dt;

        }



    }
}