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
        public static bool GetUtilisateur(Utilisateur uti) 
        {
            return ConnexionBDD.GetUtilisateur(uti);
        }
        

        //Élève


        public static bool addEleve(Eleve el)
        {
            return ConnexionBDD.addEleve(el);
        }
        public static bool editEleve(Eleve el)
        {
            return ConnexionBDD.editEleve(el);
        }
        public static bool deleteEleve(Eleve el)
        {
            return ConnexionBDD.deleteEleve(el);
        }
        public static List<Eleve> getEleves(string condition)
        {
            return ConnexionBDD.getEleves(condition);
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

        //BLL
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

        //Contrôles de saisie
        public static bool saisieTexte(string input)
        {
            //Liste de caractères autorisés
            List<char> checklist = new List<char>
                { 'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z',
                'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z',
                '-','é','è','ê','ë','É','È','Ê','Ë' };
            foreach (char c in input)
            {
                //Si un caractère qui n'est pas dans la liste est trouvé, false
                if (!checklist.Contains(c)) 
                {
                    return false;
                }
            }
            return true;
        }
        public static bool saisieTel(string input)
        {
            int length = input.Length;
            //Liste de caractères autorisés
            List<char> checklist = new List<char>
                { '0','1','2','3','4','5','6','7','8','9','+',' '};
            foreach (char c in input)
            {
                if (!checklist.Contains(c))
                {
                    //Si un caractère qui n'est pas dans la liste est trouvé, false
                    return false;
                }
                if (c == ' ' || c == '+')
                {
                    //On déduit les espaces et + de la longueur du n° pour vérifier la longeur avec précision
                    length -= 1;
                }
            }
            if (length < 10)
            {
                return false;
            }
            return true;
        }
    }
}
