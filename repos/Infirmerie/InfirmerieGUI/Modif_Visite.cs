using InfirmerieBLL;
using InfirmerieBO;
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

namespace InfirmerieGUI
{
    public partial class Modif_Visite : Form
    {
        public Modif_Visite()
        {
            InitializeComponent();
        }

        private static InfirmerieBO.Visite visite;
        public InfirmerieBO.Visite global_vi { get => visite; set => visite = value; }

        public Modif_Visite(InfirmerieBO.Visite vi)
        {
            InitializeComponent();
            ConnexionBLL.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Infirmerie"]);
            comboBoxClasse.DataSource = ConnexionBLL.getClasses();

            //Préremplissage
            textBoxNom.Text = vi.nom;
            textBoxPrenom.Text = el.prenom;
            comboBoxClasse.SelectedItem = el.classe;
            textBoxTelEleve.Text = el.port.ToString();
            textBoxTelParent.Text = el.parent_port.ToString();
            textBoxComSante.Text = el.comm_sante;
            textBoxDateDeNaissance.Text = el.naiss;
            checkBoxTiersTemps.Checked = el.tiers_temps;

            global_el = el;
        }

        private void buttonRetour_Click(object sender, EventArgs e)
        {
        }

        private void buttonDummyAdd_Click_1(object sender, EventArgs e)
        {
            //Récupération des valeurs saisies
            string nom = textBoxNom.Text;
            string prenom = textBoxPrenom.Text;
            string dateDeNaissance = textBoxDateDeNaissance.Text;
            bool tiersTemps = checkBoxTiersTemps.Checked;
            string commSante = textBoxComSante.Text;

            int teleleve;
            int telparent;
            string value = textBoxTelEleve.Text;
            int.TryParse(value, out teleleve);
            value = textBoxTelParent.Text;
            int.TryParse(value, out telparent);

            object classeobj = comboBoxClasse.SelectedItem;
            Classe classe = classeobj as Classe;


            //Vérifications
            if (nom == "" || prenom == "" || classe.id == 0 || dateDeNaissance == "" || teleleve == 0 || telparent == 0)
            {
                MessageBox.Show("Veuillez rentrer toutes les informations obligatoires.");
            }
            else
            {
                //On modifie l'objet élève
                InfirmerieBO.Eleve el = new InfirmerieBO.Eleve(global_el.id, nom, prenom, dateDeNaissance, teleleve, telparent, classe, tiersTemps, commSante);
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
    }
}
