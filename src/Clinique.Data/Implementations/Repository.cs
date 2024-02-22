using Clinique.Data.Abstractions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
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
            await dbContext.SaveChangesAsync();
            return person;
           
        }

        public async Task<bool> IsExistedAsync(Expression<Func<T, bool>> predicate)
        {
            return await dbContext.Set<T>().AnyAsync(predicate);
        }
    }
}
