using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
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
        public static bool addEleve(Eleve eleve)
        {
            //Connexion à la BDD
            int res;
            SqlConnection maConnexion = ConnexionBDD.GetConnexion().GetSqlConnexion();

            //Création de la requête
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText =
                "INSERT INTO eleve (eleve_nom, eleve_prenom, eleve_naiss, eleve_port, eleve_parent_port, eleve_classe, eleve_tiers_temps, eleve_comm_sante)" +
                "VALUES (@nom, @prenom, @naiss, @port, @parent_port, @classe, @tiers_temps, @comm_sante)";
            cmd.Parameters.AddWithValue("@nom", eleve.nom);
            cmd.Parameters.AddWithValue("@prenom", eleve.prenom);
            cmd.Parameters.AddWithValue("@naiss", eleve.naiss);
            cmd.Parameters.AddWithValue("@port", eleve.port);
            cmd.Parameters.AddWithValue("@parent_port", eleve.parent_port);
            cmd.Parameters.AddWithValue("@classe", eleve.classe);
            cmd.Parameters.AddWithValue("@tiers_temps", eleve.tiers_temps);

            // Cas spécial : insertion d'un null en BDD
            if (eleve.comm_sante == null)
            {
                cmd.Parameters.AddWithValue("@comm_sante", DBNull.Value);
            }
            else
            {
                cmd.Parameters.AddWithValue("@comm_sante", eleve.comm_sante);
            }

            //Execution de la requête
            res = cmd.ExecuteNonQuery();

            if (res == 1)
            {
                return true;
            }
            return false;
        }
        public static bool deleteEleve(Eleve eleve)
        {
            //Connexion à la BDD
            int res;
            SqlConnection maConnexion = ConnexionBDD.GetConnexion().GetSqlConnexion();

            //Création de la requête
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText =
                "DELETE FROM eleve " +
                "WHERE eleve_id = @id";
            cmd.Parameters.AddWithValue("@id", eleve.id);

            //Execution de la requête
            res = cmd.ExecuteNonQuery();

            if (res == 1)
            {
                return true;
            }
            return false;
        }
        public static bool editEleve(Eleve eleve)
        {
            int res;
            SqlConnection maConnexion = ConnexionBDD.GetConnexion().GetSqlConnexion();

            //Création de la requête
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText =
                "UPDATE eleve SET [eleve_nom] = @nom," +
                "[eleve_prenom] = @prenom," +
                "[eleve_naiss] = @naiss," +
                "[eleve_port] = @port," +
                "[eleve_parent_port] = @parent_port," +
                "[eleve_classe] = @classe," +
                "[eleve_tiers_temps] = @tiers_temps," +
                "[eleve_comm_sante] = @comm_sante " +
                "WHERE [eleve_id] = @id";
            cmd.Parameters.AddWithValue("@id", eleve.id);
            cmd.Parameters.AddWithValue("@nom", eleve.nom);
            cmd.Parameters.AddWithValue("@prenom", eleve.prenom);
            cmd.Parameters.AddWithValue("@naiss", eleve.naiss);
            cmd.Parameters.AddWithValue("@port", eleve.port);
            cmd.Parameters.AddWithValue("@parent_port", eleve.parent_port);
            cmd.Parameters.AddWithValue("@classe", eleve.classe);
            cmd.Parameters.AddWithValue("@tiers_temps", eleve.tiers_temps);

            // Cas spécial : insertion d'un null en BDD
            if (eleve.comm_sante == null)
            {
                cmd.Parameters.AddWithValue("@comm_sante", DBNull.Value);
            }
            else
            {
                cmd.Parameters.AddWithValue("@comm_sante", eleve.comm_sante);
            }

            //Execution de la requête
            res = cmd.ExecuteNonQuery();

            if (res == 1)
            {
                return true;
            }
            return false;
        }
        public static List<Eleve> getEleves(string condition)
        {
            //Connexion à la BDD
            List<Eleve> res = new List<Eleve>();
            SqlConnection maConnexion = ConnexionBDD.GetConnexion().GetSqlConnexion();

            //Création de la requête
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText =
                "SELECT * FROM eleve " +
                "WHERE eleve_prenom LIKE @cond " +
                "OR eleve_nom LIKE @cond";
            cmd.Parameters.AddWithValue("@cond", "%" + condition + "%");

            //Execution de la requête
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                //Création d'un objet Eleve et ajout de l'objet dans la liste de retour
                int id = Int32.Parse(reader["eleve_id"].ToString());
                string nom = reader["eleve_nom"].ToString();
                string prenom = reader["eleve_prenom"].ToString();
                string naiss = reader["eleve_naiss"].ToString();
                int port = Int32.Parse(reader["eleve_port"].ToString());
                int parent_port = Int32.Parse(reader["eleve_parent_port"].ToString());
                int classe = Int32.Parse(reader["eleve_classe"].ToString());
                bool tiers_temps = false;
                if (reader["eleve_classe"].ToString() == "1")
                {
                    tiers_temps = true;
                }
                string comm_sante = reader["eleve_comm_sante"].ToString();

                Eleve temp = new Eleve(id, nom, prenom, naiss, port, parent_port, classe, tiers_temps, comm_sante);
                res.Add(temp);
            }
            return res;
        }
        public static List<Classe> getClasses()
        {
            //Connexion à la BDD
            List<Classe> res = new List<Classe>();
            SqlConnection maConnexion = ConnexionBDD.GetConnexion().GetSqlConnexion();

            //Création de la requête
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText =
                "SELECT * " +
                "FROM classe";

            //Execution de la requête
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                //Création d'un objet Classe et ajout de l'objet dans la liste de retour
                int id = Int32.Parse(reader["classe_id"].ToString());
                string nom = reader["classe_lib"].ToString();

                Classe temp = new Classe(id, nom);
                res.Add(temp);
            }
            return res;
        }
    }
}