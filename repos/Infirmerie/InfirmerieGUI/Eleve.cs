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
            //Affichage du formulaire d'Accueil
            this.Hide();
            ListeEleve ListeEleve = new ListeEleve();
            ListeEleve.ShowDialog();
        }

        private void buttonRetour_Click(object sender, EventArgs e)
        {
            //Affichage du formulaire d'Accueil
            this.Hide();
            Accueil Accueil = new Accueil();
            Accueil.ShowDialog();
        }
        private void buttonAjouter_Click(object sender, EventArgs e)
        {
        }

        private void buttonAjouter_Click_1(object sender, EventArgs e)
        {
            //Affichage du formulaire d'ajout
            this.Hide();
            Ajout_Eleve aj = new Ajout_Eleve();
            aj.ShowDialog();
        }
    }
}
