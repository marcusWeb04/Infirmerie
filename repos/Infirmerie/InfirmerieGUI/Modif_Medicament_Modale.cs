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
    public partial class Modif_Medicament_Modale : Form
    {
        private static InfirmerieBO.Medicament medicament;
        private static Modif_Medicament modif;
        public InfirmerieBO.Medicament global_med { get => medicament; set => medicament = value; }
        public Modif_Medicament global_modif { get => modif; set => modif = value; }
    
        public Modif_Medicament_Modale(InfirmerieBO.Medicament med, Modif_Medicament modif)
        {
            InitializeComponent();
            global_med = med;
            global_modif = modif;
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            this.Close();
            if (ConnexionBLL.deleteMedicament(global_med))
            {
                MessageBox.Show("Médicament supprimé.");
                Medicament medicament = new Medicament();
                medicament.ShowDialog();
                global_modif.Close();
            }
            else
            {
                MessageBox.Show("Une erreur est survenue.");
            }
        }

        private void labelBienvenue_Click(object sender, EventArgs e)
        {

        }
    }
}
