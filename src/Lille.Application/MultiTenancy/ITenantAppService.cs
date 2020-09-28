using Abp.Application.Services;
using Lille.MultiTenancy.Dto;

namespace Lille.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

