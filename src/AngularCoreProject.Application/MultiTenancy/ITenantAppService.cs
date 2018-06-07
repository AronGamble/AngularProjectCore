using Abp.Application.Services;
using Abp.Application.Services.Dto;
using AngularCoreProject.MultiTenancy.Dto;

namespace AngularCoreProject.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
