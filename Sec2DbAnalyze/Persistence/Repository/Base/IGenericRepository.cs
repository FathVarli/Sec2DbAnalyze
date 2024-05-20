using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sec2DbAnalyze.Domain.Abstract;
using Sec2DbAnalyze.Dto.Abstract;

namespace Sec2DbAnalyze.Persistence.Repository.Base
{
    public interface IGenericRepository<TEntity,TContext, in TPrimaryKey>
        where TEntity : class, IEntity, new()
        where TContext : DbContext
        where TPrimaryKey : IEquatable<TPrimaryKey>
    {
        Task<TEntity> AddAsync(TEntity entity);
        Task AddRangeAsync(IEnumerable<TEntity> entities);
        Task DeleteAsync(TPrimaryKey id);
        void DeleteRange(IEnumerable<TEntity> entities);
        void UpdateRange(List<TEntity> entities);
        TEntity Update(TEntity entity);
        Task<TEntity> GetByIdAsync(TPrimaryKey id);

        Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate, bool isTracking = false,
            params Expression<Func<TEntity, object>>[] includeEntities);

        Task<TType> GetSelectableAsync<TType>(Expression<Func<TType, bool>> predicate,
            Expression<Func<TEntity, TType>> select, bool isTracking = false) where TType : class, IDto, new();

        Task<IEnumerable<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> predicate = null,
            bool isTracking = false, params Expression<Func<TEntity, object>>[] includeEntities);

        Task<IEnumerable<TType>> GetSelectableListAsync<TType>(Expression<Func<TEntity, TType>> select,
            Expression<Func<TEntity, bool>> predicate = null, bool isTracking = false,params Expression<Func<TEntity, object>>[] includeEntities) where TType : class, IDto, new();

        Task<int> GetCountAsync(Expression<Func<TEntity, bool>> predicate = null);
        Task<int> GetCount(Expression<Func<TEntity, bool>> predicate = null);
        Task<bool> AnyAsync(Expression<Func<TEntity, bool>> predicate);
        bool Any(Expression<Func<TEntity, bool>> predicate);
        IQueryable<TEntity> Query();
    }
}