using InfirmerieBLL;
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
    public partial class ListeVisite : Form
    {
        public static List<InfirmerieBO.Visite> global_visites;
        public ListeVisite(string nom, string date, int mois)
        {
            InitializeComponent();


            //Confirmation de la chaine de connexion à la Base de données via la BLL

            ConnexionBLL.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Infirmerie"]);

      

            


            // Création d'une en-tête de colonne pour la colonne Nom
            DataGridViewTextBoxColumn NomColumn = new DataGridViewTextBoxColumn();
            NomColumn.DataPropertyName = "eleve";
            NomColumn.HeaderText = "Nom";

            // Création d'une en-tête de colonne pour la colonne Classe
            DataGridViewTextBoxColumn DateColumn = new DataGridViewTextBoxColumn();
            DateColumn.DataPropertyName = "date";
            DateColumn.HeaderText = "Date";

            // Création d'une en-tête de colonne pour la colonne Naissance
            DataGridViewTextBoxColumn HeureDepartColumn = new DataGridViewTextBoxColumn();
            HeureDepartColumn.DataPropertyName = "heure_depart";
            HeureDepartColumn.HeaderText = "Heure";

            // Création d'une en-tête de colonne pour la colonne Naissance
            DataGridViewTextBoxColumn HeureArriveeColumn = new DataGridViewTextBoxColumn();
            HeureArriveeColumn.DataPropertyName = "heure_arrivee";
            HeureArriveeColumn.HeaderText = "Heure";

            // Création d'une en-tête de colonne pour la colonne Naissance
            DataGridViewTextBoxColumn MotifColumn = new DataGridViewTextBoxColumn();
            MotifColumn.DataPropertyName = "motif";
            MotifColumn.HeaderText = "Motif";

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
            dgv.Columns.Add(DateColumn);
            dgv.Columns.Add(HeureDepartColumn);
            dgv.Columns.Add(HeureArriveeColumn);
            dgv.Columns.Add(MotifColumn);
            dgv.Columns.Add(buttonColumn);
            dgv.Columns.Add(IdColumn);

            // Définition du style apporté au datagridview
            dgv.ColumnHeadersVisible = true;
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            columnHeaderStyle.BackColor = Color.Gray;
            columnHeaderStyle.Font = new Font("Regular", 10, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            if (date == "" && mois == 0)
            {
                global_visites = ConnexionBLL.getVisitesNom(nom);
            }

            if (date != "" && mois == 0)
            {
                global_visites = ConnexionBLL.getVisitesDate(nom, date);
            }
            if (date == "" && mois != 0)
            {
                global_visites = ConnexionBLL.getVisitesMois(nom, mois);
            }
            if (date != "" && mois != 0)
            {
                //Retour à la page Visite car condition non respectée
                this.Hide();
                Visite visite = new Visite();
                visite.ShowDialog();
            }
            dgv.AutoGenerateColumns = false;
            dgv.DataSource = global_visites;
        }

        private void labelBienvenue_Click(object sender, EventArgs e)
        {

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonRetour_Click(object sender, EventArgs e)
        {
            //Retour à la page Visite car condition non respectée
            this.Hide();
            Visite visite = new Visite();
            visite.ShowDialog();
        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                string selectedValue = dgv.SelectedRows[0].Cells["id"].Value.ToString();
                int selectedId = 0;
                int.TryParse(selectedValue, out selectedId);
                foreach (InfirmerieBO.Visite vi in global_visites)
                {
                    if (vi.id == selectedId)
                    {
                        this.Hide();
                        Modif_Visite modif = new Modif_Visite(vi);
                        modif.ShowDialog();
                    }
                }
            }
        }
    }
}
