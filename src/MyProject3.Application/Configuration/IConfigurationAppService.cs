using System.Threading.Tasks;
using MyProject3.Configuration.Dto;

namespace MyProject3.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
