using Clinique.Data.Abstractions;
using CLinique.Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
           return await ClinqieDbContext.Patients.AnyAsync(p=>p.Id == patient.Id);   
        }
    }
}
