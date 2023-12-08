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
    public partial class Visite : Form
    {
        public Visite()
        {
            InitializeComponent();
            comboBoxMois.SelectedIndex = 0;
        }

        private void buttonRetour_Click(object sender, EventArgs e)
        {
            //Retour vers la page d'accueil
            this.Hide();
            Accueil am = new Accueil();
            am.Show();
        }

        private void buttonRechercher_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListeVisite liste = new ListeVisite(textBoxRechercheNom.Text,textBoxRechercheDate.Text, comboBoxMois.SelectedIndex);
            liste.ShowDialog();
        }
    }
}
