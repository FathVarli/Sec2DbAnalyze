using System;
using Sec2DbAnalyze.Domain.Concrete;
using Sec2DbAnalyze.Persistence.Context;
using Sec2DbAnalyze.Persistence.Repository.Abstract.App;
using Sec2DbAnalyze.Persistence.Repository.Base;

namespace Sec2DbAnalyze.Persistence.Repository.Concrete.App
{
    public class LogRepository : GenericRepository<Log,ProjectDbContext,Guid> , ILogRepository
    {
        public LogRepository(ProjectDbContext context) : base(context)
        {
        }
    }
}