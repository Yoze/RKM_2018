using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Management;


namespace RKM
{
    public partial class frm_SendSMS : Form
    {
        string _Mobtel { get; set; } // broj mobtela
        string _SHPRO { get; set; } // šifra prodavnice iz koje je poslat sms
        string _OPERATER { get; set; } // operater koji je uneo poruke
        int _ID_Potvrda { get; set; } // id potvrde na koju se odnosi sms; ujedno i FK u RKM_SMS
        DateTime VREMESLANJA { get; set; } // vreme kreiranja sms-a
        DateTime VREMEODOBRENJA { get; set; } // vreme kada je odobreno slanje poruke
        private DataView PorukeZaSlanje; // lista poruka koje čekaju verifikaciju, filtriranje po ODOBRENAPRUKA=N (poziva se iz PregledSMSzaSlanje)
        private DataRow drOdabranaPotvrda { get; set; } // RKM_POTVRDA.FindByID_POTVRDA
        private DataRow drOdabraniSMS { get; set; } // RKM_SMS.FindByID_SMS

        
        #region Private Variables
        SerialPort port = new SerialPort(); // komunikacioni port za vezu s aGPRS modemom
        clsSMS objclsSMS = new clsSMS();
        ShortMessageCollection objShortMessageCollection = new ShortMessageCollection();
        #endregion


        private void frm_SendSMS_Load(object sender, EventArgs e)
        {
           
        }
        
        
        //
        // BEZPARAMETARSKI konstruktor
        public frm_SendSMS()
        {
            InitializeComponent();
        }

        
        //
        // PARAMETARSKI KONSTRUKTOR - poziva ga običan korisnik radi unosa SMS-a za slanje
        public frm_SendSMS(string Mobtel, int ID_Potvrda, string SHPRO, string OPERATER)
        {
            InitializeComponent();

            _ID_Potvrda = ID_Potvrda;
            _SHPRO = SHPRO;
            _OPERATER = OPERATER;

            parsujBroj(Mobtel);
            txtSMS.Focus();
        }


        //
        // PARAMETARSKI KONSTRUKTOR - poziva ga admin radi provere zahteva za slanje SMS-ova
        // i verifikacije slanja, pregled zahteva za slanje SMS-a
        public frm_SendSMS(string naslov, bool vidljivost)
        {
            InitializeComponent();

            // kreiranje DataView objekta za prikaz u DataGrid, parametar je filter za kolonu status u RKM_SMS
            PorukeZaSlanje = PregledSMSzaSlanje("N");

            // vidljive kontrole
            label1.Text = naslov;
            dgSMSzahtevi.Visible = !vidljivost;
            btnADMDELETE.Visible = !vidljivost;
            txtDETALJI.Visible = vidljivost;
            btnADMSEND.Visible = !vidljivost;
            gboConnectionStatus.Visible = vidljivost;
            linkDETALJI.Visible = vidljivost;
            panel1.Visible = !vidljivost;
            btnSEND.Visible = !vidljivost;
            

            
            dgSMSzahtevi.DataSource = PorukeZaSlanje;

            // KOLONE U DataGridView
            dgSMSzahtevi.Columns["SHPRO"].HeaderText = "Prodavnica";
            dgSMSzahtevi.Columns["SHPRO"].Visible = true;

            dgSMSzahtevi.Columns["OPERATER"].HeaderText = "Operater";
            dgSMSzahtevi.Columns["OPERATER"].Visible = true;

            dgSMSzahtevi.Columns["VREMESLANJA"].HeaderText = "Vreme slanja SMS-a";
            dgSMSzahtevi.Columns["VREMESLANJA"].Visible = true;

            dgSMSzahtevi.Columns["PORUKA"].Visible = false;
            dgSMSzahtevi.Columns["ID_SMS"].Visible = false;
            dgSMSzahtevi.Columns["BRTELEFONA"].Visible = false;

            dgSMSzahtevi.Columns["ID_POTVRDA"].HeaderText = "ID zapisa";
            dgSMSzahtevi.Columns["ID_POTVRDA"].Visible = true;

            dgSMSzahtevi.Columns["VREMEODOBRENJA"].Visible = false;

            dgSMSzahtevi.Columns["ODOBRENAPORUKA"].HeaderText = "Odobren";
            dgSMSzahtevi.Columns["ODOBRENAPORUKA"].Visible = true;

            dgSMSzahtevi.Columns["ODOBRIO"].Visible = false;


            // PODEŠAVANJA GPRS MODEMA
            // pregled COM portova na sistemu i njihovo izlistavanje u combo box-u
            try
            {
                // ----------  Working ------------------------
                #region Display all available COM Ports
                string[] ports = SerialPort.GetPortNames();

                // Add all port names to the combo box:
                foreach (string port in ports)
                {
                    this.cboPortName.Items.Add(port);
                }
                #endregion
                //------------------ End --------------------




                this.btnDisconnect.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Greška prilikom učitavanja forme", "xcp frm_SendSMS_Load");
                return;
            }
        }





