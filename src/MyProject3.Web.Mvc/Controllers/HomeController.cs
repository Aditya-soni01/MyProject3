using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using MyProject3.Controllers;

namespace MyProject3.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : MyProject3ControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
