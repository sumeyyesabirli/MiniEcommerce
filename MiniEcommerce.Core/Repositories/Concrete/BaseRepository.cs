using Microsoft.EntityFrameworkCore;
using MiniEcommerce.Core.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniEcommerce.Core.Repositories.Concrete
{
    public class BaseRepository<T,TContext> : IRepository<T> where T : class where TContext : DbContext
    {
        protected readonly TContext Context;
        protected readonly DbSet<T> DbSet;
        public BaseRepository(TContext context)
        {
            Context = context;
            DbSet = Context.Set<T>();
        }
        public Task Add(T entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<T>> GetAll()
        {
            IQueryable<T> query = Context.Set<T>();
            return await query.ToListAsync();
        }

        public Task<T> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
