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

namespace InfirmerieGUI
{
    public partial class StatsGraphe : Form
    {
        public static string global_annee = "";
        public static List<float> global_stats;
        // [0] : eleve
        // [1] : visite
        // [2] : visiteeleve
        // [3] : medic
        // [4] : medicvisite
        // [5] : tempsvisite
        public StatsGraphe()
        {
            InitializeComponent();
            global_stats = ConnexionBLL.getStats();
            global_annee = "";
            init();
        }
        public StatsGraphe(string annee)
        {
            InitializeComponent();
            global_stats = ConnexionBLL.getStats(annee);
            global_annee = annee;
            init();
        }
        public void init()
        {
            if (global_annee == "")
            {
                labelAnnee.Text = "Statistiques toutes périodes";
            }
            else
            {
                labelAnnee.Text = "Statistiques de l'année "+global_annee;
            }
            labelStatseleve.Text = "Nombre d'élèves : "+global_stats[0].ToString();
            labelStatsvisite.Text = "Nombre de visites : "+global_stats[1].ToString();
            labelStatsvisiteeleve.Text = "Nombre de visites par élève : "+global_stats[2].ToString().Substring(0,3);
            labelStatsmedic.Text = "Nombre de médicaments : "+global_stats[3].ToString();
            labelStatsmedicvisite.Text = "Nombre de médicaments par visite : "+global_stats[4].ToString().Substring(0, 3);
            labelStatstempsvisite.Text = "Durée moyenne d'une visite : "+global_stats[5].ToString()+ "min";
            if (global_stats[5].ToString().Length > 4)
            {
                labelStatstempsvisite.Text = "Durée moyenne d'une visite : " + global_stats[5].ToString().Substring(0,4) + "min";
            }

        }

        private void buttonRetour_Click(object sender, EventArgs e)
        {
            this.Hide();
            Statistique st = new Statistique();
            st.ShowDialog();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
