using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace MyProject3.Web.Views
{
    public abstract class MyProject3RazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected MyProject3RazorPage()
        {
            LocalizationSourceName = MyProject3Consts.LocalizationSourceName;
        }
    }
}
