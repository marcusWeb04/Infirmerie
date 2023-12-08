using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using InfirmerieBO;
using System.Globalization;

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





        // Authentification





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




        // Eleve





        public static bool addEleve(Eleve eleve)
        {
            //Connexion à la BDD
            int res;
            SqlConnection maConnexion = ConnexionBDD.GetConnexion().GetSqlConnexion();

            //Conversion de la date
            DateTime? naisscv = dateFormat(eleve.naiss);
            if (naisscv == null)
            {
                return false;
            }

            //Création de la requête
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText =
                "INSERT INTO eleve (eleve_nom, eleve_prenom, eleve_naiss, eleve_port, eleve_parent_port, eleve_classe, eleve_tiers_temps, eleve_comm_sante)" +
                "VALUES (@nom, @prenom, @naiss, @port, @parent_port, @classe, @tiers_temps, @comm_sante)";
            cmd.Parameters.AddWithValue("@nom", eleve.nom);
            cmd.Parameters.AddWithValue("@prenom", eleve.prenom);
            cmd.Parameters.AddWithValue("@naiss", naisscv);
            cmd.Parameters.AddWithValue("@port", eleve.port);
            cmd.Parameters.AddWithValue("@parent_port", eleve.parent_port);
            cmd.Parameters.AddWithValue("@classe", eleve.classe.id);
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
            maConnexion.Close();

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
            maConnexion.Close();

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

            //Conversion de la date
            DateTime? naisscv = dateFormat(eleve.naiss);
            if (naisscv == null)
            {
                return false;
            }

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
            cmd.Parameters.AddWithValue("@naiss", naisscv);
            cmd.Parameters.AddWithValue("@port", eleve.port);
            cmd.Parameters.AddWithValue("@parent_port", eleve.parent_port);
            cmd.Parameters.AddWithValue("@classe", eleve.classe.id);
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
            maConnexion.Close();

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
                "JOIN classe ON eleve_classe = classe_id " +
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
                int classeid = Int32.Parse(reader["eleve_classe"].ToString());
                string classelib = reader["classe_lib"].ToString();
                bool tiers_temps = false;
                if (reader["eleve_tiers_temps"].ToString() == "True")
                {
                    tiers_temps = true;
                }
                string comm_sante = reader["eleve_comm_sante"].ToString();

                Eleve temp = new Eleve(id, nom, prenom, naiss, port, parent_port, new Classe(classeid, classelib), tiers_temps, comm_sante);
                res.Add(temp);
            }
            maConnexion.Close();
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
            maConnexion.Close();
            return res;
        }




        // Medicament




        public static bool addMedicament(Medicament med)
        {
            //Connexion à la BDD
            int res;
            SqlConnection maConnexion = ConnexionBDD.GetConnexion().GetSqlConnexion();

            //Création de la requête
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText =
                "INSERT INTO medicament (medic_lib)" +
                "VALUES (@lib)";
            cmd.Parameters.AddWithValue("@lib", med.lib);

            //Execution de la requête
            res = cmd.ExecuteNonQuery();
            maConnexion.Close();

            if (res == 1)
            {
                return true;
            }
            return false;
        }
        public static bool deleteMedicament(Medicament med)
        {
            //Connexion à la BDD
            int res;
            SqlConnection maConnexion = ConnexionBDD.GetConnexion().GetSqlConnexion();

            //Création de la requête
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText =
                "DELETE FROM medicament " +
                "WHERE medic_id = @id";
            cmd.Parameters.AddWithValue("@id", med.id);

            //Execution de la requête
            res = cmd.ExecuteNonQuery();
            maConnexion.Close();

            if (res == 1)
            {
                return true;
            }
            return false;
        }
        public static bool editMedicament(Medicament med)
        {
            int res;
            SqlConnection maConnexion = ConnexionBDD.GetConnexion().GetSqlConnexion();

            //Création de la requête
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText =
                "UPDATE medicament SET [medic_lib] = @lib " +
                "WHERE [medic_id] = @id";
            cmd.Parameters.AddWithValue("@id", med.id);
            cmd.Parameters.AddWithValue("@lib", med.lib);

            //Execution de la requête
            res = cmd.ExecuteNonQuery();
            maConnexion.Close();

            if (res == 1)
            {
                return true;
            }
            return false;
        }
        public static List<Medicament> getMedicaments(string condition)
        {
            //Connexion à la BDD
            List<Medicament> res = new List<Medicament>();
            SqlConnection maConnexion = ConnexionBDD.GetConnexion().GetSqlConnexion();

            //Création de la requête
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText =
                "SELECT * FROM medicament " +
                "WHERE medic_lib LIKE @cond";
            cmd.Parameters.AddWithValue("@cond", "%" + condition + "%");

            //Execution de la requête
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                //Création d'un objet Medicament et ajout de l'objet dans la liste de retour
                int id = Int32.Parse(reader["medic_id"].ToString());
                string lib = reader["medic_lib"].ToString();

                Medicament temp = new Medicament(id, lib, 0);
                res.Add(temp);
            }
            maConnexion.Close();
            return res;
        }




        // Visite




        public static bool addVisite(Visite visite)
        {
            //Connexion à la BDD
            int res;
            SqlConnection maConnexion = ConnexionBDD.GetConnexion().GetSqlConnexion();

            //Conversion de la date
            DateTime? datecv = dateFormat(visite.date);
            if (datecv == null)
            {
                return false;
            }

            //Création de la requête
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText =
                "INSERT INTO visite (visite_eleve, visite_medic, visite_medic_qte, visite_date, visite_heure_arrivee, visite_heure_depart, " +
                "visite_motif, visite_comm, visite_parents_prev, visite_suite, visite_utilisateur) " +
                "VALUES (@visite_eleve, @visite_medic, @visite_medic_qte, @visite_date, @visite_heure_arrivee, @visite_heure_depart, " +
                "@visite_motif, @visite_comm, @visite_parents_prev, @visite_suite, @visite_utilisateur);";

            cmd.Parameters.AddWithValue("@visite_eleve", visite.eleve.id);
            cmd.Parameters.AddWithValue("@visite_date", datecv);
            cmd.Parameters.AddWithValue("@visite_heure_arrivee", TimeSpan.Parse(visite.heure_arrivee));
            cmd.Parameters.AddWithValue("@visite_heure_depart", TimeSpan.Parse(visite.heure_depart));
            cmd.Parameters.AddWithValue("@visite_motif", visite.motif);
            cmd.Parameters.AddWithValue("@visite_parents_prev", visite.parents_prev);
            cmd.Parameters.AddWithValue("@visite_suite", visite.suite);
            cmd.Parameters.AddWithValue("@id", visite.id);

            // Cas spécial : insertion de null en BDD
            if (visite.utilisateur == null)
            { cmd.Parameters.AddWithValue("@visite_utilisateur", DBNull.Value); }
            else { cmd.Parameters.AddWithValue("@visite_utilisateur", visite.utilisateur.login); }

            if (visite.comm == "")
            { cmd.Parameters.AddWithValue("@visite_comm", DBNull.Value); }
            else { cmd.Parameters.AddWithValue("@visite_comm", visite.comm); }

            if (visite.medic == null)
            { cmd.Parameters.AddWithValue("@visite_medic", DBNull.Value); }
            else { cmd.Parameters.AddWithValue("@visite_medic", visite.medic.id); }

            if (visite.medic_qte == null)
            { cmd.Parameters.AddWithValue("@visite_medic_qte", DBNull.Value); }
            else { cmd.Parameters.AddWithValue("@visite_medic_qte", visite.medic_qte); }

            //Execution de la requête
            res = cmd.ExecuteNonQuery();
            maConnexion.Close();

            if (res == 1)
            {
                return true;
            }
            return false;
        }

        public static bool editVisite(Visite visite)
        {
            //Connexion à la BDD
            int res;
            SqlConnection maConnexion = ConnexionBDD.GetConnexion().GetSqlConnexion();

            //Conversion de la date
            DateTime? datecv = dateFormat(visite.date);
            if (datecv == null)
            {
                return false;
            }

            //Création de la requête
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText =
                "UPDATE visite SET [visite_eleve] = @visite_eleve," +
                "[visite_medic] = @visite_medic," +
                "[visite_medic_qte] = @visite_medic_qte," +
                "[visite_date] = @visite_date," +
                "[visite_heure_arrivee] = @visite_heure_arrivee," +
                "[visite_heure_depart] = @visite_heure_depart," +
                "[visite_motif] = @visite_motif," +
                "[visite_comm] = @visite_comm, " +
                "[visite_parents_prev] = @visite_parents_prev, " +
                "[visite_suite] = @visite_suite, " +
                "[visite_utilisateur] = @visite_utilisateur " +

                "WHERE [visite_id] = @id";
            cmd.Parameters.AddWithValue("@visite_eleve", visite.eleve.id);
            cmd.Parameters.AddWithValue("@visite_date", datecv);
            cmd.Parameters.AddWithValue("@visite_heure_arrivee", TimeSpan.Parse(visite.heure_arrivee));
            cmd.Parameters.AddWithValue("@visite_heure_depart", TimeSpan.Parse(visite.heure_depart));
            cmd.Parameters.AddWithValue("@visite_motif", visite.motif);
            cmd.Parameters.AddWithValue("@visite_parents_prev", visite.parents_prev);
            cmd.Parameters.AddWithValue("@visite_suite", visite.suite);
            cmd.Parameters.AddWithValue("@id", visite.id);

            // Cas spécial : insertion de null en BDD
            if (visite.utilisateur == null)
            { cmd.Parameters.AddWithValue("@visite_utilisateur", DBNull.Value); }
            else { cmd.Parameters.AddWithValue("@visite_utilisateur", visite.utilisateur.login); }

            if (visite.comm == "")
            { cmd.Parameters.AddWithValue("@visite_comm", DBNull.Value); }
            else { cmd.Parameters.AddWithValue("@visite_comm", visite.comm); }

            if (visite.medic == null)
            { cmd.Parameters.AddWithValue("@visite_medic", DBNull.Value); }
            else { cmd.Parameters.AddWithValue("@visite_medic", visite.medic.id); }

            if (visite.medic_qte == null)
            { cmd.Parameters.AddWithValue("@visite_medic_qte", DBNull.Value); }
            else { cmd.Parameters.AddWithValue("@visite_medic_qte", visite.medic_qte); }

            //Execution de la requête
            res = cmd.ExecuteNonQuery();
            maConnexion.Close();

            if (res == 1)
            {
                return true;
            }
            return false;
        }

        public static bool deleteVisite(Visite visite)
        {
            //Connexion à la BDD
            int res;
            SqlConnection maConnexion = ConnexionBDD.GetConnexion().GetSqlConnexion();

            //Création de la requête
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText =
                "DELETE FROM visite " +
                "WHERE visite_id = @id";
            cmd.Parameters.AddWithValue("@id", visite.id);

            //Execution de la requête
            res = cmd.ExecuteNonQuery();
            maConnexion.Close();

            if (res == 1)
            {
                return true;
            }
            return false;
        }
        
        public static List<Visite> getVisitesDate(string cond_nom, string cond_date)
        {
            //Connexion à la BDD
            SqlConnection maConnexion = ConnexionBDD.GetConnexion().GetSqlConnexion();

            //Création de la requête
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText =
                "SELECT * FROM visite v " +
                "JOIN eleve e ON v.visite_eleve = e.eleve_id " +
                "JOIN medicament m ON v.visite_medic = m.medic_id " +
                "WHERE (e.eleve_prenom LIKE @nom " +
                "OR e.eleve_nom LIKE @nom ) " +
                "AND v.visite_date = @date ";

            cmd.Parameters.AddWithValue("@nom", "%" + cond_nom + "%");
            cmd.Parameters.AddWithValue("@date", cond_date);

            //Execution de la requête
            SqlDataReader reader = cmd.ExecuteReader();
            return getVisites(reader, maConnexion);
        }
        public static List<Visite> getVisitesMois(string cond_nom, int cond_mois)
        {
            //Connexion à la BDD
            SqlConnection maConnexion = ConnexionBDD.GetConnexion().GetSqlConnexion();
            int year = DateTime.Now.Year;

            DateTime date_inf = new DateTime(year, cond_mois, 1);
            DateTime date_sup = new DateTime(year, cond_mois+1, 1);

            //Création de la requête
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText =
                "SELECT * FROM visite v " +
                "JOIN eleve e ON v.visite_eleve = e.eleve_id " +
                "JOIN medicament m ON v.visite_medic = m.medic_id " +
                "JOIN classe c on e.eleve_classe = c.classe_id " +
                "WHERE (e.eleve_prenom LIKE @nom " +
                "OR e.eleve_nom LIKE @nom ) " +
                "AND v.visite_date >= @date_inf " +
                "AND v.visite_date < @date_sup ";

            cmd.Parameters.AddWithValue("@nom", "%" + cond_nom + "%");
            cmd.Parameters.AddWithValue("@date_inf", date_inf);
            cmd.Parameters.AddWithValue("@date_sup", date_sup);

            //Execution de la requête
            SqlDataReader reader = cmd.ExecuteReader();
            return getVisites(reader, maConnexion);
        }
        public static List<Visite> getVisitesNom(string cond_nom)
        {
            //Connexion à la BDD
            SqlConnection maConnexion = ConnexionBDD.GetConnexion().GetSqlConnexion();

            //Création de la requête
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText =
                "SELECT * FROM visite v " +
                "JOIN eleve e ON v.visite_eleve = e.eleve_id " +
                "JOIN medicament m ON v.visite_medic = m.medic_id " +
                "JOIN classe c on e.eleve_classe = c.classe_id " +
                "WHERE (e.eleve_prenom LIKE @nom " +
                "OR e.eleve_nom LIKE @nom ) ";

            cmd.Parameters.AddWithValue("@nom", "%" + cond_nom + "%");

            //Execution de la requête
            SqlDataReader reader = cmd.ExecuteReader();
            return getVisites(reader, maConnexion);
        }
        public static List<Visite> getVisites(SqlDataReader reader, SqlConnection maConnexion)
        {
            List<Visite> res = new List<Visite>();
            while (reader.Read())
            {
                //Création d'un objet Visite et ajout de l'objet dans la liste de retour
                int id = Int32.Parse(reader["visite_id"].ToString());
                int medic_qte = Int32.Parse(reader["visite_medic_qte"].ToString());
                DateTime date = DateTime.Parse(reader["visite_date"].ToString());
                TimeSpan heure_arrivee = TimeSpan.Parse(reader["visite_heure_arrivee"].ToString());
                TimeSpan heure_depart = TimeSpan.Parse(reader["visite_heure_depart"].ToString());
                string motif = reader["visite_motif"].ToString();
                string comm = reader["visite_comm"].ToString();
                bool parents_prev = false;
                if (reader["visite_parents_prev"].ToString() == "True")
                {
                    parents_prev = true;

                }
                string suite = reader["visite_suite"].ToString();


                //Création d'un objet Eleve et ajout de l'objet dans la liste de retour
                int eleveid = Int32.Parse(reader["eleve_id"].ToString());
                string nom = reader["eleve_nom"].ToString();
                string prenom = reader["eleve_prenom"].ToString();
                string naiss = reader["eleve_naiss"].ToString();
                int port = Int32.Parse(reader["eleve_port"].ToString());
                int parent_port = Int32.Parse(reader["eleve_parent_port"].ToString());
                int classeid = Int32.Parse(reader["eleve_classe"].ToString());
                string classelib = reader["classe_lib"].ToString(); 
                bool tiers_temps = false;
                if (reader["eleve_tiers_temps"].ToString() == "True")
                {
                    tiers_temps = true;
                }
                string comm_sante = reader["eleve_comm_sante"].ToString();

                Eleve tempeleve = new Eleve(eleveid, nom, prenom, naiss, port, parent_port, new Classe(classeid, classelib), tiers_temps, comm_sante);


                //Création d'un objet Medicament et ajout de l'objet dans la liste de retour
                int medicid = Int32.Parse(reader["medic_id"].ToString());
                string lib = reader["medic_lib"].ToString();

                Medicament tempmedic = new Medicament(id, lib, 0);


                Visite temp = new Visite(id, tempeleve, tempmedic, medic_qte, date.ToString(), heure_arrivee.ToString(), heure_depart.ToString(), motif, comm, parents_prev, suite, null);
                res.Add(temp);
            }
            maConnexion.Close();
            return res;
        }




        // Fonctions supplémentaires




        public static DateTime? dateFormat(string date)
        {
            var formats = new string[] { "dd-mm-yyyy", "dd/mm/yyyy", "dd-mm-yy", "dd/mm/yy", "dd-mm", "dd/mm" };
            DateTime datecv;
            CultureInfo FR = new CultureInfo("fr-FR", false);
            DateTime.TryParseExact(date, formats, FR, DateTimeStyles.None, out datecv);
            return datecv;
        }
    }
}