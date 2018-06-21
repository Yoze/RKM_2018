using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using RKM.ReklamacijeDSTableAdapters;
using System.Data.SqlTypes;


namespace RKM
{
    public partial class frmEditovanje : Form
    {
  
        public static int _idPotvrde; // ID_POTVRDE
        public static string brPotvrde { get; set; } // broj potvrde
        public static int idZahteva; // ID zahteva radi ispisa na potvrdi
        private static ReklamacijeDS.RKM_POTVRDARow _izabraniRed; // red za izmenu iz tabele rkm_potvrda
        public static int _indeksOdabranogZapisa; // indeks odabranog reda iz datagridview kontrole
        public bool isDirty = false; // flag za promene vrednosti u kontrolama


     
        private void frmEditovanje_Load(object sender, EventArgs e)
        {

            // This is a handy trick to prevent implicit validation of our controls when they lose focus.
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;

            ToolTip tooltip = new ToolTip();

            tooltip.UseAnimation = true;
            tooltip.IsBalloon = true;
            tooltip.SetToolTip(this.btnResetServiser, "Poništava trenutno izabranog servisera!\nNe briše ga iz baze.");
            tooltip.SetToolTip(this.textUREDJAJ, "Duplim klikom aktivirajte izbor uređaja.");

            // komandna dugmad sa leve strane
            //tooltip.SetToolTip(this.btnStampajOdluku, "Dugme će biti aktivno nakon snimanja podataka!\nPritisnite dugme 'Snimi izmene'.");
            //tooltip.SetToolTip(this.btnStampajPotvrdu, "Dugme će biti aktivno nakon snimanja podataka!\nPritisnite dugme 'Snimi izmene'.");

            // promene vrednosti u kontrolama na formi menjaju vrednsot flag-a isDirty
            // i upozoravaju na potrebu snimanja izmenjenih podataka
            textBROJPOTVRDE.TextChanged += new EventHandler(DirtyTextChange);
            textPODNOSIOC.TextChanged += new EventHandler(DirtyTextChange);
            textADRESA.TextChanged += new EventHandler(DirtyTextChange);
            textMESTO.TextChanged += new EventHandler(DirtyTextChange);
            textTELEFON.TextChanged += new EventHandler(DirtyTextChange);
            txtMOBTEL.TextChanged += new EventHandler(DirtyTextChange);
            comboSTATUS.TextChanged += new EventHandler(DirtyTextChange);
            textUREDJAJ.TextChanged += new EventHandler(DirtyTextChange);
            textSN.TextChanged += new EventHandler(DirtyTextChange);
            dateDATUMRKM.TextChanged += new EventHandler(DirtyTextChange);
            dateDATPRODAJE.TextChanged += new EventHandler(DirtyTextChange);
            textBROJFI.TextChanged += new EventHandler(DirtyTextChange);
            dateDATUMRESAVANJA.TextChanged += new EventHandler(DirtyTextChange);
            comboZAHTEV.TextChanged += new EventHandler(DirtyTextChange);
            textUGOVORENIROK.TextChanged += new EventHandler(DirtyTextChange);
            textPRODUZROKA.TextChanged += new EventHandler(DirtyTextChange);
            dateDATUMODLUKE.TextChanged += new EventHandler(DirtyTextChange);
            datePOSLATSO.TextChanged += new EventHandler(DirtyTextChange);
            txtBROJREZ.TextChanged += new EventHandler(DirtyTextChange);
            textOPISREKLAMACIJE.TextChanged += new EventHandler(DirtyTextChange);
            textNACINRESAVANJA.TextChanged += new EventHandler(DirtyTextChange);
            textPRIMEDBAPRODAVCA.TextChanged += new EventHandler(DirtyTextChange);
            textODLUKA.TextChanged += new EventHandler(DirtyTextChange);
            textBELESKE.TextChanged += new EventHandler(DirtyTextChange);
            dateDATUMSERVIS.TextChanged += new EventHandler(DirtyTextChange);
            txtSERVISMISLJENJE.TextChanged += new EventHandler(DirtyTextChange);
            txtNAZIVSERVISERA.TextChanged += new EventHandler(DirtyTextChange);
        }

               
        // flag za označavanje promene u kontrolama
        void DirtyTextChange (object sender, EventArgs e)
        {
            isDirty = true;
            btnSnimi.ForeColor = Color.Red;
            btnSnimi.Text = "Snimi izmene !";
            //btnSnimi.Font = new Font("Segoe UI", 12, FontStyle.Bold);
        }


