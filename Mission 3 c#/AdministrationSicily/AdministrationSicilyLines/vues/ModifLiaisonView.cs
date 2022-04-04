using AdministrationSicilyLines.modeles;
using AdministrationSicilyLines.modeles.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministrationSicilyLines.vues
{
    public partial class ModifLiaisonView : Form
    {

        private Liaison l;

        public ModifLiaisonView(Liaison uneLiaison)
        {
            InitializeComponent();

            this.l = uneLiaison;
        }

        private void ModifLiaisonView_Load(object sender, EventArgs e)
        {
            TBidLiaison.Text=l.IdLiaison.ToString();
            TBnomPortD.Text=l.NomPortDepart.ToString();
            TBnomPortA.Text=l.NomPortArrivee.ToString();
            TBduree.Text=l.Duree.ToString();
        }

        private void BTNValider_Click(object sender, EventArgs e)
        {
            try { 
            l.Duree = TimeSpan.Parse(TBduree.Text);
            this.Close();
            }

            catch { ExceptionsLiaison ex = new ExceptionsLiaison("Veuillez rentrer un temps valide !");
                MessageBox.Show(ex.Message);
            }
        }
    }
}
