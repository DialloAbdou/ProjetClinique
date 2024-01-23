using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLinique.Models.Models
{
    public class Admission
    {
        public Patient Patient { get; set; } = default!;
        public string NomPathologie { get; set; } = string.Empty;
        public DateTime DebutAdmission { get; set; }
        public DateTime? FinAdmission { get; set; }

    }
}
