using System.Threading.Tasks;
using MyProject3.Models.TokenAuth;
using MyProject3.Web.Controllers;
using Shouldly;
using Xunit;

namespace MyProject3.Web.Tests.Controllers
{
    public class HomeController_Tests: MyProject3WebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}