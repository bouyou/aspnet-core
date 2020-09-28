using System.Threading.Tasks;
using Abp.Application.Services;
using Lille.Sessions.Dto;

namespace Lille.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
