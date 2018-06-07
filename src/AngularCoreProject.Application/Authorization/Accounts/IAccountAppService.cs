using System.Threading.Tasks;
using Abp.Application.Services;
using AngularCoreProject.Authorization.Accounts.Dto;

namespace AngularCoreProject.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
