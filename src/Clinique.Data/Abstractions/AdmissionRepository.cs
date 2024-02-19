using Clinique.Data.Implementations;
using CLinique.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinique.Data.Abstractions
{
    public class AdmissionRepository : Repository<Admission>, IAdmissionRepository
    {
        public AdmissionRepository(CliniqueDbContext cliniqueDbContext) : base(cliniqueDbContext)
        {
        }

        private CliniqueDbContext ClinqieDbContext => dbContext as CliniqueDbContext;
   
        public async Task AjoutAdmission(Admission admission)
        {
            await ClinqieDbContext.AddAsync(admission);
            await ClinqieDbContext.SaveChangesAsync();
        ;
        }

    
    }
}