        // D O D A V A N J E   N O V O G   Z A P I S A
        public frmEditovanje()
        {    
            InitializeComponent();

            //// This is a handy trick to prevent implicit validation of our controls when they lose focus.
            //this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;

            this.Text = "Evidencija nove reklamacije";
            puniComboBoxove();
            btnDodajNovi.Visible = true;

            // default vrednosti prilikom unosa nove rkm. popuna kontrola podacima korisnika i PM
            textBROJPOTVRDE.Text = brojPotvrde();

            textPMPRIJEMA.Text =
                formLoginSQL.PodaciProdajnogMesta[2] + ", " + formLoginSQL.PodaciProdajnogMesta[1] + ", " + formLoginSQL.PodaciProdajnogMesta[3];
            textSHPRO.Text =
                formLoginSQL.PodaciOperatera[0];
            textPRIMIO.Text =
                formLoginSQL.PodaciOperatera[1];
            textODLUKA.Text =
                "Uređaj će biti poslat u ovlašćeni servis radi utvrđivanja postojanja nesaobraznosti. " + 
                "U slučaju da postoji nesaobraznost, ista će biti otklonjena u zakonskom roku.";

            promenaIDservisera(28);            
        }

        
        // Upisuje vrednosti odabranog reda u SelectedRow. Potrebno je radi mogućnosti snimanja izmena nakon prvog unosa zapisa o reklamaciji
        private ReklamacijeDS.RKM_POTVRDARow IzabraniRed(int IDPotvrde)
        {
            ReklamacijeDS.RKM_POTVRDARow SelectedRow =
                PunDS.reklamacijeDS.RKM_POTVRDA.FindByID_POTVRDA(IDPotvrde);
            return SelectedRow;
        }


        // I Z M E N A   P O D A T A K A - učitava vrednosti polja u kontrole forme radi izmene podataka
        public frmEditovanje(int idPotvrde, int indeksOdabranogZapisa)
        { 
            InitializeComponent();
            
            //// This is a handy trick to prevent implicit validation of our controls when they lose focus.
            //this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;

            Text = "Izmena podataka evidentirane reklamacije";
           // btnSMS.Enabled = true;
            puniComboBoxove();
            btnSnimi.Visible = true;            

            // id potvrde i indeks zapisa prosleđeni iz pozivajuće metode
            _idPotvrde = idPotvrde;
            _indeksOdabranogZapisa = indeksOdabranogZapisa;

            try
            {
                // izdvaja red na osnovu id-a zapisa
                //ReklamacijeDS.RKM_POTVRDARow izabraniRed =
                //   PunDS.reklamacijeDS.RKM_POTVRDA.FindByID_POTVRDA(idPotvrde);

                // kopira sadržaj u polje vidjlivo metodama klase
                //_izabraniRed = izabraniRed;
                _izabraniRed = IzabraniRed(idPotvrde);
                brPotvrde = _izabraniRed.BROJPOTVRDE;                
                                    
                                
                // ispisuje sadržaj polja u kontrole
                textID_POTVRDA.Text = _izabraniRed.ID_POTVRDA.ToString();
                textSHPRO.Text = _izabraniRed.SHPRO;
                textPMPRIJEMA.Text = _izabraniRed.PMPRIJEMA;
                textPRIMIO.Text = _izabraniRed.PRIMIO;
                textBROJPOTVRDE.Text = _izabraniRed.BROJPOTVRDE;
                textPODNOSIOC.Text = _izabraniRed.PODNOSIOC;
                textADRESA.Text = _izabraniRed.ADRESA;
                textMESTO.Text = _izabraniRed.MESTO;
                textTELEFON.Text = _izabraniRed.TELEFON;
                txtMOBTEL.Text = _izabraniRed.MOBTEL;
                textUREDJAJ.Text = _izabraniRed.UREDJAJ;
                textSN.Text = _izabraniRed.SN;
                textBROJFI.Text = _izabraniRed.BROJFI;
                textOPISREKLAMACIJE.Text = _izabraniRed.OPISREKLAMACIJE;
                textPRIMEDBAPRODAVCA.Text = _izabraniRed.PRIMEDBAPRODAVCA;
                textUGOVORENIROK.Text = _izabraniRed.UGOVORENIROK;
                textNACINRESAVANJA.Text = _izabraniRed.NACINRESAVANJA;
                textPRODUZROKA.Text = _izabraniRed.PRODUZROKA;
                textBELESKE.Text = _izabraniRed.BELESKE;
                textODLUKA.Text = _izabraniRed.ODLUKA;
                txtSERVISMISLJENJE.Text = _izabraniRed.SERVISMISLJENJE;
                txtBROJREZ.Text = _izabraniRed.BROJREZERVACIJE;
                comboZAHTEV.SelectedValue =_izabraniRed.ID_ZAHTEV;
                comboSTATUS.SelectedValue =_izabraniRed.ID_STATUS;
                txtID_SERVISERA.Text = _izabraniRed.ID_SERVISER.ToString();


                promenaIDservisera(Convert.ToInt32(txtID_SERVISERA.Text));
                
                // D A T U M I
                dateDATUMRKM.Value = _izabraniRed.DATREKLAMACIJE;
                dateDATPRODAJE.Value = _izabraniRed.DATPRODAJE;
                datePOSLATSO.Value = _izabraniRed.DATUMSOMBOR;
                dateDATUMRESAVANJA.Value = _izabraniRed.DATUMRESAVANJA;
                dateDATUMSERVIS.Value = _izabraniRed.SERVISDATUM;
                dateDATUMODLUKE.Value = _izabraniRed.DATUMODLUKE;


            }
            catch (Exception xcp)
            {
                MessageBox.Show(xcp.Message, "xcp btnIzmeni_Click");
            }
        }


