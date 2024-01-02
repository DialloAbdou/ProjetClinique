using Clinique.Data.Abstractions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinique.Data.Implementations
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected CliniqueDbContext dbContext;

        public Repository( CliniqueDbContext cliniqueDbContext)
        {
            dbContext = cliniqueDbContext;
        }
        public  async Task<IEnumerable<T>> GetAllAsync()
        {
            return await dbContext.Set<T>().ToListAsync();
            
        }

        public  async Task<T> AddAsync(T person)
        {
            await dbContext.Set<T>().AddAsync(person);
            return person;
           
        }
       
    }
}
