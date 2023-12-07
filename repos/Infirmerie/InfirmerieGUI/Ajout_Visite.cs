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
            InitializeComponent();
            textBoxNom.Text = el.nom;
            textBoxPrenom.Text = el.prenom;
            textBoxClasse.Text = el.classe.lib;
            textBoxAge.Text = el.naiss;
            comboBoxMedic.DataSource = ConnexionBLL.getMedicaments("");
            comboBoxSuite.SelectedIndex = 0;
            global_el = el;
        }

        private void buttonDummyAdd_Click(object sender, EventArgs e)
        {
            string date = textBoxDate.Text;
            string arrivee = textBoxHeureArrivee.Text;
            string depart = textBoxHeureDepart.Text;
            string suite = comboBoxSuite.SelectedItem.ToString();
            string motif = textBoxMotif.Text;
            string comm = textBoxComm.Text;

            InfirmerieBO.Medicament medic = comboBoxMedic.SelectedItem as InfirmerieBO.Medicament;

            string qte = textBoxQteMedic.Text;
            bool parentsprev = checkBoxParentsPrev.Checked;

            if (date == "" || arrivee == "" || depart == "" || motif == "")
            {
                MessageBox.Show("Veuillez remplir les champs obligatoires.");
            }
            else
            {
                InfirmerieBO.Visite vi = new InfirmerieBO.Visite(0, global_el, medic, Int32.Parse(qte), date, arrivee, depart, motif, comm, parentsprev, suite, null);
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
