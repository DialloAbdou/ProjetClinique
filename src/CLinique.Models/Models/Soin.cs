using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLinique.Models.Models
{
    public class Soin
    {
        public int Id { get; set; }
        public string Tysoin { get; set; } = string.Empty;
        public decimal Cout { get; set; }
        public int NbJour { get; set; }
    }
}
