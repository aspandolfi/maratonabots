using PromoAPI.Domain.Interfaces;
using PromoAPI.Domain.Interfaces.Repositories;
using PromoAPI.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PromoAPI.Domain.Services
{
    public class Service<TEntity> : IService<TEntity> where TEntity : class
    {
        private readonly IRepository<TEntity> _repository;
        private readonly IUoW _uow;

        public Service(IRepository<TEntity> repository, IUoW uoW)
        {
            _repository = repository;
            _uow = uoW;
        }
        public virtual async Task<TEntity> AddAsync(TEntity obj)
        {
            obj = await _repository.AddAsync(obj);
            await _uow.CommitAsync();
            return obj;
        }

        public async Task<IEnumerable<TEntity>> AddRangeAsync(IEnumerable<TEntity> objs)
        {
            objs = await _repository.AddRangeAsync(objs);
            await _uow.CommitAsync();
            return objs;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null)
        {
            return _repository.GetAllAsync(predicate, orderBy);
        }

        public Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return _repository.GetAsync(predicate);
        }

        public async Task<TEntity> UpdateAsync(TEntity obj)
        {
            obj = await _repository.UpdateAsync(obj);
            await _uow.CommitAsync();
            return obj;
        }
    }
}
