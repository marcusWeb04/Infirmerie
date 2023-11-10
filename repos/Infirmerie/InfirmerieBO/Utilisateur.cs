using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfirmerieBO
{
    public class Utilisateur
    {
        //attribut
        private string utilisateur_login;
        private string utilisateur_mdp;

        public Utilisateur(string utilisateur_login, string utilisateur_mdp)
        {
            this.utilisateur_login = utilisateur_login;
            this.utilisateur_mdp = utilisateur_mdp;
        }

        public string login { get => utilisateur_login; set => utilisateur_login = value; }
        public string mdp { get => utilisateur_mdp; set => utilisateur_mdp = value; }
    }
}