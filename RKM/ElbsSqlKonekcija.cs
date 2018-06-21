using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace RKM
{
    public class ElbsSqlKonekcija
    {

        // Veza ka bazi ELBS_<tekućaGodina> -> Koristi se za logovanje operatera i listing artikala iz ELBS baze za tekuću godinu
        public static string ELBS_ConnString = Properties.Settings.Default.ELBS_ConnString;
      
        // Veza ka bazi ELBS_Reklamacije -> koristi se za perzistenciju podataka o reklamacijama
        public static string ELBS_ReklamacijeConnString = Properties.Settings.Default.ELBS_ReklamacijeConnString;



        public SqlConnection CreateElbsSqlConnection(string user, string pwd)
        {
            ELBS_ConnString = ELBS_ConnString + ";User ID=" + user + ";Password=" + pwd;

            SqlConnection elbsConnection = new SqlConnection(ELBS_ConnString);

            return elbsConnection;                
        }


        public SqlConnection CreateElbsReklamacijeSqlConnection()
        {
            SqlConnection elbsReklamacijeConnection = new SqlConnection(ELBS_ReklamacijeConnString);

            return elbsReklamacijeConnection;
        }



    }
}