        // S N I M A N J E   I Z M E N A   P O D A T A K A - upisuje vrednosti kontrola forme u polja tabele RKM_POTVRDA
        private void snimanjePodataka()
        {
            // upisuje sadržaj kontrola u polja izabranog reda
            _izabraniRed.PMPRIJEMA = textPMPRIJEMA.Text;
            _izabraniRed.SHPRO = textSHPRO.Text;
            _izabraniRed.PRIMIO = textPRIMIO.Text;
            _izabraniRed.BROJPOTVRDE = textBROJPOTVRDE.Text;
            _izabraniRed.PODNOSIOC = textPODNOSIOC.Text;
            _izabraniRed.ADRESA = textADRESA.Text;
            _izabraniRed.MESTO = textMESTO.Text;
            _izabraniRed.TELEFON = textTELEFON.Text;
            _izabraniRed.MOBTEL = txtMOBTEL.Text;
            _izabraniRed.UREDJAJ = textUREDJAJ.Text;
            _izabraniRed.SN = textSN.Text;
            _izabraniRed.BROJFI = textBROJFI.Text;
            _izabraniRed.OPISREKLAMACIJE = textOPISREKLAMACIJE.Text;
            _izabraniRed.PRIMEDBAPRODAVCA = textPRIMEDBAPRODAVCA.Text;
            _izabraniRed.UGOVORENIROK = textUGOVORENIROK.Text;
            _izabraniRed.NACINRESAVANJA = textNACINRESAVANJA.Text;
            _izabraniRed.PRODUZROKA = textPRODUZROKA.Text;
            _izabraniRed.BELESKE = textBELESKE.Text;
            _izabraniRed.ODLUKA = textODLUKA.Text;
            _izabraniRed.SERVISMISLJENJE = txtSERVISMISLJENJE.Text;
            _izabraniRed.BROJREZERVACIJE = txtBROJREZ.Text;
            _izabraniRed.ID_ZAHTEV = (int)comboZAHTEV.SelectedValue;
            _izabraniRed.ID_STATUS = (int)comboSTATUS.SelectedValue;
            _izabraniRed.is_deleted = 0;
            
            // S E R V I S E R
            _izabraniRed.ID_SERVISER = Convert.ToInt32(txtID_SERVISERA.Text);
       

            // D A T U M I
            _izabraniRed.DATREKLAMACIJE = dateDATUMRKM.Value;
            _izabraniRed.DATPRODAJE = dateDATPRODAJE.Value;
            _izabraniRed.DATUMSOMBOR = datePOSLATSO.Value;
            _izabraniRed.DATUMRESAVANJA = dateDATUMRESAVANJA.Value;
            _izabraniRed.SERVISDATUM = dateDATUMSERVIS.Value;
            _izabraniRed.DATUMODLUKE = dateDATUMODLUKE.Value;
            
            try
            {
                if (string.IsNullOrEmpty(textUREDJAJ.Text))
                {
                    do
                    {
                        MessageBox.Show("Polje <Uređaj> mora biti popunjeno", "Obavezan podatak");
                        textUREDJAJ.Focus();
                    } while (!(string.IsNullOrEmpty(textUREDJAJ.Text)));
                }
                

                PunDS.potvrdaTA.Update(PunDS.reklamacijeDS.RKM_POTVRDA);

                brPotvrde = _izabraniRed.BROJPOTVRDE;
                
                MessageBox.Show("Podaci su uspešno snimljeni", "Snimanje podataka");
                idZahteva = (int)comboZAHTEV.SelectedValue;
                btnStampajPotvrdu.Enabled = true;
                btnStampajOdluku.Enabled = true;

                // btn snimi - povratak na podrazumevane vrednosti fonta
                btnSnimi.ForeColor = Color.Black;
                //btnSnimi.Font = new Font("Segoe UI", 12, FontStyle.Regular);
                btnSnimi.Text = "Snimi";
                isDirty = false;

            }
            catch (Exception excp)
            {
                MessageBox.Show(excp.Message, "xcp btnSnimi");
                return;
            } 
        }
  

