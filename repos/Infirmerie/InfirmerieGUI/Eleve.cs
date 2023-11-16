using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using InfirmerieBO;
using InfirmerieBLL;

namespace InfirmerieGUI
{
    public partial class Eleve : Form
    {
        public Eleve()
        {
            InitializeComponent();
        }

        private void buttonRechercher_Click(object sender, EventArgs e)
        {

        }

        private void buttonRetour_Click(object sender, EventArgs e)
        {
            //Affiche du formulaire d'Accueil
            this.Hide();
            Accueil Accueil = new Accueil();
            Accueil.ShowDialog();
        }
    }
}
