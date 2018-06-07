using System.Threading.Tasks;
using Abp.Application.Services;
using AngularCoreProject.Sessions.Dto;

namespace AngularCoreProject.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
