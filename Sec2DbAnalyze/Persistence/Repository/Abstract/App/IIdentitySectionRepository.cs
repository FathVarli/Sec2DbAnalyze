using System;
using Sec2DbAnalyze.Domain.Concrete;
using Sec2DbAnalyze.Persistence.Context;
using Sec2DbAnalyze.Persistence.Repository.Base;

namespace Sec2DbAnalyze.Persistence.Repository.Abstract.App
{
    public interface IIdentitySectionRepository : IGenericRepository<IdentitySection,ProjectDbContext, Guid>
    {
    }
}