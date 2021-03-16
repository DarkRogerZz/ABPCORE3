using System.Threading.Tasks;
using Abp.Application.Services;
using AC3.Sessions.Dto;

namespace AC3.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
