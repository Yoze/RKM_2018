using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Deployment.Application;


namespace RKM
{
    public partial class formLoginSQL : Form
    {
        public static List<string> PodaciOperatera; // generička kolekcija sadrži shpro, naziv operatera
        public static List<string> PodaciProdajnogMesta; // generička kolekcija sadrži shpro, mesto, adresu i telefon PM
        public static SqlConnection ELBS_Connection; // sql konekcija sa parametrima iz Konekcija.novaKonekcija
        private SqlConnection elbsReklamacijeConnection;
        
        private ElbsSqlKonekcija elbsSqlKonekcija;



        public formLoginSQL()
        {
            InitializeComponent();

            elbsSqlKonekcija = new ElbsSqlKonekcija();

            //NE RADI KADA JE OFFLINE !!! - ispis verzije programa -- UNCOMMENT PRE PUBLISH-A !!!
            try
            {
                label1.Text = AssemblyVersion.Major.ToString() + "."
                    + AssemblyVersion.Minor.ToString() + "."
                    + AssemblyVersion.Build.ToString() + "."
                    + AssemblyVersion.Revision.ToString();
            }
            catch (Exception)
            {
                label1.Text = "Local Assembly Version!";
                return;

            }
            textUser.Focus();
        }


        public Version AssemblyVersion
        {
            get
            {
                return ApplicationDeployment.CurrentDeployment.CurrentVersion;
            }
        }


        private void buttonPrijava_Click(object sender, EventArgs e)
        {
            PrijavljivanjeOperatera();
        }


        private void PrijavljivanjeOperatera()
        {
            if (textUser.Text != null && textPassword.Text != null)
            {
                using (ELBS_Connection = elbsSqlKonekcija.CreateElbsSqlConnection(textUser.Text, textPassword.Text))
                {
                    try
                    {
                        ELBS_Connection.Open();
                        UcitajPodatkeOperatera(textUser.Text);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Pogrešno korisničko ime i/ili lozinka.\r\nMolim vas pokušajte ponovo.", "Greška u prijavi");
                        return;
                    }                    
                }

                using (elbsReklamacijeConnection = elbsSqlKonekcija.CreateElbsReklamacijeSqlConnection())
                {
                    try
                    {
                        elbsReklamacijeConnection.Open();
                        UcitajPodatkeProdajnogMesta();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Greška u komunikaciji sa serverom.\r\nMolim Vas kontaktirajte tehničku podršku.", "Greška u komunikaciji");
                        return;
                    }                   
                }

                frmPregled _frmPregled = new frmPregled(textUser.Text);
                _frmPregled.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Korisničko ime i lozinka moraju biti upisani!", "Greška u prijavi");
                return;
            }
        }


        private void UcitajPodatkeOperatera(string txtUser)
        {
            try
            {
                string selectLoggedUser = "SELECT shpro, naziv FROM operater WHERE userid='" + txtUser + "'";
                                
                SqlCommand komanda = new SqlCommand(selectLoggedUser, ELBS_Connection);
                SqlDataReader dr = komanda.ExecuteReader();

                // Podaci o logovanom korisniku
                PodaciOperatera = new List<string>();

                while (dr.Read())
                {
                    PodaciOperatera.Add(dr[0].ToString());
                    PodaciOperatera.Add(dr[1].ToString());
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greška - DataReaderUser");
                return;
            }
        }
        

        private void UcitajPodatkeProdajnogMesta()
        {            
            try
            {
                string selectProdMesto = "SELECT shpro, mesto, adresa, telefon FROM rkm_pm WHERE shpro='"
                    + PodaciOperatera[0].ToString() + "'";

                SqlCommand komandaPM = new SqlCommand(selectProdMesto, elbsReklamacijeConnection);
                SqlDataReader drPM = komandaPM.ExecuteReader();

                // Podaci o prodajnom mestu za logovanog korisnika
                PodaciProdajnogMesta = new List<string>();

                while (drPM.Read())
                {
                    PodaciProdajnogMesta.Add(drPM[0].ToString());
                    PodaciProdajnogMesta.Add(drPM[1].ToString());
                    PodaciProdajnogMesta.Add(drPM[2].ToString());
                    PodaciProdajnogMesta.Add(drPM[3].ToString());
                }
                drPM.Close();
            }
            catch (Exception xcp)
            {
                MessageBox.Show(xcp.Message, "Greška - DataReaderPM");
                return;
            }
        }



        private void buttonOtkazi_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void formLoginSQL_Load(object sender, EventArgs e)
        {
            textUser.Focus();
        }


        private void formLoginSQL_KeyDown(object sender, KeyEventArgs e)
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
        }
    }
}
