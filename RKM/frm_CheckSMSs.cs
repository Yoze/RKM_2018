using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RKM
{
    public partial class frm_CheckSMSs : Form
    {
        string _Mobtel { get; set; } // broj mobtela
        string _SHPRO { get; set; } // šifra prodavnice iz koje je poslat sms
        string _OPERATER { get; set; } // operater koji je uneo poruke
        int _ID_Potvrda { get; set; } // id potvrde na koju se odnosi sms; ujedno i FK u RKM_SMS
        DateTime VREMESLANJA { get; set; } // vreme kreiranja sms-a
        DateTime VREMEODOBRENJA { get; set; } // vreme kada je odobreno slanje poruke


        //
        // BEZPARAMETARSKI konstruktor
        public frm_CheckSMSs()
        {
            InitializeComponent();
        }



        private void PendingSMSs()
        {
            DataView dvPendingSMSs = new DataView();

        }


        //
        // PARAMETARSKI konstruktor


        //
        // DODAVANJE NOVOG ZAPISA U TABELU RKM_SMS
        private void DodajNoviSMS()
        {
            VREMESLANJA = DateTime.Now;

            // priprema novog reda za upis u tabelu RKM_SMS
            ReklamacijeDS.RKM_SMSRow noviSMS =
                (ReklamacijeDS.RKM_SMSRow)PunDS.reklamacijeDS.RKM_SMS.NewRow();
            try
            {
                noviSMS["BRTELEFONA"] = _Mobtel;
                noviSMS["PORUKA"] = txtSMS.Text;
                noviSMS["VREMESLANJA"] = VREMESLANJA;
                noviSMS["STATUS"] = "PND"; // PND == Pending
                noviSMS["ID_POTVRDA"] = _ID_Potvrda;
                noviSMS["SHPRO"] = _SHPRO;
                noviSMS["OPERATER"] = _OPERATER;
            }
            catch (Exception xcp)
            {
                MessageBox.Show(xcp.Message, "xcp NewRow noviSMS");
                return;
            }

            // Update tabele RKM_SMS novim redom noviSMS
            try
            {
                PunDS.reklamacijeDS.RKM_SMS.Rows.Add(noviSMS);
                PunDS.smsTA.Update(PunDS.reklamacijeDS.RKM_SMS);

                MessageBox.Show("SMS poruka je uspešno dodata na listu za slanje.", "Poruka je poslata");
            }
            catch (Exception xcp)
            {
                MessageBox.Show(xcp.Message, "xcp Update noviSMS");
                return;
            }
        }

        //
        // FORMATIRANJE BROJA ZBOG AT KOMANDI ZA SLANJE SMS; argument je vrednost iz txtMOBTEL; 
        // dodaje prefiks +381 i crop-uje 0 iz pozivnog broja
        private void parsujBroj(string Mobtel)
        {
            if (!(string.IsNullOrEmpty(Mobtel)))
            {
                StringBuilder sb = new StringBuilder();

                foreach (char c in Mobtel)
                {
                    if (c >= '0' && c <= '9')
                    {
                        sb.Append(c);
                    }
                }
                Mobtel = sb.ToString();
                Mobtel = Mobtel.Substring(1);
                Mobtel = "+381" + Mobtel;
                _Mobtel = Mobtel;
                txtMOBTEL.Text = _Mobtel;
            }
        }

        //
        // KONTROLNI DIJALOG ZA UPIS PORUKE U BAZU; poruka ima status PND i čeka na validaciju admina
        private void btnSEND_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSMS.Text))
            {
                MessageBox.Show("Upišite poruku za slanje!\nMaksimalno 160 karaktera.", "Greška - prazna poruka");
                txtSMS.Focus();
                return;
            }

            DialogResult result = MessageBox.Show("Poruka će biti poslata kupcu ukoliko potvrdite slanje.\nDa li želite da pošaljete poruku ?",
                "Slanje SMS poruke", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            switch (result)
            {
                case DialogResult.Yes:
                    DodajNoviSMS();
                    Close();
                    break;
                case DialogResult.No:
                    return;
            }
        }


        private void btnIZLAZ_Click(object sender, EventArgs e)
        {
            Close();
        }

        //
        // BROJAČ PREOSTALIH KARAKTERA U SMS PORUCI
        private void txtSMS_TextChanged(object sender, EventArgs e)
        {
            lblRemChars.Text = (160 - txtSMS.Text.Length).ToString() + "/160";
        }
    }
}
