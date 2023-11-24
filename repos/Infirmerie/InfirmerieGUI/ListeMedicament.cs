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
    public partial class ListeMedicament : Form
    {
        public static List<InfirmerieBO.Medicament> global_medicaments;
        public ListeMedicament(string cond)
        {
            InitializeComponent();


            //Confirmation de la chaine de connexion à la Base de données via la BLL

            ConnexionBLL.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Infirmerie"]);

            //Colonne ID Cachée
            DataGridViewTextBoxColumn LibColumn = new DataGridViewTextBoxColumn();
            LibColumn.HeaderText = "Nom du médicament";
            LibColumn.DataPropertyName = "lib";
            LibColumn.Name = "Libele";

            //Colonne ID Cachée
            DataGridViewTextBoxColumn NbColumn = new DataGridViewTextBoxColumn();
            NbColumn.HeaderText = "Nombre d'utilisation";
            NbColumn.DataPropertyName = "nb";
            NbColumn.Name = "nb";

            // Créez une colonne de bouton personnalisée
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Action";
            buttonColumn.Text = "voir";
            buttonColumn.UseColumnTextForButtonValue = true; // Affiche le texte du bouton dans chaque cellule

            //Colonne ID Cachée
            DataGridViewTextBoxColumn IdColumn = new DataGridViewTextBoxColumn();
            IdColumn.DataPropertyName = "id";
            IdColumn.Visible = false;
            IdColumn.Name = "id";

            // Ajout des 5 en-têtes de colonne au datagridview

            dgv.Columns.Add(LibColumn);
            dgv.Columns.Add(NbColumn);
            dgv.Columns.Add(buttonColumn);
            dgv.Columns.Add(IdColumn);

            // Définition du style apporté au datagridview
            dgv.ColumnHeadersVisible = true;
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            columnHeaderStyle.BackColor = Color.Gray;
            columnHeaderStyle.Font = new Font("Regular", 10, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            global_medicaments = ConnexionBLL.getMedicaments(cond);
            dgv.DataSource = global_medicaments;
        }

        private void ListeMedicament_Load(object sender, EventArgs e)
        {

        }

        private void buttonRetour_Click(object sender, EventArgs e)
        {
            //Affichage du formulaire de la recherche d'élèves
            this.Hide();
            Medicament Medicament = new Medicament();
            Medicament.ShowDialog();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                string selectedValue = dgv.SelectedRows[0].Cells["id"].Value.ToString();
                int selectedId = 0;
                int.TryParse(selectedValue, out selectedId);

                //Recherche du médicament correspondant
                foreach (InfirmerieBO.Medicament med in global_medicaments)
                {
                    if (med.id == selectedId)
                    {
                        //Ouverture de la modif
                        this.Hide();
                        Modif_Medicament modif = new Modif_Medicament(med);
                        modif.ShowDialog();
                    }
                }
            }
        }
    }
}
