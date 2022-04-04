using AdministrationSicilyLines.modeles;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministrationSicilyLines.DAL
{
    public class LiaisonDao
    {

        private ConnexionSql maConnexionSql;


        private MySqlCommand Ocom;

        private int _idPortDepart;
        private int _idPortArrivee;

        //Obtenir une certaine liaison
        public Liaison getLiaison(int unIdLiaison)
        {

            try
            {
                Liaison _liaison = new Liaison();



                maConnexionSql = ConnexionSql.getInstance(InfoLog.ProviderMysql, InfoLog.DataBaseMysql, InfoLog.UidMysql, InfoLog.MdpMysql);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("Select * from liaison where numero = " + unIdLiaison);


                MySqlDataReader reader1 = Ocom.ExecuteReader();


                while (reader1.Read())
                {

                    int _idLiaison = (int)reader1.GetValue(0);
                    TimeSpan _duree = (TimeSpan)reader1.GetValue(1);
                    string _nomPortDepart = (string)reader1.GetValue(2);
                    string _nomPortArrivee = (string)reader1.GetValue(3);

                    _liaison = new Liaison(_idLiaison,_duree,_nomPortDepart,_nomPortArrivee);


                }



                reader1.Close();

                maConnexionSql.closeConnection();


                return (_liaison);

            }

            catch (Exception emp)
            {

                throw (emp);
            }
        }

        //Modifier une certaine liaison
        public void updateLiaison(Liaison l)
        {

            try
            {




                maConnexionSql = ConnexionSql.getInstance(InfoLog.ProviderMysql, InfoLog.DataBaseMysql, InfoLog.UidMysql, InfoLog.MdpMysql);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("update liaison set duree = '" + l.Duree + "' where id = " + l.IdLiaison);


                int i = Ocom.ExecuteNonQuery();



                maConnexionSql.closeConnection();



            }

            catch (Exception emp)
            {

                throw (emp);
            }
        }

        //Obtenir l'ensemble des liaisons
        public List<Liaison> getLiaison()
        {

            List<Liaison> l_liaison = new List<Liaison>();

            try
            {

                maConnexionSql = ConnexionSql.getInstance(InfoLog.ProviderMysql, InfoLog.DataBaseMysql, InfoLog.UidMysql, InfoLog.MdpMysql);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("select DISTINCT liaison.id, portDepart.nom, portArrivee.nom, liaison.duree " +
                    "from liaison left join port portDepart on liaison.port_depart_id=portDepart.id "+
                    "LEFT JOIN port portArrivee on liaison.port_arrivee_id = portArrivee.id");


                MySqlDataReader reader = Ocom.ExecuteReader();

                Liaison l;


                while (reader.Read())
                {

                    int _idLiaison = (int)reader.GetValue(0);
                    string _nomPortDepart = (string)reader.GetValue(1);
                    string _nomPortArrivee = (string)reader.GetValue(2);
                    TimeSpan _duree = (TimeSpan)reader.GetValue(3);

                    l = new Liaison(_idLiaison, _duree, _nomPortDepart, _nomPortArrivee) ;

                    l_liaison.Add(l);


                }



                reader.Close();

                maConnexionSql.closeConnection();


            }




            catch (Exception emp)
            {

                MessageBox.Show(emp.Message);

            }

            return (l_liaison);
        }

        //Ajouter une liaison
        public void AddLiaison(string portDepart, string portArrivee, TimeSpan duree)
        {
            int _idPortDepart = getIdPortDepart(portDepart);
            int _idPortArrivee = getIdPortArrivee(portArrivee);

            try
            {

                

                maConnexionSql = ConnexionSql.getInstance(InfoLog.ProviderMysql, InfoLog.DataBaseMysql, InfoLog.UidMysql, InfoLog.MdpMysql);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("INSERT INTO liaison (duree, port_depart_id, port_arrivee_id)" +
                    " VALUES ('"+duree+"', '"+_idPortDepart+"', '"+_idPortArrivee+"');");

                MySqlDataReader mySqlDataReader;

                mySqlDataReader = Ocom.ExecuteReader();



                maConnexionSql.closeConnection();



            }

            catch (Exception emp)
            {

                throw (emp);
            }
        }
        //Supprimer une liaison
        public void deleteLiaison(Liaison l)
        {
            try
            {

                maConnexionSql = ConnexionSql.getInstance(InfoLog.ProviderMysql, InfoLog.DataBaseMysql, InfoLog.UidMysql, InfoLog.MdpMysql);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("DELETE from tarifer where liaison_id="+ l.IdLiaison +
                    "; DELETE from reservation where traversee_id in(SELECT id from traversee where liaison_id=" + l.IdLiaison +
                    ")  ; DELETE from traversee where liaison_id=" + l.IdLiaison +
                    "; DELETE from secteur where liaison_id=" + l.IdLiaison +
                    "; DELETE from liaison where liaison.id=" + l.IdLiaison);


                int i = Ocom.ExecuteNonQuery();

                maConnexionSql.closeConnection();

            }

            catch (Exception emp)
            {

                throw (emp);
            }
        }
        //Obtenir l'id d'un port de depart
        public int getIdPortDepart(string portDepart)
        {
            try
            {
                

                maConnexionSql = ConnexionSql.getInstance(InfoLog.ProviderMysql, InfoLog.DataBaseMysql, InfoLog.UidMysql, InfoLog.MdpMysql);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("select port.id from port where port.nom='"+portDepart+"';");

                

                MySqlDataReader reader = Ocom.ExecuteReader();


                while (reader.Read())
                {
                    int _id = (int)reader.GetValue(0);


                    _idPortDepart=_id;
                }



                reader.Close();

                maConnexionSql.closeConnection();

                
            }

            catch (Exception emp)
            {

                MessageBox.Show(emp.Message);

            }
            return _idPortDepart;
        }

        //Obtenir l'id d'un port d'arriver
        public int getIdPortArrivee(string portArrivee)
        {
            try
            {


                maConnexionSql = ConnexionSql.getInstance(InfoLog.ProviderMysql, InfoLog.DataBaseMysql, InfoLog.UidMysql, InfoLog.MdpMysql);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("select port.id from port where port.nom='" + portArrivee + "';");



                MySqlDataReader reader2 = Ocom.ExecuteReader();


                while (reader2.Read())
                {
                    int _id = (int)reader2.GetValue(0);


                    _idPortArrivee = _id;
                }



                reader2.Close();

                maConnexionSql.closeConnection();


            }

            catch (Exception emp)
            {

                MessageBox.Show(emp.Message);

            }
            return _idPortArrivee;
        }
    }
}
