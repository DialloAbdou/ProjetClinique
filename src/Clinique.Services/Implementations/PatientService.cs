using Clinique.Data.Abstractions;
using Clinique.Services.Abstracts;
using CLinique.Models.Models;

namespace Clinique.Services.Implementations
{
    public class PatientService : IPatientService
    {
        public IEnumerable<Patient> GetAllPatients()
        {
           return Enumerable.Empty<Patient>();
        }
        public void AddPatient(Patient patient)
        {
            throw new NotImplementedException();
        }

    }
}
