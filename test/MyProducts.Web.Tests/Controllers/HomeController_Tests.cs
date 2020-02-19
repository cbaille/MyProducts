using System.Threading.Tasks;
using MyProducts.Web.Controllers;
using Shouldly;
using Xunit;

namespace MyProducts.Web.Tests.Controllers
{
    public class HomeController_Tests: MyProductsWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}
