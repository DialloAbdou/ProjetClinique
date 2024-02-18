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

    } 
}
