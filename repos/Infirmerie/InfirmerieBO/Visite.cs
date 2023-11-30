using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfirmerieBO
{
    public class Visite
    {
        private int visite_id;
        private Eleve visite_eleve;
        private Medicament? visite_medic;
        private int? visite_medic_qte;
        private string visite_date;
        private string visite_heure_arrivee;
        private string visite_heure_depart;
        private string visite_motif;
        private string? visite_comm;
        private bool visite_parents_prev;
        private string visite_suite;
        private Utilisateur? visite_utilisateur;

        public Visite(int visite_id, Eleve visite_eleve, Medicament? visite_medic, int? visite_medic_qte, string visite_date,
        string visite_heure_arrivee, string visite_heure_depart, string visite_motif, string? visite_comm, bool visite_parents_prev,
        string visite_suite, Utilisateur? visite_utilisateur)
        {
            this.visite_id = visite_id;
            this.visite_eleve = visite_eleve;
            this.visite_medic = visite_medic;
            this.visite_medic_qte = visite_medic_qte;
            this.visite_date = visite_date;
            this.visite_heure_arrivee = visite_heure_arrivee;
            this.visite_heure_depart = visite_heure_depart;
            this.visite_motif = visite_motif;
            this.visite_comm = visite_comm;
            this.visite_parents_prev = visite_parents_prev;
            this.visite_suite = visite_suite;
            this.visite_utilisateur = visite_utilisateur;
        }

        public int id { get => visite_id; set => visite_id = value; }
        public Eleve eleve { get => visite_eleve; set => visite_eleve = value; }
        public Medicament? medic { get => visite_medic; set => visite_medic = value; }
        public int? medic_qte { get => visite_medic_qte; set => visite_medic_qte = value; }
        public string date { get => visite_date; set => visite_date = value; }
        public string heure_depart { get => visite_heure_depart; set => visite_heure_depart = value; }
        public string heure_arrivee { get => visite_heure_arrivee; set => visite_heure_arrivee = value; }
        public string motif { get => visite_motif; set => visite_motif = value; }
        public string? comm { get => visite_comm; set => visite_comm = value; }
        public bool parents_prev { get => visite_parents_prev; set => visite_parents_prev = value; }
        public string suite { get => visite_suite; set => visite_suite = value; }
        public Utilisateur? utilisateur { get => visite_utilisateur; set => visite_utilisateur = value; }
    }
}
