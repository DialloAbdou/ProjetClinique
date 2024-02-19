using Clinique.Data.Abstractions;
using Clinique.Services.Abstracts;
using Clinique.Services.AbstractsMock;
using CLinique.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinique.Services.ImplementationsMocks
{
    public class PatientServiceMock : IPatientServiceMock
    {
        private IPatientRepository _patientRepository;
        public PatientServiceMock( IPatientRepository patientRepository)
        {
            _patientRepository = patientRepository;
        }
        public async Task<IEnumerable<Patient>> GetAllPatients()
        {
            return await _patientRepository.GetAllAsync();
        }

        public Task AddPatient(Patient patient)
        {
            throw new NotImplementedException();
        }

    

        public Task<bool> IsNotExistPatient(Patient patient)
        {
            throw new NotImplementedException();
        }
    }
}
