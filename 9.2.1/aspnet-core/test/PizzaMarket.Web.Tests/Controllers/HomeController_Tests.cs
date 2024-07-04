using System.Threading.Tasks;
using PizzaMarket.Models.TokenAuth;
using PizzaMarket.Web.Controllers;
using Shouldly;
using Xunit;

namespace PizzaMarket.Web.Tests.Controllers
{
    public class HomeController_Tests: PizzaMarketWebTestBase
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