using PromoAPI.Domain.Interfaces.Repositories;
using PromoAPI.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PromoAPI.Infra.Data.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly PromoDbContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public Repository(PromoDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }
        public Task<TEntity> AddAsync(TEntity obj)
        {
            return Task.FromResult(_dbSet.Add(obj));
        }

        public Task<IEnumerable<TEntity>> AddRangeAsync(IEnumerable<TEntity> objs)
        {
            return Task.FromResult(_dbSet.AddRange(objs));
        }

        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
            }
            GC.SuppressFinalize(this);
        }

        public Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null)
        {
            IQueryable<TEntity> query = _dbSet;

            if (predicate != null)
            {
                query = query.Where(predicate);
            }

            if (orderBy != null)
            {
                return orderBy(query).ToListAsync();
            }
            else
            {
                return query.ToListAsync();
            }
        }

        public Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate)
        {
            IQueryable<TEntity> query = _dbSet;

            query = query.Where(predicate);

            return query.SingleOrDefaultAsync();
        }

        public Task<TEntity> UpdateAsync(TEntity obj)
        {
            _context.Entry(obj).State = EntityState.Modified;

            return Task.FromResult(obj);
        }
    }
}
