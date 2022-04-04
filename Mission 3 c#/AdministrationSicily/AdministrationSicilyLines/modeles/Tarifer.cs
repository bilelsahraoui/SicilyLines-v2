using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrationSicilyLines.modeles
{
    //Création de l'entité tarifer
    public class Tarifer
    {
        private int _idTarifer;
        private int _idLiaison;
        private DateTime _dateTariferDebut;
        private DateTime _dateTariferFin;
        private double _tarif;
        private string _type;


        public Tarifer()
        {

        }

        public Tarifer(int idTarifer, int idLiaison, DateTime dateTariferDebut, DateTime dateTariferFin,
                        double tarif, string type)
        {
            this._idTarifer = idTarifer;
            this._idLiaison = idLiaison;
            this._dateTariferDebut = dateTariferDebut;
            this._dateTariferFin = dateTariferFin;
            this._tarif = tarif;
            this._type=type;

        }

        public int IdTarifer
        {
            get { return _idTarifer; }
            set { _idTarifer = value; }
        }

        public int IdLiaison
        {
            get { return _idLiaison; }
            set { _idLiaison = value; }
        }

        public DateTime DateTariferDebut
        {
            get { return _dateTariferDebut; }
            set { _dateTariferDebut = value;}
        }

        public DateTime DateTariferFin
        {
            get { return _dateTariferFin;}
            set { _dateTariferFin = value; }
        }

        public double Tarif
        {
            get { return _tarif; }
            set { _tarif = value; }
        }

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public virtual string Description
        {
            get {
                return (" Tarif de : " + this._tarif + " €  entre la période du " + this.DateTariferDebut.ToString("d") +
                  " jusqu'au "+this._dateTariferFin.ToString("d")+" pour les types : "+this._type);
            }
        }

    }
}
