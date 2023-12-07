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
    }
}
