using System.Threading.Tasks;
using ITours.Solutions.Models.TokenAuth;
using ITours.Solutions.Web.Controllers;
using Shouldly;
using Xunit;

namespace ITours.Solutions.Web.Tests.Controllers
{
    public class HomeController_Tests: SolutionsWebTestBase
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