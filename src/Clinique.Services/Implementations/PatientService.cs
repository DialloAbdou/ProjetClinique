using Clinique.Data.Abstractions;
using Clinique.Services.Abstracts;
using CLinique.Models.Models;

namespace Clinique.Services.Implementations
{
    public class PatientService : IPatientService
    {
        private List<Patient> _listePatients = new List<Patient>();
        const int Max = 5;
        /// <summary>
        /// elle permet d'ajouter
        /// un patient dans la sa base de données 
        /// </summary>
        /// <param name="patient"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void AddMissionPatient(Patient patient, string nomPathologie)
        {
            if (!isAdmission(_listePatients))
                return; 
            patient.NomPatologie = nomPathologie;
            _listePatients.Add(patient);
         
         
        }
   
  
        public IEnumerable<Patient> GetAllPatients()
         => _listePatients.AsEnumerable();

        public bool isAdmission(List<Patient> patients)
        {
           return patients.Count() <= Max;
        }
    }
}