        //
        //
        private void OdabraniZapis()
        {
            int ID_POTVRDA = 0; // ID_POTVRDA se upotrebljava kao filter za FillByID_POTVRDA
            int ID_SMS = 0; // upotrebljava se kao filter za FillByID_SMS

            try
            {

                if (dgSMSzahtevi.SelectedRows.Count > 0)
                {
                    for (int i = 0; i < dgSMSzahtevi.SelectedRows.Count; i++)
                    {

                        // ispis detalja o reklamaciji
                        DataGridViewRow red = dgSMSzahtevi.SelectedRows[i];
                        ID_POTVRDA = Convert.ToInt32(red.Cells["ID_POTVRDA"].Value);
                        ID_SMS = Convert.ToInt32(red.Cells["ID_SMS"].Value);

                        // sadrži vrstu koja se odnosi na trenutno označeni zapis u dgSMSzahtevi, a nalazi se u RKM_POTVRDA
                        drOdabranaPotvrda =
                            PunDS.reklamacijeDS.RKM_POTVRDA.FindByID_POTVRDA(ID_POTVRDA);
                        // sadrži vrstu iz RKM_SMS koja je trenutno označena u dgSMSzahtevi
                        drOdabraniSMS =
                            PunDS.reklamacijeDS.RKM_SMS.FindByID_SMS(ID_SMS);


                        txtDETALJI.Text = " OD:  " + drOdabranaPotvrda["SHPRO"] + 
                            "\n BROJ POTVRDE: " + drOdabranaPotvrda["BROJPOTVRDE"].ToString() +                         
                            "\n ZA: " +  drOdabranaPotvrda["PODNOSIOC"].ToString() + " - " + drOdabraniSMS["BRTELEFONA"].ToString() + 
                            "\n UREĐAJ:  " + drOdabranaPotvrda["UREDJAJ"].ToString() +
                            "\n DATUM PRIJEMA: " + drOdabranaPotvrda["DATREKLAMACIJE"].ToString();
                            
                        
                        // ispis sms poruke u text boxu
                        txtSMS.Text = red.Cells["PORUKA"].Value.ToString();
                    }
                }
               
            }
            catch (Exception)
            {
                MessageBox.Show("Morate odabrati podatak.", "Greška");
                return; ;
            }
        }


        //
        // KREIRA PREGLED PORUKA ZA VERIFIKACIJU I KONAČNO SLANJE
        // dobija parametar iz konstruktora klase kao filter za promenljivu PorukeZaSlanje
        // vraća DataView sa filtriranim podacima
        private DataView PregledSMSzaSlanje(string status)
        {
            string filterStatus =
                String.Format("ODOBRENAPORUKA='{0}'", status);

            DataView SMSzaVRF = new DataView(PunDS.reklamacijeDS.RKM_SMS);
            SMSzaVRF.RowFilter = filterStatus;
            SMSzaVRF.Sort = "VREMESLANJA ASC";
            return SMSzaVRF;
        }
         

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
                noviSMS["ID_POTVRDA"] = _ID_Potvrda;
                noviSMS["SHPRO"] = _SHPRO;
                noviSMS["OPERATER"] = _OPERATER;
                noviSMS["ODOBRENAPORUKA"] = "N";
            }
            catch (Exception xcp)
            {
                MessageBox.Show(xcp.Message, "xcp void DodajNoviSMS");
                return;
            }

