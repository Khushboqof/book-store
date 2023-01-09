using BookStore.Data.DbContexts;
using BookStore.Data.IRepositories;
using BookStore.Domain.Commons;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace BookStore.Data.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : Auditable
    {
        protected readonly AppDbContext _dbContext;
        protected readonly DbSet<T> _dbSet;

        public GenericRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Set<T>();
        }

        public async Task<T> CreateAsync(T entity)
        {
            await _dbSet.AddAsync(entity);

            await _dbContext.SaveChangesAsync();

            return entity;
        }

        public void DeleteAsync(int id)
        {
            var entity = _dbSet.FirstOrDefault(x => x.Id == id);
            _dbSet.Remove(entity);

            _dbContext.SaveChanges();
        }

        public IQueryable<T> GetAllAsync(Expression<Func<T, bool>> expression)
            => expression is null ? _dbSet : _dbSet.Where(expression);


        public async Task<T?> GetAsync(Expression<Func<T, bool>> expression)
            => await _dbSet.FirstOrDefaultAsync(expression);

        public async Task<T> UpdateAsync(T entity)
        {
            var res = _dbSet.Update(entity);

            _dbContext.SaveChanges();   

            return res.Entity;
        }
    }
}
