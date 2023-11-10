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

        //Connexion
        private void buttonSeconnecter_Click_1(object sender, EventArgs e)
        {
            //Création d'une instance Utilisateur qui sera utilisée en BLL puis DAL
            Utilisateur uti = new Utilisateur(textBoxIdentifiant.Text, textBoxMotdepasse.Text);
            if (ConnexionBLL.GetUtilisateur(uti))
            {
                //Affiche du formulaire d'Accueil
                this.Hide();
                Accueil Accueil = new Accueil(uti);
                Accueil.ShowDialog();
            } else {
                //Erreur
                MessageBox.Show("Identifiants invalides.");
            }
        }

        private void textBoxIdentifiant_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
