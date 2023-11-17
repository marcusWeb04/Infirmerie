using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfirmerieBO
{
    public class Classe
    {
        int classe_id;
        string classe_lib;

        public Classe(int classe_id, string classe_lib)
        {
            this.classe_id = classe_id;
            this.classe_lib = classe_lib;
        }

        public int id { get => classe_id; set => classe_id = value; }
        public string lib { get => classe_lib; set => classe_lib = value; }

        public override string ToString()
        {
            return classe_lib;
        }
    }
}