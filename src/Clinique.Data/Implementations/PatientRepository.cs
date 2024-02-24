using Clinique.Data.Abstractions;
using CLinique.Models.Models;
using Microsoft.EntityFrameworkCore;

namespace Clinique.Data.Implementations
{
    public class PatientRepository : Repository<Patient>, IPatientRepository
    {
        private CliniqueDbContext ClinqieDbContext => dbContext as CliniqueDbContext;

        public PatientRepository(CliniqueDbContext cliniqueDbContext) : base(cliniqueDbContext)
        {
        }

        public async Task<bool> IsExistPatient(int id)
        {
           return await dbContext.Patients.AnyAsync(p => p.Id == id);
        }
    }
}