        // UPIS NOVOG ZAPISA !!!
        private void btnDodajNovi_Click(object sender, EventArgs e)
        {
            ReklamacijeDS.RKM_POTVRDARow novaVrsta =
                (ReklamacijeDS.RKM_POTVRDARow)PunDS.reklamacijeDS.RKM_POTVRDA.NewRow();

            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                novaVrsta["PMPRIJEMA"] =
                   formLoginSQL.PodaciProdajnogMesta[2] + ", "
                       + formLoginSQL.PodaciProdajnogMesta[1] + ", "
                       + formLoginSQL.PodaciProdajnogMesta[3];
                novaVrsta["SHPRO"] =
                    formLoginSQL.PodaciOperatera[0];
                novaVrsta["PRIMIO"] =
                    formLoginSQL.PodaciOperatera[1];

                //novaVrsta["BROJPOTVRDE"] = textBROJPOTVRDE.Text;
                novaVrsta["BROJPOTVRDE"] = textBROJPOTVRDE.Text;

                novaVrsta["PODNOSIOC"] = textPODNOSIOC.Text;
                novaVrsta["ADRESA"] = textADRESA.Text;
                novaVrsta["MESTO"] = textMESTO.Text;
                novaVrsta["TELEFON"] = textTELEFON.Text;
                novaVrsta["MOBTEL"] = txtMOBTEL.Text;
                novaVrsta["UREDJAJ"] = textUREDJAJ.Text;
                novaVrsta["SN"] = textSN.Text;
                novaVrsta["BROJFI"] = textBROJFI.Text;
                novaVrsta["OPISREKLAMACIJE"] = textOPISREKLAMACIJE.Text;
                novaVrsta["PRIMEDBAPRODAVCA"] = textPRIMEDBAPRODAVCA.Text;
                novaVrsta["UGOVORENIROK"] = textUGOVORENIROK.Text;
                novaVrsta["NACINRESAVANJA"] = textNACINRESAVANJA.Text;
                novaVrsta["PRODUZROKA"] = textPRODUZROKA.Text;
                novaVrsta["BELESKE"] = textBELESKE.Text;
                novaVrsta["ODLUKA"] = textODLUKA.Text;
                novaVrsta["SERVISMISLJENJE"] = txtSERVISMISLJENJE.Text;
                novaVrsta["BROJREZERVACIJE"] = txtBROJREZ.Text;
                novaVrsta["ID_ZAHTEV"] = comboZAHTEV.SelectedValue;
                novaVrsta["ID_STATUS"] = comboSTATUS.SelectedValue;

                novaVrsta["ID_POTVRDA"] = -1;
                novaVrsta["is_deleted"] = 0;

                // S E R V I S E R 
                novaVrsta["ID_SERVISER"] = Convert.ToInt32(txtID_SERVISERA.Text);

                // D A T U M I
                novaVrsta["DATREKLAMACIJE"] = dateDATUMRKM.Value;
                novaVrsta["DATPRODAJE"] = dateDATPRODAJE.Value;
                novaVrsta["DATUMSOMBOR"] = datePOSLATSO.Value;
                novaVrsta["DATUMRESAVANJA"] = dateDATUMRESAVANJA.Value;
                novaVrsta["SERVISDATUM"] = dateDATUMSERVIS.Value;
                novaVrsta["DATUMODLUKE"] = dateDATUMODLUKE.Value;

                try
                {
                    // dodaje novu vrstu u tabelu rkm_potvrda i update-uje bazu
                    PunDS.reklamacijeDS.RKM_POTVRDA.Rows.Add(novaVrsta);

                    PunDS.potvrdaTA.Update(PunDS.reklamacijeDS.RKM_POTVRDA);
                    isDirty = false;

                    brPotvrde = novaVrsta.BROJPOTVRDE;
                    idZahteva = novaVrsta.ID_ZAHTEV;

                    MessageBox.Show("Podaci su uspešno snimljeni u tabelu");
                    btnStampajPotvrdu.Enabled = true;
                    btnDodajNovi.Visible = false;
                    btnStampajOdluku.Enabled = true;
                    btnSnimi.Visible = false;


                }
                catch (Exception xcp2)
                {
                    MessageBox.Show(xcp2.Message, "Neuspešno dodavanje novog zapisa!\r\nMolim Vas da kontaktirate tehničku podršku.\r\n\r\nErr: " + xcp2.Message);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Morate popuniti obeležena polja.", "Greška kod unosa");
            }

        }


