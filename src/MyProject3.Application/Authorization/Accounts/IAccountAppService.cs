using System.Threading.Tasks;
using Abp.Application.Services;
using MyProject3.Authorization.Accounts.Dto;

namespace MyProject3.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
