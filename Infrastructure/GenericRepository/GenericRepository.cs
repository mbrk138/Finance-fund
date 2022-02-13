 using Domain.Interfaces;
using Infrastructure.Persist;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.GenericRepository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        /* context , dbset*/
        protected DatabaseContext _context;
        protected DbSet<T> dbSet;
        public GenericRepository(DatabaseContext context)
        {
            _context = context;
            dbSet = context.Set<T>();
        }


        public virtual async Task<bool> AddAsync(T entity)
        {
            await dbSet.AddAsync(entity);
            return true;
        }

        public virtual async  Task<bool> DeleteAsync(Guid id)
        {
            var result = await dbSet.FindAsync(id);
            dbSet.Remove(result);
            return true;
        }

        public virtual async Task<IEnumerable<T>> Find(Expression<Func<T, bool>> expression)
        {
            return await _context.Set<T>().Where(expression).ToListAsync();
        }

        public virtual async Task<IEnumerable<T>> GetAll()
        {
            return await dbSet.ToListAsync();
        }

        public virtual async Task<T> GetByIdAsync(Guid id)
        {
            return await dbSet.FindAsync(id);
        }
    }
}
