using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using InfirmerieDAL;
using InfirmerieBO;

namespace InfirmerieBLL
{
    public class ConnexionBLL
    {
        private static ConnexionBLL uneConnexionBLL;

        public static ConnexionBLL GetConnexionBLL()
        {
            if (uneConnexionBLL == null)
            {
                uneConnexionBLL = new ConnexionBLL();
            }
            return uneConnexionBLL;
        }

        //Méthode qui permet d'initialiser la chaîne de connexion requise en BDD
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBDD.GetConnexion().SetchaineConnexion(chaine);
        }

        //Référence à la couche DAL

        //Utilisateur
        public static bool GetUtilisateur(Utilisateur uti)
        {
            return ConnexionBDD.GetUtilisateur(uti);
        }

        //Elève
        
        public static bool addEleve(Eleve el)
        {
            return ConnexionBDD.addEleve(el);
        }
        public static bool deleteEleve(Eleve el)
        {
            return ConnexionBDD.deleteEleve(el);
        }
        public static bool editEleve(Eleve el)
        {
            return ConnexionBDD.editEleve(el);
        }
        public static List<Eleve> getEleves(string cond)
        {
            return ConnexionBDD.getEleves(cond);
        }
        public static List<Classe> getClasses()
        {
            return ConnexionBDD.getClasses();
        }

        //Médicament

        public static bool addMedicament(Medicament med)
        {
            return ConnexionBDD.addMedicament(med);
        }
        public static bool deleteMedicament(Medicament med)
        {
            return ConnexionBDD.deleteMedicament(med);
        }
        public static bool editMedicament(Medicament med)
        {
            return ConnexionBDD.editMedicament(med);
        }
        public static List<Medicament> getMedicaments(string cond)
        {
            return ConnexionBDD.getMedicaments(cond);
        }

        //Visite

        public static bool addVisite(Visite vi)
        {
            return ConnexionBDD.addVisite(vi);
        }
        public static bool deleteVisite(Visite vi)
        {
            return ConnexionBDD.deleteVisite(vi);
        }
        public static bool editVisite(Visite vi)
        {
            return ConnexionBDD.editVisite(vi);
        }
        public static List<Visite> getVisitesDate(string cond, string cond2)
        {
            return ConnexionBDD.getVisitesDate(cond, cond2);
        }
        public static List<Visite> getVisitesMois(string cond, int cond2)
        {
            return ConnexionBDD.getVisitesMois(cond, cond2);
        }

        public static List<Visite> getVisitesNom(string cond)
        {
            return ConnexionBDD.getVisitesNom(cond);
        }

        //Stats

        public static List<float> getStats()
        {
            float stateleve = ConnexionBDD.getStatsEleve();
            float statvisite = ConnexionBDD.getStatsVisite();
            float statvisiteeleve = statvisite / stateleve;
            float statmedic = ConnexionBDD.getStatsMedic();
            float statmedicvisite = ConnexionBDD.getStatsMedicVisite();
            float stattempsvisite = ConnexionBDD.getStatsTempsVisite();

            return (new List<float>() 
            { stateleve, statvisite, statvisiteeleve, statmedic, statmedicvisite, stattempsvisite } );
        }
        public static List<float> getStats(string annee)
        {
            float stateleve = ConnexionBDD.getStatsEleve();
            float statvisite = ConnexionBDD.getStatsVisite(annee);
            float statvisiteeleve = statvisite / stateleve;
            float statmedic = ConnexionBDD.getStatsMedic();
            float statmedicvisite = ConnexionBDD.getStatsMedicVisite(annee);
            float stattempsvisite = ConnexionBDD.getStatsTempsVisite(annee);

            return (new List<float>()
            { stateleve, statvisite, statvisiteeleve, statmedic, statmedicvisite, stattempsvisite });
        }

        //Fonctions supplémentaires

        public static bool validateName(string name)
        {
            List<char> chars = new List<char>();
            for (int i = 65; i <= 90; i++)
            {
                chars.Add((char)i);
                chars.Add((char)(i + 32));
            }
            chars.Concat(new List<char>(){' ','-','\'','é','è','ê','ë','É','È','Ê','Ë'});

            foreach (char c in name)
            {
                if (!chars.Contains(c))
                {
                    return false;
                }
            }
            return true;
        }
        public static bool validatePhone(string phone)
        {
            //Formats acceptés : 
            // 0688888888
            // 06 88 88 88 88
            // +33688888888
            // +336 88 88 88 88
            // 0033688888888
            // 00 33 6 88 88 88 88

            List<char> chars = new List<char>() {' ','+','0','1','2','3','4','5','6','7','8','9'};
            int length = phone.Length;

            foreach (char c in phone)
            {
                if (!chars.Contains(c))
                {
                    return false;
                }
                if (c == ' ' || c == '+')
                {
                    length--;
                }
            }
            if (length > 14 || length < 10)
            //Minimum : 10 (06 88 88 88 88)
            //Maxiumum : 13 (+123 6 88 88 88 88
            {
                return false;
            }

            return true;
        }
    }
}
