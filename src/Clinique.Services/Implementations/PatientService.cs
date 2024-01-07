using Clinique.Data.Abstractions;
using Clinique.Services.Abstracts;
using CLinique.Models.Models;

namespace Clinique.Services.Implementations
{
    public class PatientService : IPatientService
    {
        private IPatientRepository _patientRepository;
        public PatientService( IPatientRepository  patientRepository ) 
        {
            _patientRepository = patientRepository;
        }

        public async Task<Patient> AddPatientAsync(Patient patient)
        {
           await _patientRepository.AddAsync(patient);
            return patient;
        }

        public async Task<IEnumerable<Patient>> GetAllPatientAsync()
        {
            return await _patientRepository.GetAllAsync();
        }

        public async Task<bool> IsExistePatient(Patient patient)
        {
            return await _patientRepository.IsExitedPatient(patient);

        }

     
    }
}