        // B U T T O N   S N I M I      
        private void btnSnimi_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                snimanjePodataka();
                isDirty = false;
            }
            else
            {
                MessageBox.Show("Morate popuniti obeležena polja.", "Greška kod unosa");
            }
           
        }


        // P U N J E N J E   C O M B O B O X - O V A  
        private void puniComboBoxove()
        {
            // puni combo boxove 
            DataView dvZahtev = new DataView(PunDS.reklamacijeDS.RKM_ZAHTEV);
            comboZAHTEV.DataSource = dvZahtev;
            comboZAHTEV.DisplayMember = "ZAHTEV";
            comboZAHTEV.ValueMember = "ID_ZAHTEV";

            DataView dvStatus = new DataView(PunDS.reklamacijeDS.RKM_STATUS);
            comboSTATUS.DataSource = dvStatus;
            comboSTATUS.DisplayMember = "STATUS";
            comboSTATUS.ValueMember = "ID_STATUS";
            
        }


        // B U T T O N   O D U S T A N I
        private void btnOdustani_Click(object sender, EventArgs e)
        {
           switch (isDirty)
            {
                case true:
                  DialogResult result =
                    MessageBox.Show("Podaci su izmenjeni!\nDa li želite da snimite promene?", "Snimanje promena", 
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    switch (result)
                    {
                        case DialogResult.Yes:
                            if (ValidateChildren(ValidationConstraints.Enabled))
                            {
                                snimanjePodataka();
                                Close();
                            }
                            else
                            {
                                MessageBox.Show("Morate popuniti obeležena polja.", "Greška kod unosa");
                            }                          
                            break;
                        case DialogResult.No:
                            Close();
                            break;                        
                    }
                    break;

                case false:
                    Close();
                    break;
            }      
        }


        // K R E I R A   B R O J   P O T V R D E -> max id zapisa + 1 / tekuća godina
        private string brojPotvrde()
        {
            string godina = DateTime.Now.Year.ToString();
            string mesec = DateTime.Now.Month.ToString("D2");
            string dan = DateTime.Now.Day.ToString("D2");

            string sat = DateTime.Now.Hour.ToString("D2");
            string min = DateTime.Now.Minute.ToString("D2");

            // shpro
            string prodMesto = formLoginSQL.PodaciProdajnogMesta[0];

            string brPotvrde = godina + mesec + dan + "-" + sat + min + "/" + prodMesto;
   
            return brPotvrde;                                   
        }


        ////
        //// P R O V E R A   O B A V E Z N I H   P O L J A - O N   L E A V E   E V E N T

        //#region
        //private void textPODNOSIOC_Leave(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrEmpty(textPODNOSIOC.Text))
        //    {
        //        MessageBox.Show("Polje <Podnosioc> mora biti popunjeno", "Obavezan podatak");
        //        textPODNOSIOC.Focus();
        //        //return;
        //    }
        //}
        //private void textADRESA_Leave(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrEmpty(textADRESA.Text))
        //    {
        //        MessageBox.Show("Polje <Adresa> mora biti popunjeno", "Obavezan podatak");
        //        textADRESA.Focus();
        //        //return;
        //    }
        //}
        //private void textMESTO_Leave(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrEmpty(textMESTO.Text))
        //    {
        //        MessageBox.Show("Polje <Mesto> mora biti popunjeno", "Obavezan podatak");
        //        textMESTO.Focus();
        //        //return;
        //    }
        //}
        //private void textTELEFON_Leave(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrEmpty(textTELEFON.Text))
        //    {
        //        MessageBox.Show("Polje <Telefon> mora biti popunjeno", "Obavezan podatak");
        //        textTELEFON.Focus();
        //        //return;
        //    }
        //}
        //private void textUREDJAJ_Leave(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrEmpty(textUREDJAJ.Text))
        //    {
        //        MessageBox.Show("Polje <Uređaj> mora biti popunjeno", "Obavezan podatak");
        //        izaberiUredjaj();

        //        //return;
        //    }
        //}
        //private void textSN_Leave(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrEmpty(textSN.Text))
        //    {
        //        MessageBox.Show("Polje <SN> mora biti popunjeno", "Obavezan podatak");
        //        textSN.Focus();
        //        //return;
        //    }
        //}
        //private void textBROJFI_Leave(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrEmpty(textBROJFI.Text))
        //    {
        //        MessageBox.Show("Polje <FI> mora biti popunjeno", "Obavezan podatak");
        //        textBROJFI.Focus();
        //        //return;
        //    }
        //}
        //private void textBROJPOTVRDE_Leave(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrEmpty(textBROJPOTVRDE.Text))
        //    {
        //        MessageBox.Show("Polje <Broj potvrde> mora biti popunjeno", "Obavezan podatak");
        //        textBROJPOTVRDE.Focus();
        //        //return;
        //    }
        //}
        //private void textOPISREKLAMACIJE_Leave(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrEmpty(textOPISREKLAMACIJE.Text))
        //    {
        //        MessageBox.Show("Polje <opis reklamacije> mora biti popunjeno", "Obavezan podatak");
        //        textOPISREKLAMACIJE.Focus();
        //        //return;
        //    }
        //}
        //#endregion
        //        //
        //        // P R O V E R A   O B A V E Z N I H   P O L J A - Z A J E D N O 
        //#region
        //        private void proveriPraznaPolja()
        //        {
        //            if (string.IsNullOrEmpty(textPODNOSIOC.Text))
        //            {
        //                do
        //                {
        //                    MessageBox.Show("Polje <Podnosioc> mora biti popunjeno", "Obavezan podatak");                    
        //                    textPODNOSIOC.Focus();
        //                } while (!(string.IsNullOrEmpty(textPODNOSIOC.Text)));                
        //            }

        //            if (string.IsNullOrEmpty(textADRESA.Text))
        //            {
        //                do
        //                {
        //                    MessageBox.Show("Polje <Adresa> mora biti popunjeno", "Obavezan podatak");                    
        //                    textADRESA.Focus();
        //                } while (!(string.IsNullOrEmpty(textADRESA.Text)));
        //            }


        //            if (string.IsNullOrEmpty(textMESTO.Text))
        //            {
        //                do
        //                {
        //                    MessageBox.Show("Polje <Mesto> mora biti popunjeno", "Obavezan podatak");
        //                    textMESTO.Focus();
        //                } while (!((string.IsNullOrEmpty(textMESTO.Text))));
        //            }

        //            if (string.IsNullOrEmpty(textTELEFON.Text))
        //            {
        //                do
        //	            {
        //	                MessageBox.Show("Polje <Telefon> mora biti popunjeno", "Obavezan podatak");
        //                    textTELEFON.Focus();
        //	            } while (!((string.IsNullOrEmpty(textTELEFON.Text))));  
        //            }                

        //            if (string.IsNullOrEmpty(textUREDJAJ.Text))
        //            {
        //                do
        //                {
        //                    MessageBox.Show("Polje <Uređaj> mora biti popunjeno", "Obavezan podatak");
        //                    textUREDJAJ.Focus();
        //                } while (!((string.IsNullOrEmpty(textUREDJAJ.Text))));
        //	        }

        //            if (string.IsNullOrEmpty(textSN.Text))
        //            {
        //                do
        //                {
        //                    MessageBox.Show("Polje <SN> mora biti popunjeno", "Obavezan podatak");
        //                    textSN.Focus();
        //                } while (!(string.IsNullOrEmpty(textSN.Text)));
        //            }


        //            if (string.IsNullOrEmpty(textBROJFI.Text))
        //            {
        //                do
        //                {                
        //                    MessageBox.Show("Polje <FI> mora biti popunjeno", "Obavezan podatak");
        //                    textBROJFI.Focus();
        //                } while (!(string.IsNullOrEmpty(textBROJFI.Text)));
        //            }
        //            if (string.IsNullOrEmpty(textOPISREKLAMACIJE.Text))
        //            {
        //                do
        //                {
        //                    MessageBox.Show("Polje <opis reklamacije> mora biti popunjeno", "Obavezan podatak");
        //                    textOPISREKLAMACIJE.Focus();
        //                } while (!(string.IsNullOrEmpty(textOPISREKLAMACIJE.Text)));
        //            }
        //        }
        //#endregion
        //
        // prelazak na iduću kontrolu pomoću <enter>


        private void frmEditovanje_KeyDown(object sender, KeyEventArgs e)
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

        //
        // TXT UREĐAJ
        private void textUREDJAJ_DoubleClick(object sender, EventArgs e)
        {
            izaberiUredjaj();
        }

        //
        // O T V A R A   F O R M U   Z A   I Z B O R   U R E Đ A J A
        private void izaberiUredjaj()
        {
            artikli _artikli = new artikli();
            _artikli.ShowDialog();

            if (!(string.IsNullOrEmpty(artikli._red) == true)) // sprečava brisanje već upisanog uređaja ako se zatvori prozor uređaji
            {
                textUREDJAJ.Text = artikli._red;
            }
        }

        //
        // Š T A M P A   P O T V R D E
        private void btnStampajPotvrdu_Click(object sender, EventArgs e)
        {
            frm_Print _frm_Print = new frm_Print();           
            _frm_Print.ShowDialog();
        }

        //
        // Š T A M P A   O D L U K E
        private void btnStampajOdluku_Click(object sender, EventArgs e)
        {
            frm_PrintOdluka _frm_PrintOdluka = new frm_PrintOdluka();
            _frm_PrintOdluka.ShowDialog();
        }

        //
        // B U T T O N  S E R V I S E R
        private void btnIzaberiServisera_Click(object sender, EventArgs e)
        {
                            
                frm_ServiseriLista _frmServiseriLista = new frm_ServiseriLista();
                _frmServiseriLista.ShowDialog();

                promenaIDservisera(frm_ServiseriLista.odabraniServiserID);                    
            
        }
        

        private void btnResetServiser_Click(object sender, EventArgs e)
        {
                promenaIDservisera(28);
        }


        private void promenaIDservisera(int idservisera)
        {
            // argument metode se koristi kao filter u FindByIDServiser za tabelu RKM_SERVISER
            try
            {   
                ReklamacijeDS.RKM_SERVISERRow serviserByID =
                PunDS.reklamacijeDS.RKM_SERVISER.FindByID_SERVISER(idservisera);

                txtNAZIVSERVISERA.Text = Convert.ToString(serviserByID.NAZIV);
                txtSERVISTEL.Text = Convert.ToString(serviserByID.TELEFON);
                txtSKontakt.Text = Convert.ToString(serviserByID.KONTAKT);
                txtID_SERVISERA.Text = idservisera.ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Greška void promenaIDservisera!", "Greška");
                return;
            }

        }


        // VALIDACIJA KONTROLA
        private void textBROJPOTVRDE_Validating(object sender, CancelEventArgs e)
        {
            bool cancel = false;

            if (!(string.IsNullOrWhiteSpace(textBROJPOTVRDE.Text)))
            {
                cancel = false;
            }
            else
            {
                cancel = true;
                errProvider.SetError(textBROJPOTVRDE, "Obavezan podatak.");
            }
            e.Cancel = cancel;
        }

        private void textBROJPOTVRDE_Validated(object sender, EventArgs e)
        {
            errProvider.SetError(textBROJPOTVRDE, string.Empty);
        }

        private void textPODNOSIOC_Validating(object sender, CancelEventArgs e)
        {
            bool cancel = false;

            if (!(string.IsNullOrWhiteSpace(textPODNOSIOC.Text)))
            {
                cancel = false;
            }
            else
            {
                cancel = true;
                errProvider.SetError(textPODNOSIOC, "Obavezan podatak.");
            }
            e.Cancel = cancel;
        }

        private void textPODNOSIOC_Validated(object sender, EventArgs e)
        {
            errProvider.SetError(textPODNOSIOC, string.Empty);
        }

        private void textADRESA_Validating(object sender, CancelEventArgs e)
        {
            bool cancel = false;

            if (!(string.IsNullOrWhiteSpace(textADRESA.Text)))
            {
                cancel = false;
            }
            else
            {
                cancel = true;
                errProvider.SetError(textADRESA, "Obavezan podatak.");
            }
            e.Cancel = cancel;
        }

        private void textADRESA_Validated(object sender, EventArgs e)
        {
            errProvider.SetError(textADRESA, string.Empty);
        }

        private void textMESTO_Validating(object sender, CancelEventArgs e)
        {
            bool cancel = false;

            if (!(string.IsNullOrWhiteSpace(textMESTO.Text)))
            {
                cancel = false;
            }
            else
            {
                cancel = true;
                errProvider.SetError(textMESTO, "Obavezan podatak.");
            }
            e.Cancel = cancel;
        }

        private void textMESTO_Validated(object sender, EventArgs e)
        {
            errProvider.SetError(textMESTO, string.Empty);
        }

        private void textTELEFON_Validating(object sender, CancelEventArgs e)
        {
            bool cancel = false;

            if (!(string.IsNullOrWhiteSpace(textTELEFON.Text)))
            {
                cancel = false;
            }
            else
            {
                cancel = true;
                errProvider.SetError(textTELEFON, "Obavezan podatak.");
            }
            e.Cancel = cancel;
        }

        private void textTELEFON_Validated(object sender, EventArgs e)
        {
            errProvider.SetError(textTELEFON, string.Empty);
        }

        private void textUREDJAJ_Validating(object sender, CancelEventArgs e)
        {
            bool cancel = false;

            if (!(string.IsNullOrWhiteSpace(textUREDJAJ.Text)))
            {
                cancel = false;
            }
            else
            {
                cancel = true;
                errProvider.SetError(textUREDJAJ, "Obavezan podatak.");
            }
            e.Cancel = cancel;
        }

        private void textUREDJAJ_Validated(object sender, EventArgs e)
        {
            errProvider.SetError(textUREDJAJ, string.Empty);
        }

        private void textSN_Validating(object sender, CancelEventArgs e)
        {
            bool cancel = false;

            if (!(string.IsNullOrWhiteSpace(textSN.Text)))
            {
                cancel = false;
            }
            else
            {
                cancel = true;
                errProvider.SetError(textSN, "Obavezan podatak.");
            }
            e.Cancel = cancel;
        }

        private void textSN_Validated(object sender, EventArgs e)
        {
            errProvider.SetError(textSN, string.Empty);
        }

        private void textBROJFI_Validating(object sender, CancelEventArgs e)
        {
            bool cancel = false;

            if (!(string.IsNullOrWhiteSpace(textBROJFI.Text)))
            {
                cancel = false;
            }
            else
            {
                cancel = true;
                errProvider.SetError(textBROJFI, "Obavezan podatak.");
            }
            e.Cancel = cancel;
        }

        private void textBROJFI_Validated(object sender, EventArgs e)
        {
            errProvider.SetError(textBROJFI, string.Empty);
        }

        private void textOPISREKLAMACIJE_Validating(object sender, CancelEventArgs e)
        {
            bool cancel = false;

            if (!(string.IsNullOrWhiteSpace(textOPISREKLAMACIJE.Text)))
            {
                cancel = false;
            }
            else
            {
                cancel = true;
                errProvider.SetError(textOPISREKLAMACIJE, "Obavezan podatak.");
            }
            e.Cancel = cancel;
        }

        private void textOPISREKLAMACIJE_Validated(object sender, EventArgs e)
        {
            errProvider.SetError(textOPISREKLAMACIJE, string.Empty);
        }









        //// S L A N J E    S M S - a
        //private void btnSMS_Click(object sender, EventArgs e)
        //{
        //    //forma za slanje SMS obaveštenja kupcu
        //    try
        //    {
        //        if (!string.IsNullOrEmpty(txtMOBTEL.Text))
        //        {
        //            frm_SendSMS _frm_SendSMS = new frm_SendSMS(txtMOBTEL.Text, _idPotvrde, formLoginSQL.PodaciOperatera[0], formLoginSQL.PodaciOperatera[1]);
        //            _frm_SendSMS.ShowDialog();
        //            //snimanjePodataka();
        //        }
        //        if (string.IsNullOrEmpty(txtMOBTEL.Text))
        //        {
        //            MessageBox.Show("Morate upisati broj mobilnog telefona\nza prijem SMS poruke!", "Nedostaje broj telefona");
        //            txtMOBTEL.Focus();
        //        }
        //    }
        //    catch (StrongTypingException xcp)
        //    {
        //        MessageBox.Show("void btnSMS_Click\n" + xcp.Message, "Greška - void btnSMS !");
        //        return;
        //    }
        //}






    }
}
 