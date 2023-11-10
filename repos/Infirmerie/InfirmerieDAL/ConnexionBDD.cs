using System;
using System.Data.SqlClient;

using InfirmerieBO;

namespace InfirmerieDAL
{
    public class ConnexionBDD
    {
        private SqlConnection Gestion_Infirmerie;
        private static ConnexionBDD uneConnexion;
        private string chaineConnexion;

        // Getter/setter de la chaîne de connexion à la BDD
        public string GetchaineConnexion()
        {
            return chaineConnexion;
        }

        public void SetchaineConnexion(string ch)
        {
            chaineConnexion = ch;
        }

        // Méthodes d'initialisation de la connexion à la BDD
        public static ConnexionBDD GetConnexion()
        {
            if (uneConnexion == null)
            {
                uneConnexion = new ConnexionBDD();
            }
            return uneConnexion;
        }

        private ConnexionBDD()
        {

        }

        public SqlConnection GetSqlConnexion()
        {
            if (Gestion_Infirmerie == null)
            {
                Gestion_Infirmerie = new SqlConnection();
            }
            Gestion_Infirmerie.ConnectionString = chaineConnexion;

            if (Gestion_Infirmerie.State == System.Data.ConnectionState.Closed)
            {
                Gestion_Infirmerie.Open();
            }
            return Gestion_Infirmerie;
        }

        public void CloseConnexion()
        {
            if (this.Gestion_Infirmerie != null && this.Gestion_Infirmerie.State != System.Data.ConnectionState.Closed)
            {
                this.Gestion_Infirmerie.Close();
            }
        }

        // Méthode d'authentification
        public static bool GetUtilisateur(Utilisateur uti)
        {
            //Connexion à la BDD
            SqlConnection maConnexion = ConnexionBDD.GetConnexion().GetSqlConnexion();

            //Création de la requête
            SqlCommand cmd = new SqlCommand();
            SqlDataReader result;
            cmd.Connection = maConnexion;
            cmd.CommandText =
                "SELECT * FROM utilisateur WHERE utilisateur_login = @login AND utilisateur_mdp = @mdp ";
            cmd.Parameters.AddWithValue("@login", uti.login);
            cmd.Parameters.AddWithValue("@mdp", uti.mdp);
            
            //Exécution de la requête et récupération du résultat
            result = cmd.ExecuteReader();
            bool res = result.HasRows;
            maConnexion.Close();

            return (res);
        }
    }
}