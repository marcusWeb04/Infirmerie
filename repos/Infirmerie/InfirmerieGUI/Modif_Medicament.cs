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
    public partial class Modif_Medicament : Form
    {

        private static InfirmerieBO.Medicament medicament;

        public InfirmerieBO.Medicament global_med { get => medicament; set => medicament = value; }
        public Modif_Medicament(InfirmerieBO.Medicament med)
        {
            InitializeComponent();

            //Préremplissage
            textBoxLib.Text = med.lib;
            global_med = med;
        }

        private void labelRecherche_Click(object sender, EventArgs e)
        {

        }

        private void textBoxLib_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonDummyAdd_Click(object sender, EventArgs e)
        {
            //Récupération des valeurs saisies
            string lib = textBoxLib.Text;

            //Vérifications
            if (lib == "")
            {
                MessageBox.Show("Veuillez rentrer toutes les informations obligatoires.");
            }
            else
            {
                //On crée un objet élève
                InfirmerieBO.Medicament med = new InfirmerieBO.Medicament(global_med.id, lib, 0);
                if (ConnexionBLL.addMedicament(med))
                {
                    MessageBox.Show("Médicament modifié!");
                }
                else
                {
                    MessageBox.Show("Une erreur est survenue.");
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }

        private void buttonRetour_Click(object sender, EventArgs e)
        {
            //Retour à la page Medicament
            this.Hide();
            Medicament Medicament = new Medicament();
            Medicament.ShowDialog();
        }
    }
}
