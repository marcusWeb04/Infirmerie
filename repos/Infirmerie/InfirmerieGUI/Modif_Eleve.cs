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
    public partial class Modif_Eleve : Form
    {
        public Modif_Eleve(InfirmerieBO.Eleve el)
        {
            InitializeComponent();
            ConnexionBLL.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Infirmerie"]);

            //Préremplissage
            textBoxNom.Text = el.nom;
            textBoxPrenom.Text = el.prenom;
            textBoxClasse.Text = el.classe.ToString();
            textBoxTelEleve.Text = el.port.ToString();
            textBoxTelParent.Text = el.parent_port.ToString();
            textBoxComSante.Text = el.comm_sante;
            textBoxDateDeNaissance.Text = el.naiss;
            checkBoxTiersTemps.Checked = el.tiers_temps;

            textBoxId.Text = el.id.ToString();
        }

        private void buttonRetour_Click(object sender, EventArgs e)
        {
            //Affichage du formulaire Élève
            this.Hide();
            Eleve Eleve = new Eleve();
            Eleve.ShowDialog();
        }

        private void buttonDummyAdd_Click_1(object sender, EventArgs e)
        {
            //Récupération des valeurs saisies
            string nom = textBoxNom.Text;
            string prenom = textBoxPrenom.Text;
            string dateDeNaissance = textBoxDateDeNaissance.Text;
            bool tiersTemps = checkBoxTiersTemps.Checked;
            string commSante = textBoxComSante.Text;

            int classe;
            int teleleve;
            int telparent;
            int id;
            string value = textBoxClasse.Text;
            int.TryParse(value, out classe);
            value = textBoxTelEleve.Text;
            int.TryParse(value, out teleleve);
            value = textBoxTelParent.Text;
            int.TryParse(value, out telparent);
            value = textBoxId.Text;
            int.TryParse(value, out id);

            //Vérifications
            if (nom == "" || prenom == "" || classe == 0 || dateDeNaissance == "" || teleleve == 0 || telparent == 0)
            {
                MessageBox.Show("Veuillez rentrer toutes les informations obligatoires.");
            }
            else
            {
                //On modifie l'objet élève
                InfirmerieBO.Eleve el = new InfirmerieBO.Eleve(id, nom, prenom, dateDeNaissance, teleleve, telparent, classe, tiersTemps, commSante);
                if (ConnexionBLL.editEleve(el))
                {
                    MessageBox.Show("Élève modifié!");
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

        private void buttonDummyAdd_Click(object sender, EventArgs e)
        {

        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
