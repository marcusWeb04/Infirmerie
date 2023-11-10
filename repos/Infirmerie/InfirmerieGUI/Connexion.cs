using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Configuration;
using InfirmerieBO;
using InfirmerieBLL;

namespace InfirmerieGUI
{
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
            ConnexionBLL.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Infirmerie"]);
        }

        private void buttonSeconnecter_Click_1(object sender, EventArgs e)
        {
            Utilisateur uti = new Utilisateur(textBoxIdentifiant.Text, textBoxMotdepasse.Text);
            if (ConnexionBLL.GetUtilisateur(uti))
            {
                this.Hide();
                Accueil Accueil = new Accueil(uti);
                Accueil.ShowDialog();
            } else {
                MessageBox.Show("Identifiants invalides.");
            }
        }

        private void textBoxIdentifiant_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
