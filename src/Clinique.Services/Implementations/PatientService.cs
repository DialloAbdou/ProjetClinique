using Clinique.Data.Abstractions;
using Clinique.Services.Abstracts;
using CLinique.Models.Models;

namespace Clinique.Services.Implementations
{
    public class PatientService : IPatientService
    {
        private List<Patient> _listePatients = new List<Patient>();
        const int Max = 10;
        /// <summary>
        /// elle permet d'ajouter
        /// un patient dans la sa base de données 
        /// </summary>
        /// <param name="patient"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void AddMissionPatient(Patient patient, string nomPathologie)
        {
            patient.NomPatologie = nomPathologie;
            if (_listePatients.Count()> Max)
               throw new ArgumentOutOfRangeException(nameof(Max));
            _listePatients.Add(patient);
         
         
        }
   
  
        public IEnumerable<Patient> GetAllPatients()
         => _listePatients.AsEnumerable();

        public bool isAdmission(List<Patient> patients)
        {
            throw new NotImplementedException();
        }
    }
}


//{
//    int max = _listePatients.Count();
//    throw new ArgumentOutOfRangeException(nameof(max), "le nombre d'ambition doit être inferieur ou egal à 10");
//}