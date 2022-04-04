using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrationSicilyLines.modeles
{   
    //Création de l'entité liaison
    public class Liaison
    {
        private int _idLiaison;
        private TimeSpan _duree;
        private string _nomPortDepart;
        private string _nomPortArrivee;

        public Liaison()
        {
        }

        public Liaison(int idLiaison, TimeSpan duree, string nomPortDepart, string nomPortArrivee)
        {
            this._idLiaison = idLiaison;
            this._duree = duree;
            this._nomPortDepart=nomPortDepart;
            this._nomPortArrivee=nomPortArrivee;

        }


        public int IdLiaison
        {
            get { return _idLiaison; }
            set { _idLiaison = value; }
        }

        public TimeSpan Duree
        {
            get { return _duree; }
            set { _duree = value; }
        }

        public string NomPortDepart
        {
            get { return _nomPortDepart; }
            set { _nomPortDepart = value;}
        }

        public string NomPortArrivee
        {
            get { return _nomPortArrivee;}
            set { _nomPortArrivee = value;}
        }


        public virtual string Description
        {

            get {
                return ("Liaison n° " + this._idLiaison + " // Port de Depart : " + this._nomPortDepart
              + " // Port d'Arrivee : " + this._nomPortArrivee + " // Duree :" + this._duree);
            }
        }
    }
}