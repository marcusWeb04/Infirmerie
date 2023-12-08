using InfirmerieBLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfirmerieGUI
{
    public partial class Modif_Visite_Modale : Form
    {
        private static InfirmerieBO.Visite visite;
        private static Modif_Visite modif;
        public InfirmerieBO.Visite global_vi { get => visite; set => visite = value; }
        public Modif_Visite global_modif { get => modif; set => modif = value; }


        public Modif_Visite_Modale(InfirmerieBO.Visite vi, Modif_Visite modif)
        {
            InitializeComponent();
            global_vi = vi;
            global_modif = modif;
        }

        private void Modif_Eleve_Modale_Load(object sender, EventArgs e)
        {

        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            this.Close();
            if (ConnexionBLL.deleteVisite(global_vi))
            {
                MessageBox.Show("Visite supprimé.");
                Visite visite = new Visite();
                visite.ShowDialog();
                global_modif.Close();
            }
            else
            {
                MessageBox.Show("Une erreur est survenue.");
            }
        }
    }
}
