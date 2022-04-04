using AdministrationSicilyLines.modeles;
using AdministrationSicilyLines.modeles.Exceptions;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AdministrationSicilyLines.DAL
{
    public class TariferDao
    {
        private ConnexionSql maConnexionSql;
        private MySqlCommand Ocom;


        
        //Retourne les tarifs d'une liaison
        public List<Tarifer> getTarif(int unIdLiaison)
        {
            List<Tarifer> l_tarifer = new List<Tarifer>();

            try
            {




                maConnexionSql = ConnexionSql.getInstance(InfoLog.ProviderMysql, InfoLog.DataBaseMysql, InfoLog.UidMysql, InfoLog.MdpMysql);


                maConnexionSql.openConnection();


                    Ocom = maConnexionSql.reqExec("SELECT DISTINCT tarifer.id, liaison_id, tarif, periodeT.date_debut, periodeT.date_fin, typeE.libelle " +
                        "from tarifer left join periode periodeT on tarifer.periode_id=periodeT.id " +
                        "left JOIN type typeE on tarifer.type_id=typeE.id where liaison_id= " + unIdLiaison +
                        " ORDER BY tarifer.tarif ASC;");


                    MySqlDataReader reader = Ocom.ExecuteReader();

                    Tarifer t;

                    while (reader.Read())
                    {

                        int _idTarifer = (int)reader.GetValue(0);
                        int _idLiaison = (int)reader.GetValue(1);
                        double _tarif = (double)reader.GetValue(2);
                        DateTime _dateDebut = (DateTime)reader.GetValue(3);
                        DateTime _dateFin = (DateTime)reader.GetValue(4);
                        string _type = (string)reader.GetValue(5);

                        t = new Tarifer(_idTarifer, _idLiaison, _dateDebut, _dateFin, _tarif, _type);

                        l_tarifer.Add(t);

                    }



                    reader.Close();

                    maConnexionSql.closeConnection();


         
            }

            catch (ExceptionsTarif)
            {

                throw (new ExceptionsTarif("Probleme rencontré lors du chargement des tarif"));
            }

            return (l_tarifer);
        }

        //Modifier le tarif d'une liaison
        public void updateTarifer(Tarifer t)
        {

            try
            {




                maConnexionSql = ConnexionSql.getInstance(InfoLog.ProviderMysql, InfoLog.DataBaseMysql, InfoLog.UidMysql, InfoLog.MdpMysql);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("update tarifer set tarif = '" + t.Tarif.ToString(CultureInfo.InvariantCulture) + "' where id = " + t.IdTarifer);


                int i = Ocom.ExecuteNonQuery();



                maConnexionSql.closeConnection();



            }

            catch (ExceptionsTarif)
            {
                throw (new ExceptionsTarif("Format de la chaine incorrect"));
            }
        }

    }
}
