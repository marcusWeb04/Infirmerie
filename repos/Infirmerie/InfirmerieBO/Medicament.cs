using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfirmerieBO
{
    internal class Medicament
    {
        // Attributs
        private int medic_id;
        private string medic_lib;
        private int medic_number;

        // Constructeur
        public Medicament(int medic_id, string medic_lib, int medic_number)
        {
            this.medic_id = medic_id;
            this.medic_lib = medic_lib;
            this.medic_number = medic_number;
        }

        // Getter/Setters
        public int Id_medic
        { 
            get => medic_id; 
            set => medic_id = value; 
        
        }
        public string Lib_medic
        { 
            get => medic_lib; 
            set => medic_lib = value; 
        }

        public int Number_medic
        {
            get => medic_number;
            set => medic_number = value;
        }
    }
}
