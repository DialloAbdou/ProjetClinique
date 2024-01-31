using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLinique.Models.Models
{
    public class Traitement
    {
        public int Id { get; set; }
        public ICollection<Soin> Soins { get; set; }

        public Maladie Maladie { get; set; }

    }
}
 