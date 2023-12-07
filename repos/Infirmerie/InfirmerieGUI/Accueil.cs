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
    public partial class Accueil : Form
    {
        public Accueil(Utilisateur uti)
        {
            InitializeComponent();
            //Récupération du nom de l'utilisateur pour l'affichage
            labelBienvenue.Text = "Bienvenue, " + uti.login + " !";
        }
        public Accueil()
        {
            InitializeComponent();
            labelBienvenue.Text = "Accueil";
        }

        private void Accueil_Load(object sender, EventArgs e)
        {

        }
        private void buttonDeconnexion_Click(object sender, EventArgs e)
        {
          
        }

        private void buttonEleves_Click(object sender, EventArgs e)
        {
            this.Hide();
            Eleve Eleve = new Eleve();
            Eleve.Show();
        }

        private void buttonMedicaments_Click(object sender, EventArgs e)
        {
            this.Hide();
            Medicament medicament = new Medicament();
            medicament.Show();
        }

        private void buttonDeconnexion_Click_1(object sender, EventArgs e)
        {
            //Affiche du formulaire Connexion
            this.Hide();
            Connexion Connexion = new Connexion();
            Connexion.ShowDialog();
        }

        private void buttonVisites_Click(object sender, EventArgs e)
        {
            //Retour vers la page d'accueil
            this.Hide();
            Visite am = new Visite();
            am.ShowDialog();
        }
    }
}
