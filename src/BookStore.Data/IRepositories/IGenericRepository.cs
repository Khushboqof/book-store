using BookStore.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Data.IRepositories
{
    public interface IGenericRepository<T> where T : Auditable
    {
        Task<T> CreateAsync(T entity);
        Task<T> UpdateAsync(T entity);
        void DeleteAsync(int id);
        Task<T?> GetAsync(Expression<Func<T, bool>> expression);
        IQueryable<T> GetAllAsync(Expression<Func<T, bool>> expression = null!);
    }
}
