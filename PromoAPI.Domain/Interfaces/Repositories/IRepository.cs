using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PromoAPI.Domain.Interfaces.Repositories
{
    public interface IRepository<TEntity> : IDisposable
    {
        Task<TEntity> AddAsync(TEntity obj);
        Task<IEnumerable<TEntity>> AddRangeAsync(IEnumerable<TEntity> objs);
        Task<TEntity> UpdateAsync(TEntity obj);
        Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate);
        Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate = null,
                                               Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null);
    }
}
