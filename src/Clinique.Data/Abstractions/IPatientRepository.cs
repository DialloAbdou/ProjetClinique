using CLinique.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinique.Data.Abstractions
{
    public interface IPatientRepository
    {
       IEnumerable<Patient> GetPatientAll();

       Patient AddPatient(Patient patient);
    }
}
