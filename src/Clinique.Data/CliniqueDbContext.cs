using CLinique.Models.Models;
using Microsoft.EntityFrameworkCore;

namespace Clinique.Data
{
    public class CliniqueDbContext :DbContext
    {
        public DbSet<Patient> Patients{ get; set; }
        public DbSet<Medecin> Medecins { get; set; }

        public CliniqueDbContext(DbContextOptions<CliniqueDbContext>options):base(options)
        {
                
        }

    }
}