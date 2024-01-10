using CLinique.Models.Models;

namespace Clinique.Data.Abstractions
{
    public interface IMedecinRepository:IRepository<Medecin>
    {
        Task<IEnumerable<Patient>> AffecterUnPatient(Patient patient, Medecin medecin);
      
    }
}
