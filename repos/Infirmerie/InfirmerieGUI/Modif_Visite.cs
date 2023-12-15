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
            //Initialistion des données
            InitializeComponent();
            textBoxNom.Text = vi.eleve.nom;
            textBoxPrenom.Text = vi.eleve.prenom;
            textBoxClasse.Text = vi.eleve.classe.lib;
            textBoxAge.Text = vi.eleve.naiss;

            textBoxDate.Text = vi.date.ToString();
            textBoxHeureArrivee.Text = vi.heure_arrivee;
            textBoxHeureDepart.Text = vi.heure_depart;
            textBoxMotif.Text = vi.motif;
            textBoxComm.Text = vi.comm;
            textBoxQteMedic.Text = vi.medic_qte.ToString();

            checkBoxParentsPrev.Checked = vi.parents_prev;

            //Ajout d'un médicament 'Aucun' 
            InfirmerieBO.Medicament nomed = new InfirmerieBO.Medicament(0, "(Aucun)", 0);
            List<InfirmerieBO.Medicament> nomedlist = new List<InfirmerieBO.Medicament>();
            nomedlist.Add(nomed);

            //Génération de la liste des médicaments
            comboBoxMedic.DataSource = nomedlist.Concat(ConnexionBLL.getMedicaments("")).ToList();
            //InfirmerieBO.Medicament selectedMedic = ConnexionBLL.getMedicaments("").Find(med => med == vi.medic);

            //Séléction du médicament
            if (vi.medic == null)
            {
                comboBoxMedic.SelectedIndex = 0;
            }
            else
            {
                comboBoxMedic.SelectedItem = vi.medic;
            }

            //Séléction de la suite
            if (vi.suite == "Domicile")
            {
                comboBoxSuite.SelectedIndex = 1;
            }
            if (vi.suite == "Hôpital")
            {
                comboBoxSuite.SelectedIndex = 2;
            }
            else
            {
                comboBoxSuite.SelectedIndex = 0;
            }


            comboBoxSuite.SelectedItem = vi.suite;

            global_vi = vi;
        }
            private void buttonRetour_Click(object sender, EventArgs e)
        {
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

                InfirmerieBO.Visite newvi = new InfirmerieBO.Visite(global_vi.id, global_vi.eleve, medic, qte, date, arrivee, depart, motif, comm, parentsprev, suite, null);
                if (ConnexionBLL.editVisite(newvi))
                {
                    MessageBox.Show("Visite modifiée!");
                }
                else
                {
                    MessageBox.Show("Une erreur est survenue.");
                }
            }

        }

        private void buttonRetour_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Visite v = new Visite();
            v.ShowDialog();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }

        private void buttonDummyAdd_Click_1(object sender, EventArgs e)
        {

        }
    }
}
