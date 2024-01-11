using CLinique.Models.Models;

namespace Clinique.Services.Abstracts
{
    public interface IPatientService
    {
        void AddMissionPatient(Patient patient, string nomPathologie);
        IEnumerable<Patient> GetAllPatients();
        bool isAdmission(List<Patient> patients);

    }
}
