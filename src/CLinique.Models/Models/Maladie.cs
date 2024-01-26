using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLinique.Models.Models
{
    public class Maladie
    {
        public Maladie()
        {
            Patients = new HashSet<Patient>();
        }
        public int Id { get; set; }
        public string NomPahtologi { get; set; } = string.Empty;
        ICollection<Patient>? Patients { get; set; }
    }
}
