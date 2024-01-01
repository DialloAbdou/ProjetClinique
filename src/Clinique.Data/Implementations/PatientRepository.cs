using Clinique.Data.Abstractions;
using CLinique.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinique.Data.Implementations
{
    public class PatientRepository : IPatientRepository
    {
        private CliniqueDbContext _context;
        public PatientRepository(CliniqueDbContext context)
        {

            _context = context;

        }
        public Patient AddPatient(Patient patient)
        {
            _context.Patients.Add(patient);
            return patient;
        }

        public IEnumerable<Patient> GetPatientAll()
        {
            return _context.Patients.AsEnumerable();
        }
    }
}
