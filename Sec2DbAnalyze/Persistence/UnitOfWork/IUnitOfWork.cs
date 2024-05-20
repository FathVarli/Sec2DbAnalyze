using System;
using System.Threading.Tasks;

namespace Sec2DbAnalyze.Persistence.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        int Complete();

        Task<int> CompleteAsync();
    }
}