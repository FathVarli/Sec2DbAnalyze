using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sec2DbAnalyze.Domain.Abstract;
using Sec2DbAnalyze.Dto.Abstract;
using Sec2DbAnalyze.Helper.Extensions;
using Sec2DbAnalyze.Persistence.Context;

namespace Sec2DbAnalyze.Persistence.Repository.Base
{
    public class GenericRepository<TEntity,TContext, TPrimaryKey> : IGenericRepository<TEntity, TContext, TPrimaryKey>
        where TEntity : class, IEntity, new()
        where TContext : DbContext
        where TPrimaryKey : IEquatable<TPrimaryKey>
    {
        private readonly TContext _context;

        public GenericRepository(TContext context)
        {
            _context = context;
            _dbSetTable = _context.Set<TEntity>();
        }

        private DbSet<TEntity> _dbSetTable { get; }

        public virtual async Task<TEntity> AddAsync(TEntity entity)
        {
            var addedEntityEntry = await _context.Set<TEntity>().AddAsync(entity);
            return addedEntityEntry.Entity;
        }

        public virtual async Task AddRangeAsync(IEnumerable<TEntity> entities)
        {
            await _context.Set<TEntity>().AddRangeAsync(entities);
        }

        public virtual async Task DeleteAsync(TPrimaryKey id)
        {
            var existing = await _dbSetTable.FindAsync(id);
            if (existing != null) _dbSetTable.Remove(existing);
        }

        public virtual void DeleteRange(IEnumerable<TEntity> entities)
        {
            _dbSetTable.RemoveRange(entities);
        }

        public virtual void UpdateRange(List<TEntity> entities)
        {
            _context.Entry(entities).State = EntityState.Modified;
            _dbSetTable.UpdateRange(entities);
        }

        public virtual TEntity Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            var updatedEntityEntry = _dbSetTable.Update(entity);
            return updatedEntityEntry.Entity;
        }

        public virtual async Task<TEntity> GetByIdAsync(TPrimaryKey id)
        {
            return await _dbSetTable.FindAsync(id);
        }

        public virtual async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate, bool isTracking = false,
            params Expression<Func<TEntity, object>>[] includeEntities)
        {
            var query = isTracking
                ? Query()
                : Query().AsNoTracking();

            if (includeEntities.Length > 0)
            {
                query = Include(includeEntities);
            }

            return await query.FirstOrDefaultAsync(predicate);
        }

        public virtual async Task<TType> GetSelectableAsync<TType>(Expression<Func<TType, bool>> predicate,
            Expression<Func<TEntity, TType>> select, bool isTracking = false) where TType : class, IDto, new()
        {
            var query = isTracking ? _dbSetTable : _dbSetTable.AsNoTracking();
            return await query.Select(select).FirstOrDefaultAsync(predicate);
        }

        public virtual async Task<IEnumerable<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> predicate = null,
            bool isTracking = false, params Expression<Func<TEntity, object>>[] includeEntities)
        {
            var rnd = new Random();
            var skip = 100000 * rnd.Next(1, 6);
            var query = isTracking ? Query() : Query().AsNoTracking();

            if (includeEntities.Length > 0)
                query = Include(includeEntities);


            if (predicate == null) return await query.Skip(skip).Take(100000).ToListAsync();

            query = query.Skip(skip).Take(100000).Where(predicate);

            return await query.ToListAsync();
        }

        public virtual async Task<IEnumerable<TType>> GetSelectableListAsync<TType>(
            Expression<Func<TEntity, TType>> select,
            Expression<Func<TEntity, bool>> predicate = null, bool isTracking = false, 
            params Expression<Func<TEntity, object>>[] includeEntities) where TType : class, IDto, new()
        {
            var rnd = new Random();
            var skip = 100000 * rnd.Next(1, 6);
            var query = isTracking ? _dbSetTable : _dbSetTable.AsNoTracking();
            
            if (includeEntities.Length > 0)
                query = Include(includeEntities);

            if (predicate != null) query = query.Skip(skip).Take(100000).Where(predicate);

            return await query.Skip(skip).Take(100000).Select(select).ToListAsync();
        }

        public virtual async Task<int> GetCountAsync(Expression<Func<TEntity, bool>> predicate = null)
        {
            return predicate == null
                ? await _dbSetTable.CountAsync()
                : await _dbSetTable.CountAsync(predicate);
        }

        public virtual async Task<int> GetCount(Expression<Func<TEntity, bool>> predicate = null)
        {
            return predicate == null
                ? await _dbSetTable.CountAsync()
                : await _dbSetTable.CountAsync(predicate);
        }

        public virtual async Task<bool> AnyAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _dbSetTable.AnyAsync(predicate);
        }

        public virtual bool Any(Expression<Func<TEntity, bool>> predicate)
        {
            return _dbSetTable.Any(predicate);
        }

        public IQueryable<TEntity> Query()
        {
            return _dbSetTable.AsQueryable();
        }

        public IQueryable<TEntity> Include(params Expression<Func<TEntity, object>>[] includeEntities)
        {
            var query = Query();
            return includeEntities.Length <= 0 ? query : query.IncludeMultiple(includeEntities);
        }
    }
}