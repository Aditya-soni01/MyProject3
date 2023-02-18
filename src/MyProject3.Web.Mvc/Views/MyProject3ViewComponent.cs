using Abp.AspNetCore.Mvc.ViewComponents;

namespace MyProject3.Web.Views
{
    public abstract class MyProject3ViewComponent : AbpViewComponent
    {
        protected MyProject3ViewComponent()
        {
            LocalizationSourceName = MyProject3Consts.LocalizationSourceName;
        }
    }
}
