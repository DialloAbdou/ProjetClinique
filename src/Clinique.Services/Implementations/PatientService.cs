using Clinique.Data.Abstractions;
using Clinique.Services.Abstracts;
using CLinique.Models.Models;

namespace Clinique.Services.Implementations
{
    public class PatientService : IPatientService
    {
        private List<Patient> Listpatients = new List<Patient>();
        public  IEnumerable<Patient>GetAllPatients()
        {
           return Listpatients.AsEnumerable();
        }
        public void AddPatient(Patient patient)
        {
            if( IsNotExistPatient(patient))
               Listpatients.Add(patient);  
        }

        public  bool IsNotExistPatient(Patient patient)
        {
            return Listpatients.All(p=>p.Id != patient.Id);
        }
    }
}
