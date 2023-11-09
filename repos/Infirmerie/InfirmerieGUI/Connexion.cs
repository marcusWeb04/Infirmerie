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
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
        }

        private void buttonSeconnecter_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Accueil Accueil = new Accueil();
            Accueil.ShowDialog();
        }
    }
}
