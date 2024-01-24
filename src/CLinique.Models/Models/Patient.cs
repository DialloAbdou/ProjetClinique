using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLinique.Models.Models
{
    public class Patient :Personne
    {
        public string? NomPathologie { get; set; } 
        public Medecin ? Medecin { get; set; }
    }
}
