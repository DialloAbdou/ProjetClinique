using CLinique.Models.Models;

namespace Clinique.Data.Abstractions
{
    public interface IPatientRepository : IRepository<Patient>
    { 
        Task<bool>IsExitedPatient(Patient patient);

    }
}
