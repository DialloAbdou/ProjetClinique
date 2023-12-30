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
        List<Patient> patients = new List<Patient>();

        public Patient AddPatient(Patient patient)
        {
            if(patient is null) 
                throw new ArgumentNullException("L'objet ne doit pas null",nameof(patient));
            if(patients.Any(p=>p.Id == patient.Id))
            {
                throw new ArgumentException("Impossible d'ajouter un patient existant dans la base", nameof(patient));
            }
            patients.Add(patient);
            return patient; 
        }

        public IEnumerable<Patient> GetAllPatients()
        {
            return patients.AsEnumerable();
        }
    }
}
