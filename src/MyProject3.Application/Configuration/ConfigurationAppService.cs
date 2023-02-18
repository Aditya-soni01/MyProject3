using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using MyProject3.Configuration.Dto;

namespace MyProject3.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : MyProject3AppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
