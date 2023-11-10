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
            labelBienvenue.Text = "Bienvenue, " + uti.login + " !";
        }

        private void Accueil_Load(object sender, EventArgs e)
        {

        }
        private void buttonDeconnexion_Click(object sender, EventArgs e)
        {
          
        }

        private void buttonEleves_Click(object sender, EventArgs e)
        {

        }

        private void buttonMedicaments_Click(object sender, EventArgs e)
        {

        }

        private void buttonDeconnexion_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Connexion Connexion = new Connexion();
            Connexion.ShowDialog();
        }
    }
}
