using Abp.Application.Services;
using AC3.MultiTenancy.Dto;

namespace AC3.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

