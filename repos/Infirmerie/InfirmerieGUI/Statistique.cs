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
    public partial class Statistique : Form
    {
        public Statistique()
        {
            InitializeComponent();
        }

        private void buttonRetour_Click(object sender, EventArgs e)
        {
            //Affichage du formulaire d'Accueil
            this.Hide();
            Accueil Accueil = new Accueil();
            Accueil.ShowDialog();
        }

        private void buttonConsulter_Click(object sender, EventArgs e)
        {
            string annee = textBoxRecherche.Text;
            //Affichage du formulaire
            this.Hide();
            if (annee == "")
            {
                StatsGraphe sg = new StatsGraphe();
                sg.ShowDialog();
            }
            else
            {
                StatsGraphe sg = new StatsGraphe(annee);
                sg.ShowDialog();
            }
        }
    }
}
