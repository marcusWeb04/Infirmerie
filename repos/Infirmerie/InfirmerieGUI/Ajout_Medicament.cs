using InfirmerieBLL;
using InfirmerieBO;
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
    public partial class Ajout_Medicament : Form
    {
        public Ajout_Medicament()
        {
            InitializeComponent();

        }

        private void labelBienvenue_Click(object sender, EventArgs e)
        {

        }

        private void labelRecherche_Click(object sender, EventArgs e)
        {

        }

        private void buttonRetour_Click(object sender, EventArgs e)
        {
            //Affichage à la page Medicament
            this.Hide();
            Medicament Medicament = new Medicament();
            Medicament.ShowDialog();
        }

        private void textBoxRecherche_TextChanged(object sender, EventArgs e)
        {
        }

        private void buttonAjoutMedic_Click(object sender, EventArgs e)
        {
            //Récupération des valeurs saisies
            int id = 0;
            string lib = textBoxLib.Text;

            //Vérifications
            if (lib == "")
            {
                MessageBox.Show("Veuillez rentrer toutes les informations obligatoires.");
            }
            else
            {
                //On crée un objet élève
                InfirmerieBO.Medicament el = new InfirmerieBO.Medicament(id, lib, 0);
                if (ConnexionBLL.addMedicament(el))
                {
                    MessageBox.Show("Médicament ajouté!");
                }
                else
                {
                    MessageBox.Show("Une erreur est survenue.");
                }
            }
        }
    }
    
}
