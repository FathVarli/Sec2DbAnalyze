using System;
using Sec2DbAnalyze.Domain.Concrete;
using Sec2DbAnalyze.Persistence.Context;
using Sec2DbAnalyze.Persistence.Repository.Abstract.App;
using Sec2DbAnalyze.Persistence.Repository.Base;

namespace Sec2DbAnalyze.Persistence.Repository.Concrete.App
{
    public class UserPartitionRepository : GenericRepository<UserPartition,ProjectDbContext, Guid>, IUserPartitionRepository
    {
        public UserPartitionRepository(ProjectDbContext context) : base(context)
        {
        }
    }
}