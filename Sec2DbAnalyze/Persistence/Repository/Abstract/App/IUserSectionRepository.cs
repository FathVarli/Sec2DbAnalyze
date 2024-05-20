using System;
using Sec2DbAnalyze.Domain.Concrete;
using Sec2DbAnalyze.Persistence.Context;
using Sec2DbAnalyze.Persistence.Repository.Base;

namespace Sec2DbAnalyze.Persistence.Repository.Abstract.App
{
    public interface IUserSectionRepository : IGenericRepository<UserSection,ProjectDbContext, Guid>
    {
    }
}