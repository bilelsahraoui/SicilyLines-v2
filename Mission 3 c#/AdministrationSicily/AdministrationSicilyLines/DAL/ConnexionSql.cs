using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdministrationSicilyLines.DAL
{
    class ConnexionSql
    {
        private static ConnexionSql connection = null;

        private MySqlConnection Conex;

        private static readonly object mylock = new object();

        private string connString;

        //Connexion à la BDD
        private ConnexionSql(string unProvider, string uneDataBase, string unUid, string unMdp)
        {


            try
            {
                connString = "SERVER=" + unProvider + ";" + "DATABASE=" +
                uneDataBase + ";" + "UID=" + unUid + ";" + "PASSWORD=" + unMdp + ";";
                try
                {
                    Conex = new MySqlConnection(connString);
                }
                catch (Exception emp)
                {
                    throw (emp);
                }
            }
            catch (Exception emp)
            {
                throw (emp);
            }



        }



        /**
         * méthode de création d'une instance de connexion si elle n'existe pas (singleton)
         */
        public static ConnexionSql getInstance(string unProvider, string uneDataBase, string unUid, string unMdp)
        {

            //       lock ((mylock))
            //    {

            try
            {


                if (null == connection)
                { // Premier appel
                    connection = new ConnexionSql(unProvider, uneDataBase, unUid, unMdp);


                }

            }
            catch (Exception emp)
            {
                throw (emp);


            }
            return connection;

            //  }
        }





        /**
         * Ouverture de la connexion
         */
        public void openConnection()
        {

            if (Conex.State == System.Data.ConnectionState.Closed)
                Conex.Open();
        }

        //Close connection
        public void closeConnection()
        {
            if (Conex.State == System.Data.ConnectionState.Open)
                Conex.Close();
        }


        public bool isOpen()
        {
            bool res = false;
            if (Conex.State == System.Data.ConnectionState.Open) { res = true; }

            return (res);
        }

        /**
         * Fermeture de la connexion
         */


        /**
         * Exécutiuon d'une requête
         */
        public MySqlCommand reqExec(string req)
        {
            MySqlCommand mysqlCom = new MySqlCommand(req, this.Conex);
            return (mysqlCom);
        }

    }
}
