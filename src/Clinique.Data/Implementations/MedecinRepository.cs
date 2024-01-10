using Clinique.Data.Abstractions;
using CLinique.Models.Models;
using Microsoft.EntityFrameworkCore;

namespace Clinique.Data.Implementations
{
    public class MedecinRepository : Repository<Medecin>, IMedecinRepository
    {
        private CliniqueDbContext ClinqieDbContext => dbContext as CliniqueDbContext;

        public MedecinRepository(CliniqueDbContext cliniqueDbContext)
            : base(cliniqueDbContext)
        {
        }

        public Task<IEnumerable<Patient>> AffecterUnPatient(Patient patient, Medecin medecin)
        {
            throw new NotImplementedException();
        }

        //public async Task AffecterUnPatient(Patient patient, ind)
        //{

        //  var medecin =await dbContext.Medecins.FirstOrDefaultAsync(m=>m.Id ==  medecinId);
        //    if(medecin is not null)
        //    {
        //        medecin!.Patients!.Add(patient);
        //        await dbContext.SaveChangesAsync();

        //    }
        //}
    } 
}
