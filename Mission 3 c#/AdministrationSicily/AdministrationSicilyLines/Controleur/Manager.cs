using AdministrationSicilyLines.DAL;
using AdministrationSicilyLines.modeles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministrationSicilyLines.Controleur
{
    class Manager
    {
        LiaisonDao ld = new LiaisonDao();

        TariferDao td = new TariferDao();

        //Chargement de la liste des liaisons
        public List<Liaison> chargementLBD()
        {
           return (ld.getLiaison());

        }

        //Chargement de la liste des tarifs liés à une liaison
        public List<Tarifer> chargementTBD(Liaison l)
        {
            int idLiaison = l.IdLiaison;
            return td.getTarif(idLiaison);
        }

        //Modifier la durée d'une liaison
        public void updateLiaison(Liaison l)
        {
            ld.updateLiaison(l);
        }

        //Modifier les tarifs d'une liaison
        public void updateTarifer(Tarifer t)
        {
            td.updateTarifer(t);
        }

        //Ajouter une liaison
        public void addLiaison(string portDepart, string portArrivee, TimeSpan duree)
        {
            ld.AddLiaison(portDepart, portArrivee, duree);
        }

        //Supprimer une liaison
        public void deleteLiaison(Liaison l)
        {
            ld.deleteLiaison(l);
        }

    }
}