using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using MyProject3.MultiTenancy;

namespace MyProject3.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
