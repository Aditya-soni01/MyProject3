using System.Threading.Tasks;
using Abp.ObjectMapping;
using MyProject3.Sessions;
using Microsoft.AspNetCore.Mvc;

namespace MyProject3.Web.Views.Shared.Components.TenantChange
{
    public class TenantChangeViewComponent : MyProject3ViewComponent
    {
        private readonly ISessionAppService _sessionAppService;
        private readonly IObjectMapper _objectMapper;

        public TenantChangeViewComponent(ISessionAppService sessionAppService, IObjectMapper objectMapper)
        {
            _sessionAppService = sessionAppService;
            _objectMapper = objectMapper;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var loginInfo = await _sessionAppService.GetCurrentLoginInformations();
            var model = _objectMapper.Map<TenantChangeViewModel>(loginInfo);
            return View(model);
        }
    }
}
