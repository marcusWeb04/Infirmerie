using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using InfirmerieBLL;
using InfirmerieBO;

namespace InfirmerieGUI
{
    public partial class ListeEleve : Form
    {

        public static List<InfirmerieBO.Eleve> global_eleves;
        public ListeEleve(string cond)
        {
            InitializeComponent();


            //Confirmation de la chaine de connexion à la Base de données via la BLL

            ConnexionBLL.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Infirmerie"]);

          

            // Création d'une en-tête de colonne pour la colonne Nom
            DataGridViewTextBoxColumn NomColumn = new DataGridViewTextBoxColumn();
            NomColumn.DataPropertyName = "nom";
            NomColumn.HeaderText = "Nom";

            // Création d'une en-tête de colonne pour la colonne Prénom
            DataGridViewTextBoxColumn PrenomColumn = new DataGridViewTextBoxColumn();
            PrenomColumn.DataPropertyName = "prenom";
            PrenomColumn.HeaderText = "Prénom";

            // Création d'une en-tête de colonne pour la colonne Classe
            DataGridViewTextBoxColumn ClasseColumn = new DataGridViewTextBoxColumn();
            ClasseColumn.DataPropertyName = "classe";
            ClasseColumn.HeaderText = "Classe";

            // Création d'une en-tête de colonne pour la colonne Naissance
            DataGridViewTextBoxColumn NaissanceColumn = new DataGridViewTextBoxColumn();
            NaissanceColumn.DataPropertyName = "naiss";
            NaissanceColumn.HeaderText = "Naissance";

            // Créez une colonne de bouton personnalisée
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Action";
            buttonColumn.Text = "Séléctionner";
            buttonColumn.UseColumnTextForButtonValue = true; // Affiche le texte du bouton dans chaque cellule




            //Colonne ID Cachée
            DataGridViewTextBoxColumn IdColumn = new DataGridViewTextBoxColumn();
            IdColumn.DataPropertyName = "id";
            IdColumn.Visible = false;
            IdColumn.Name = "id";


            // Ajout des 5 en-têtes de colonne au datagridview
            dgv.Columns.Add(NomColumn);
            dgv.Columns.Add(PrenomColumn);
            dgv.Columns.Add(ClasseColumn);
            dgv.Columns.Add(NaissanceColumn);
            dgv.Columns.Add(buttonColumn);
            dgv.Columns.Add(IdColumn);

            // Définition du style apporté au datagridview
            dgv.ColumnHeadersVisible = true;
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            columnHeaderStyle.BackColor = Color.Gray;
            columnHeaderStyle.Font = new Font("Regular", 10, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            global_eleves = ConnexionBLL.getEleves(cond);
            dgv.DataSource = global_eleves;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void labelBienvenue_Click(object sender, EventArgs e)
        {

        }

        private void buttonRetour_Click(object sender, EventArgs e)
        {
            //Affichage du formulaire de la recherche d'élèves
            this.Hide();
            Eleve Eleve = new Eleve();
            Eleve.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                string selectedValue = dgv.SelectedRows[0].Cells["id"].Value.ToString();
                int selectedId = 0;
                int.TryParse(selectedValue, out selectedId);
                foreach (InfirmerieBO.Eleve el in global_eleves)
                {
                    if (el.id == selectedId)
                    {
                        this.Hide();
                        Modif_Eleve modif = new Modif_Eleve(el);
                        modif.ShowDialog(); 
                    }
                }
            }
        }
    }
}
