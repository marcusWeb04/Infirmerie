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
        private string nom;
        private string motDePasse;

        public Utilisateur(string nom, string motDePasse)
        {
            this.nom = nom;
            this.motDePasse = motDePasse;
        }

        public string Nom { get => nom; set => nom = value; }
        public string MotDePasse { get => motDePasse; set => motDePasse = value; }
    }
}
