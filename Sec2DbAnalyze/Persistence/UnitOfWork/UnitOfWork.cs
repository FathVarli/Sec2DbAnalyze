using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Sec2DbAnalyze.Persistence.Context;

namespace Sec2DbAnalyze.Persistence.UnitOfWork
{
    public sealed class UnitOfWork : IUnitOfWork
    {
        private readonly ProjectDbContext _projectDbContext;
        private readonly Dictionary<Type, object> _repositories;

        public UnitOfWork(ProjectDbContext projectDbContext)
        {
            _projectDbContext = projectDbContext;
            _repositories = new Dictionary<Type, object>();
        }

        public int Complete()
        {
            try
            {
                return _projectDbContext.SaveChanges();
            }
            catch (Exception)
            {
                Dispose();
                return 0;
            }
        }

        public async Task<int> CompleteAsync()
        {
            return await _projectDbContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (disposing) _projectDbContext.Dispose();
        }
    }
}