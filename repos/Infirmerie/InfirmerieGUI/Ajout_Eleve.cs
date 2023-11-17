using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InfirmerieBLL;
using InfirmerieBO;

namespace InfirmerieGUI
{
    public partial class Ajout_Eleve : Form
    {
        public Ajout_Eleve()
        {
            InitializeComponent();
            ConnexionBLL.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Infirmerie"]);
            comboBoxClasse.DataSource = ConnexionBLL.getClasses();
        }

        private void buttonRetour_Click(object sender, EventArgs e)
        {
            //Affichage du formulaire Élève
            this.Hide();
            Eleve Eleve = new Eleve();
            Eleve.ShowDialog();
        }

        private void buttonDummyAdd_Click(object sender, EventArgs e)
        {
            //Récupération des valeurs saisies
            int id = 0;
            string nom = textBoxNom.Text;
            string prenom = textBoxPrenom.Text;
            string dateDeNaissance = textBoxDateDeNaissance.Text;
            bool tiersTemps = checkBoxTiersTemps.Checked;
            string commSante = textBoxComSante.Text;

            int teleleve;
            int telparent;
            object classeobj = comboBoxClasse.SelectedItem;
            Classe classe = classeobj as Classe;

            string value = textBoxTelEleve.Text;
            int.TryParse(value, out teleleve);
            value = textBoxTelParent.Text;
            int.TryParse(value, out telparent);

            //Vérifications
            if (nom == "" || prenom == "" || classe.id == 0 || dateDeNaissance == "" || teleleve == 0 || telparent == 0)
            {
                MessageBox.Show("Veuillez rentrer toutes les informations obligatoires.");
            }
            else
            {   
                //On crée un objet élève
                InfirmerieBO.Eleve el = new InfirmerieBO.Eleve(id, nom, prenom, dateDeNaissance, teleleve, telparent, classe, tiersTemps, commSante);
                if (ConnexionBLL.addEleve(el))
                {
                    MessageBox.Show("Élève ajouté!");
                }
                else
                {
                    MessageBox.Show("Une erreur est survenue.");
                }
            }

        }

        private void Ajout_Eleve_Load(object sender, EventArgs e)
        {

        }

        private void labelBienvenue_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void listBoxClasse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
