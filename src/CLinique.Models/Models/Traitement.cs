using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLinique.Models.Models
{
    public class Traitement
    {
        public Traitement()
        {
            Soins = new HashSet<Soin>();
        }
        public int Id { get; set; }
        public ICollection<Soin> Soins { get; set; }
        public virtual Maladie Maladie { get; set; }
        public int MaladieId { get; set; }

    }
}
  