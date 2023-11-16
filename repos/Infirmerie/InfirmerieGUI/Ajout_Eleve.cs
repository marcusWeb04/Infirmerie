using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        }

        private void buttonRetour_Click(object sender, EventArgs e)
        {
            //Affiche du formulaire Élève
            this.Hide();
            Eleve Eleve = new Eleve();
            Eleve.ShowDialog();
        }

        private void buttonDummyAdd_Click(object sender, EventArgs e)
        {
            int id = -727;
            string nom = textBoxNom.Text;
            string prenom = textBoxPrenom.Text;
            string value = textBoxClasse.Text;
            int.TryParse(value, out int classe);
            string dateDeNaissance = textBoxDateDeNaissance.Text;
            value = textBoxTelEleve.Text;
            int.TryParse(value, out int telEleve);
            value = textBoxTelParent.Text;
            int.TryParse(value, out int telParent);
            bool tiersTemps = checkBoxTiersTemps.Checked;//permet de savoir l'état d'une checked box
            string commSante = textBoxComSante.Text;

            //On crée notre objet élève
            InfirmerieBO.Eleve el = new InfirmerieBO.Eleve(id, nom, prenom, dateDeNaissance, telEleve, telParent, classe, tiersTemps, commSante);

            ConnexionBLL.addEleve(el);

        }

        private void Ajout_Eleve_Load(object sender, EventArgs e)
        {

        }

        private void labelBienvenue_Click(object sender, EventArgs e)
        {

        }
    }
}
