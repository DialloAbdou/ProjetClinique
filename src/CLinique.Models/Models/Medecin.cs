﻿using System;
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
            Patients = new HashSet<Patient>();
        }
        public ICollection<Patient>? Patients { get; set; } = default!;
    }
}
