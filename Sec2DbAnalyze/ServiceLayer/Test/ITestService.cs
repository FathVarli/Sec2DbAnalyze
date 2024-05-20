using System.Collections.Generic;
using System.Threading.Tasks;
using Sec2DbAnalyze.Domain.Concrete;
using Sec2DbAnalyze.Dto.Concrete;

namespace Sec2DbAnalyze.ServiceLayer.Test
{
    public interface ITestService
    {
        Task UpdateUser(UserFilterDto userFilterDto);
        Task<bool> GetListUser(UserFilterDto userFilterDto);
        Task<bool> GetListIdentity(IdentityFilterDto identityFilterDto);
        Task<bool> GetUser(UserFilterDto userFilterDto);
        Task<bool> GetIdentity(IdentityFilterDto identityFilterDto);
    }
}