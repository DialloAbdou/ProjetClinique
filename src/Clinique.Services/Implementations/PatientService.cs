using Clinique.Data.Abstractions;
using Clinique.Services.Abstracts;
using CLinique.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        //public Async Patient AddPatientAsync (Patient patient)
        //{
        //    if(patient is null)
        //    {
        //        throw new ArgumentNullException("L'objet ne doit pas null",nameof(patient));

        //    }
        //    if(GetAllPatientAsync().Any(p=>p.Id == patient.Id))
        //    {
        //           throw new ArgumentException("Impossible d'ajouter un patient existant dans la base", nameof(patient));

        //    }
        //    _patientRepository.AddAsync(patient);
        //    return patient; 
        //}

        //public IEnumerable<Patient> GetAllPatientAsync()
        //{
        //    return _patientRepository
        //}
    }
}
