using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLinique.Models.Models
{
    public class Medecin:Personne
    {
        public Medecin()
        {
            Patients = new List<Patient>();
        }
        public List<Patient> Patients { get; set; } = default!;
    }
}
