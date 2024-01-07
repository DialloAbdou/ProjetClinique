using Clinique.Data.Abstractions;
using CLinique.Models.Models;
using Microsoft.EntityFrameworkCore;

namespace Clinique.Data.Implementations
{
    public class PatientRepository : Repository<Patient>, IPatientRepository
    {
        public PatientRepository(CliniqueDbContext cliniqueDbContext) : base(cliniqueDbContext)
        {
        }

        private CliniqueDbContext ClinqieDbContext => dbContext as CliniqueDbContext;

        public async Task<bool> IsExitedPatient(Patient patient)
        {
            var p = await ClinqieDbContext.Patients.FirstOrDefaultAsync(p => p.Id == patient.Id);

            if (p != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