            // Update tabele RKM_SMS novim redom noviSMS
            try
            {
                PunDS.reklamacijeDS.RKM_SMS.Rows.Add(noviSMS);
                PunDS.smsTA.Update(PunDS.reklamacijeDS.RKM_SMS);

                MessageBox.Show("Poruka je poslata na obradu.\nSlanje će biti obavljeno uskoro.", "Slanje SMS poruke");
            }
            catch (Exception xcp)
            {
                MessageBox.Show(xcp.Message, "xcp Update void DodajNoviSMS");
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
                //txtMOBTEL.Text = _Mobtel;
            }
        }

        //
        // KONTROLNI DIJALOG ZA UPIS PORUKE U BAZU; poruka ima status OK i čeka na validaciju admina
        private void btnSEND_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSMS.Text))
            {
                MessageBox.Show("Upišite poruku za slanje!\nMaksimalno 160 karaktera.", "Greška - prazna poruka");
                txtSMS.Focus();
                return;
            }

            DialogResult result = MessageBox.Show("Da li želite da pošaljete SMS poruku kupcu?",
                "Slanje SMS poruke", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            switch (result)
            {
                case DialogResult.Yes:
                    DodajNoviSMS();
                    //objclsSMS.ClosePort(port);
                    Close();                    
                    break;
                case DialogResult.No:
                    return;                    
            } 
        }

        //
        // ZATVARANJE FORME
        private void btnIZLAZ_Click(object sender, EventArgs e)
        {
            Close();
        }

        //
        // BROJAČ KARAKTERA U SMS PORUCI
        private void txtSMS_TextChanged(object sender, EventArgs e)
        {
            lblRemChars.Text = (0 + txtSMS.Text.Length).ToString() + " / 160";
        }

        //
        // ENTER I ESC TASTERI
        private void frm_SendSMS_KeyDown(object sender, KeyEventArgs e)
        {
            //Control nextControl;

            //if (e.KeyCode == Keys.Enter)
            //{
            //    nextControl = GetNextControl(ActiveControl, !e.Shift);
            //    if (nextControl == null)
            //    {
            //        nextControl = GetNextControl(null, true);
            //    }
            //    nextControl.Focus();
            //    e.SuppressKeyPress = true;
            //}

            if (e.KeyCode == Keys.Escape)
            {
                objclsSMS.ClosePort(port);
                Close();
            }
        }

        private void dgSMSzahtevi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            OdabraniZapis();
        }


        //
        // PRIKAZ DETALJA REKLAMACIJE
        private void linkDETALJI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDetaljiSMS _frmDetaljiSMS = new frmDetaljiSMS();
            _frmDetaljiSMS.ShowDialog();

        }


        //
        // ADMINISTRATORSKA VERIFIKACIJA SMS-A.
        private void btnADMSEND_Click(object sender, EventArgs e)
        {
            DateTime VremeOdobrenja = DateTime.Now;
            
            try
            {   
                DialogResult result = MessageBox.Show("Potvrdi slanje SMS poruke.", "Slanje SMS-a", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                switch (result)
                {
                    case DialogResult.OK:

                            //.............................................. Send SMS ....................................................
                            try
                            {
                                string _BRTELEFONA = drOdabraniSMS["BRTELEFONA"].ToString();
                                string _PORUKA = drOdabraniSMS["PORUKA"].ToString();

                                if (objclsSMS.sendMsg(port, _BRTELEFONA, _PORUKA))
                                {
                                    drOdabraniSMS["PORUKA"] = txtSMS.Text;
                                    drOdabraniSMS["ODOBRENAPORUKA"] = "Y";
                                    drOdabraniSMS["ODOBRIO"] = formLoginSQL.PodaciOperatera[1];
                                    drOdabraniSMS["VREMEODOBRENJA"] = VremeOdobrenja;
                                
                                    PunDS.smsTA.Update(PunDS.reklamacijeDS.RKM_SMS);
                                    ClearControls(); // brisanje kontrola od prethodnih vrednosti
                                    toolStripStatusLabel1.Text = "Poruka je uspešno poslata";
                                }
                                else
                                {
                                    toolStripStatusLabel1.Text = "Neuspešno slanje poruke";
                                    return;
                                }

                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Greška prilikom slanja poruke", "Send SMS");
                                toolStripStatusLabel1.Text = "";
                                return;
                            }
                            //.............................................. End Send SMS ..................................................
                                                                                      
                        break;

                    case DialogResult.Cancel:
                        return;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Greška u verifikaciji zahteva", "Greška void btnADMSEND_Click");
                return;                
            }
        }
         
        //
        // Ispis šablonskih poruka   
        private void SMSsablon(int brojSablona)
        {            
            switch (brojSablona)
            {
                case 1:
                    string Sablon1 = "sablon_1_text";
                    txtSMS.Text = Sablon1;
                    break;

                case 2:
                    string Sablon2 = "sablon_2_text";
                    txtSMS.Text = Sablon2;
                    break;

                case 3:
                    string Sablon3 = "sablon_3_text";
                    txtSMS.Text = Sablon3;
                    break;
            } 
        }



        //
        // briše sadržaj pojedinih kontrola nakon uspešnog slanja poruke
        private void ClearControls()
        {
            txtDETALJI.Text = "";
            txtSMS.Text = "";
            toolStripStatusLabel1.Text = "";
        }

        //
        // BRISANJE ODABRANOG ZAPISA
        private void btnADMDELETE_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Odabrana SMS poruka će biti trajno obrisana.\nDa li želite da nastavite sa operacijom?",
                    "Trajno brisanje SMS-a", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                switch (result)
                {
                    case DialogResult.OK:
                        drOdabraniSMS.Delete();
                        PunDS.smsTA.Update(PunDS.reklamacijeDS.RKM_SMS);
                        MessageBox.Show("Poruka je uspešno obrisana.", "Brisanje SMS poruke");
                        ClearControls();                                                                       
                        break;
                    case DialogResult.Cancel:
                        break;

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Greška btnADMDELETE_Click", "Greška!");
                return;
            }
        }

        //
        // POVEZIVANJE SA GPRS MODEMOM
        private void btnOK_Click(object sender, EventArgs e)
        {
            int BaudRate = Properties.Settings.Default.BaudRate;
            int DataBits = Properties.Settings.Default.DataBits;
            int ReadTimeOut = Properties.Settings.Default.ReadTimeOut;
            int WriteTimeOut = Properties.Settings.Default.WriteTimeOut;

            try
            {
                //Open communication port 
                port = objclsSMS.OpenPort(this.cboPortName.Text, BaudRate, DataBits, ReadTimeOut, WriteTimeOut);

                if (port != null)
                {
                    cboPortName.Enabled = false;

                    toolStripStatusLabel1.Text = "Modem je povezan na PORT " + cboPortName.Text;
                    
                    lblConnectionStatus.Text = "POVEZAN NA " + this.cboPortName.Text;
                    btnDisconnect.Enabled = true;

                    // kontrole koje se uključuju posle povezivanja gprs modema
                    dgSMSzahtevi.Visible = true;
                    btnADMSEND.Visible = true;
                    btnADMDELETE.Visible = true;
                    txtDETALJI.Visible = true;
                    
                    linkDETALJI.Visible = true;
                    panel1.Visible = true;
                    btnOK.Enabled = false;

                }

                else
                {
                    toolStripStatusLabel1.Text = "COM Port nije podešen";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Greška prilikom povezivanja sa GPRS modemom.\nProverite da li je modem uključen i da li postoji veza sa računarom!",
                    "xcp void btnOK_Click (Connect)");
                return;
            }
        }

        //
        // PREKIDANJE VEZE SA GPRS MODEMOM
        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                cboPortName.Enabled = true;
                objclsSMS.ClosePort(port);

                lblConnectionStatus.Text = "NIJE POVEZAN";
                toolStripStatusLabel1.Text = "GPRS modem NIJE POVEZAN!";
                btnDisconnect.Enabled = false;
                btnOK.Enabled = true;

            }
            catch (Exception)
            {
                MessageBox.Show("Greška prilikom prekidanja veze sa GPRS modemom", "xcp void btnDisconnect_Click");
                return;
            }
        }

        private void frm_SendSMS_FormClosed(object sender, FormClosedEventArgs e)
        {
            objclsSMS.ClosePort(port);
        }

        private void linkSablon1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SMSsablon(1);
        }

        private void linkSablon2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SMSsablon(2);
        }

        private void linkSablon3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SMSsablon(3);
        }
    }
}
