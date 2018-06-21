using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using RKM.ReklamacijeDSTableAdapters;
using System.Windows.Forms;


namespace RKM
{
    class PunDS
    {
        public static ReklamacijeDS reklamacijeDS = new ReklamacijeDS();
        //public static ReklamacijeDS.RKM_POTVRDADataTable RKM_POTVRDA = new ReklamacijeDS.RKM_POTVRDADataTable();
        //public static ReklamacijeDS.RKM_PMDataTable RKM_PM = new ReklamacijeDS.RKM_PMDataTable();
        //public static ReklamacijeDS.RKM_STATUSDataTable RKM_STATUS = new ReklamacijeDS.RKM_STATUSDataTable();
        //public static ReklamacijeDS.RKM_ZAHTEVDataTable RKM_ZAHTEV = new ReklamacijeDS.RKM_ZAHTEVDataTable();
        //public static ReklamacijeDS.RKM_SERVISERDataTable RKM_SERVISER = new ReklamacijeDS.RKM_SERVISERDataTable();
        public static RKM_POTVRDATableAdapter potvrdaTA;
        public static RKM_SERVISERTableAdapter serviserTA;
        public static RKM_SMSTableAdapter smsTA;

        public static void puniTabele()
        {
            // punjenje dataset-a

            try
            {
                potvrdaTA = new RKM_POTVRDATableAdapter();
                potvrdaTA.Connection.ConnectionString = ElbsSqlKonekcija.ELBS_ReklamacijeConnString;
                potvrdaTA.Fill(reklamacijeDS.RKM_POTVRDA);

                RKM_PMTableAdapter prodMestoTA = new RKM_PMTableAdapter();
                prodMestoTA.Connection.ConnectionString = ElbsSqlKonekcija.ELBS_ReklamacijeConnString;
                prodMestoTA.Fill(reklamacijeDS.RKM_PM);

                RKM_STATUSTableAdapter statusTA = new RKM_STATUSTableAdapter();
                statusTA.Connection.ConnectionString = ElbsSqlKonekcija.ELBS_ReklamacijeConnString;
                statusTA.Fill(reklamacijeDS.RKM_STATUS);

                RKM_ZAHTEVTableAdapter zahtevPotTA = new RKM_ZAHTEVTableAdapter();
                zahtevPotTA.Connection.ConnectionString = ElbsSqlKonekcija.ELBS_ReklamacijeConnString;
                zahtevPotTA.Fill(reklamacijeDS.RKM_ZAHTEV);

                serviserTA = new RKM_SERVISERTableAdapter();
                serviserTA.Connection.ConnectionString = ElbsSqlKonekcija.ELBS_ReklamacijeConnString;
                serviserTA.Fill(reklamacijeDS.RKM_SERVISER);

                smsTA = new RKM_SMSTableAdapter();
                smsTA.Connection.ConnectionString = ElbsSqlKonekcija.ELBS_ReklamacijeConnString;
                smsTA.Fill(reklamacijeDS.RKM_SMS);



                //MessageBox.Show("Punjenje gotovo", "Punjenje");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greška void puniTabele");
                return;
            }
        }
    }
}
