using System.Threading.Tasks;
using Abp.Application.Services;
using MyProject3.Sessions.Dto;

namespace MyProject3.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
