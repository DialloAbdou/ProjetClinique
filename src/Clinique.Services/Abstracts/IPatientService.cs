using CLinique.Models.Models;

namespace Clinique.Services.Abstracts
{
    public interface IPatientService
    {
        void AddPatient(Patient patient);
        IEnumerable<Patient> GetAllPatients();
    }
}
