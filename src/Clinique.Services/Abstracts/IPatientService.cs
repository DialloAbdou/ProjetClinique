using CLinique.Models.Models;

namespace Clinique.Services.Abstracts
{
    public interface IPatientService
    {
        Task<Patient> AddPatientAsync(Patient patient);
        Task<IEnumerable<Patient>> GetAllPatientAsync();
        Task<bool> IsExistePatient(Patient patient);
    }
}
