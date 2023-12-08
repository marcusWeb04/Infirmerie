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
    public partial class Ajout_Visite : Form
    {
        private static InfirmerieBO.Eleve global_el;
        public Ajout_Visite(InfirmerieBO.Eleve el)
        {
            //Initialistion des données
            InitializeComponent();
            textBoxNom.Text = el.nom;
            textBoxPrenom.Text = el.prenom;
            textBoxClasse.Text = el.classe.lib;
            textBoxAge.Text = el.naiss;

            textBoxDate.Text = DateTime.Today.ToString().Substring(0,10);

            //Ajout d'un médicament 'Aucun' 
            InfirmerieBO.Medicament nomed = new InfirmerieBO.Medicament(0,"Aucun", 0);
            List<InfirmerieBO.Medicament> nomedlist = new List<InfirmerieBO.Medicament>();
            nomedlist.Add(nomed);

            //Génération de la liste des médicaments
            comboBoxMedic.DataSource = nomedlist.Concat(ConnexionBLL.getMedicaments("")).ToList();
            comboBoxMedic.SelectedIndex = 0;
            
            comboBoxSuite.SelectedIndex = 0;
            global_el = el;
        }

        private void buttonDummyAdd_Click(object sender, EventArgs e)
        {
            //Récupération des données saisies
            string date = textBoxDate.Text;
            string arrivee = textBoxHeureArrivee.Text;
            string depart = textBoxHeureDepart.Text;
            string suite = comboBoxSuite.SelectedItem.ToString();
            string motif = textBoxMotif.Text;
            string comm = textBoxComm.Text;

            InfirmerieBO.Medicament medic = comboBoxMedic.SelectedItem as InfirmerieBO.Medicament;

            int? qte;
            if (textBoxQteMedic.Text == "")
            {
                qte = null;
            }
            else
            {
                qte = Int32.Parse(textBoxQteMedic.Text);
            }

            bool parentsprev = checkBoxParentsPrev.Checked;

            if (date == "" || arrivee == "" || depart == "" || motif == "")
            {
                MessageBox.Show("Veuillez remplir les champs obligatoires.");
            }
            else
            {
                //Si le médicament "Aucun" est séléctionné, on le met à null pour l'insertion
                if (medic.id == 0) 
                {
                    medic = null;
                }


                InfirmerieBO.Visite vi = new InfirmerieBO.Visite(0, global_el, medic, qte, date, arrivee, depart, motif, comm, parentsprev, suite, null);
                if (ConnexionBLL.addVisite(vi))
                {
                    MessageBox.Show("Visite ajoutée!");
                }
                else
                {
                    MessageBox.Show("Une erreur est survenue.");
                }
            }
        }

        private void Ajout_Visite_Load(object sender, EventArgs e)
        {

        }
    }
}
