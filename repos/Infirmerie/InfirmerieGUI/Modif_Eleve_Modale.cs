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
    public partial class Modif_Eleve_Modale : Form
    {
        private static InfirmerieBO.Eleve eleve;
        private static Modif_Eleve modif;
        public InfirmerieBO.Eleve global_el { get => eleve; set => eleve = value; }
        public Modif_Eleve global_modif { get => modif; set => modif = value; }


        public Modif_Eleve_Modale(InfirmerieBO.Eleve el, Modif_Eleve modif)
        {
            InitializeComponent();
            global_el = el;
            global_modif = modif;
        }

        private void Modif_Eleve_Modale_Load(object sender, EventArgs e)
        {

        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            this.Close();
            if (ConnexionBLL.deleteEleve(global_el))
            {
                MessageBox.Show("Élève supprimé.");
                Eleve eleve = new Eleve();
                eleve.ShowDialog();
                global_modif.Close();
            }
            else
            {
                MessageBox.Show("Une erreur est survenue.");
            }
        }
    }
}
