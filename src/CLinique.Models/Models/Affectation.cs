using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLinique.Models.Models
{
    public class Affectation
    {
        public DateTime DateAffection { get; set; }
        public Medecin medecin { get; set; } = default!;
        public Patient Patient { get; set; } = default!;
    }
}
