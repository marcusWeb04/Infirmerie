using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfirmerieBO
{
    public class Utilisateur
    {
        //variable
        string nom;
        string mot_de_passe;

        public Utilisateur(string nom, string mot_de_passe)
        {
            this.Nom = nom;
            this.Mot_de_passe = mot_de_passe;
        }

        public string Nom { get => nom; set => nom = value; }
        public string Mot_de_passe { get => mot_de_passe; set => mot_de_passe = value; }
    }
}
