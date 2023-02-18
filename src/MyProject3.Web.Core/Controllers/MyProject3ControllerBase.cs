using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace MyProject3.Controllers
{
    public abstract class MyProject3ControllerBase: AbpController
    {
        protected MyProject3ControllerBase()
        {
            LocalizationSourceName = MyProject3Consts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
