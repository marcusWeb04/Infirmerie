using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfirmerieBO
{
    class Classe
    {
        int classe_id;
        string classe_lib;

        public Classe(int classe_id, string classe_lib)
        {
            this.classe_id = classe_id;
            this.classe_lib = classe_lib;
        }

        public int Classe_id { get => classe_id; set => classe_id = value; }
        public string Classe_lib { get => classe_lib; set => classe_lib = value; }

    }
}
