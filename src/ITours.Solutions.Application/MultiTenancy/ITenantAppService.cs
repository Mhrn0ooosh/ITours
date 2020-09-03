using Abp.Application.Services;
using ITours.Solutions.MultiTenancy.Dto;

namespace ITours.Solutions.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

