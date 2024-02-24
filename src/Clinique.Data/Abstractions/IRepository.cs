using CLinique.Models.Models;
using System.Linq.Expressions;

namespace Clinique.Data.Abstractions
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> AddAsync(T person);
 
        
    }
}
