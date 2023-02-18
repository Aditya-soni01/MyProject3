using Abp.Application.Services;
using MyProject3.MultiTenancy.Dto;

namespace MyProject3.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

