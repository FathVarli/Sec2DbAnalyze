using System.Threading.Tasks;

namespace Sec2DbAnalyze.ServiceLayer.Mock
{
    public interface IMockService
    {
        Task CreateAccountAndService();
        Task CreateMockData(int count);
        Task CreatePartialMockDate(int count);
    }
}