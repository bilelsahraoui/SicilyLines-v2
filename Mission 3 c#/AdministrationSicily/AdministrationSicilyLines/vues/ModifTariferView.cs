using AdministrationSicilyLines.Controleur;
using AdministrationSicilyLines.DAL;
using AdministrationSicilyLines.modeles;
using AdministrationSicilyLines.modeles.Exceptions;
using MySql.Data.MySqlClient;
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
    public partial class ModifTariferView : Form
    {

        Manager monManager;

        private Liaison l;

        public List<Tarifer> listTarifer = new List<Tarifer>();


        public ModifTariferView(Liaison uneLiaison)
        {
            InitializeComponent();
            this.l = uneLiaison;
            monManager = new Manager();
        }

        private void ModifTariferView_Load(object sender, EventArgs e)
        {
            listTarifer = monManager.chargementTBD(l);
            if(listTarifer.Count() == 0) { ExceptionsTarif ex = new ExceptionsTarif("Aucun tarif pour cette liaison !");
                MessageBox.Show(ex.Message);
                this.Close();
            }

            else { rafraichirListBox(); }
        }

        private void rafraichirListBox()
        {

            LBTarif.DataSource = null;
            // lBox.DataSource = lstcpt.Values.ToList();
            LBTarif.DataSource = listTarifer;
            LBTarif.DisplayMember = "Description";
            monManager.chargementTBD(l);

        }


        private void BTNModif_Click(object sender, EventArgs e)
        {
            int i;
            double tarif;
            i = LBTarif.SelectedIndex;

            Tarifer tarifer = listTarifer[i];
            try
            {
                tarif = Convert.ToDouble(TBTarif.Text);
                tarifer.Tarif = tarif;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            monManager.updateTarifer(tarifer);
            rafraichirListBox();

        }

        private void LBTarif_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LBTarif.SelectedIndex < 0) { return; }

            TBDate_Debut.Text = listTarifer[LBTarif.SelectedIndex].DateTariferDebut.ToString("d");
            TBDate_Fin.Text = listTarifer[LBTarif.SelectedIndex].DateTariferFin.ToString("d");
            TBType.Text = listTarifer[LBTarif.SelectedIndex].Type.ToString();
            TBTarif.Text = listTarifer[LBTarif.SelectedIndex].Tarif.ToString();
        }
    }
}
