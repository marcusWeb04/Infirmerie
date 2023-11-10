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

        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBDD.GetConnexion().SetchaineConnexion(chaine);
        }

        public static bool GetUtilisateur(Utilisateur uti) 
        {
            return ConnexionBDD.GetUtilisateur(uti);
        }
    }
}
