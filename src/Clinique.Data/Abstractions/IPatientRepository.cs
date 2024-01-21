using CLinique.Models.Models;

namespace Clinique.Data.Abstractions
{
    public interface IPatientRepository : IRepository<Patient>
    {

        Task AddMissionPatientAsync(Patient patient, string nomPathologie);
        Task<IEnumerable<Patient>> GetAllPatientAsync();
        Task<bool> isAdmission(List<Patient> patients);
    }
}
