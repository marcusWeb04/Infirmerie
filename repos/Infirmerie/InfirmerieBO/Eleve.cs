using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#nullable enable

namespace InfirmerieBO
{
    //Attributs
    public class Eleve
    {
        private int eleve_id;
        private string eleve_nom;
        private string eleve_prenom;
        private string eleve_naiss;
        private int eleve_port;
        private int eleve_parent_port;
        private Classe eleve_classe;
        private bool eleve_tiers_temps;
        private string? eleve_comm_sante;

        //Constructeur
        public Eleve(int eleve_id, string eleve_nom, string eleve_prenom, string eleve_naiss, int eleve_port, int eleve_parent_port, Classe eleve_classe, 
            bool eleve_tiers_temps, string? eleve_comm_sante)
        {
            this.eleve_id = eleve_id;
            this.eleve_nom = eleve_nom;
            this.eleve_prenom = eleve_prenom;
            this.eleve_naiss = eleve_naiss;
            this.eleve_port = eleve_port;
            this.eleve_parent_port = eleve_parent_port;
            this.eleve_classe = eleve_classe;
            this.eleve_tiers_temps = eleve_tiers_temps;
            this.eleve_comm_sante = eleve_comm_sante;
        }

        // Getter/Setters
        public int id { get => eleve_id; set => eleve_id = value; }
        public string nom { get => eleve_nom; set => eleve_nom = value; }
        public string prenom { get => eleve_prenom; set => eleve_prenom = value; }
        public string naiss { get => eleve_naiss; set => eleve_naiss = value; }
        public int port { get => eleve_port; set => eleve_port = value; }
        public int parent_port { get => eleve_parent_port; set => eleve_parent_port = value; }
        public Classe classe { get => eleve_classe; set => eleve_classe = value; }
        public bool tiers_temps { get => eleve_tiers_temps; set => eleve_tiers_temps = value; }
        public string? comm_sante { get => eleve_comm_sante; set => eleve_comm_sante = value; }
    }
}
