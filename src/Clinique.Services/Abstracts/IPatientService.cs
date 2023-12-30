using CLinique.Models.Models;

namespace Clinique.Services.Abstracts
{
    public interface IPatientService
    {
        Patient AddPatient(Patient patient);
        IEnumerable<Patient> GetAllPatients();
    }
}
