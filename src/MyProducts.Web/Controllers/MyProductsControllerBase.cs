using Abp.AspNetCore.Mvc.Controllers;

namespace MyProducts.Web.Controllers
{
    public abstract class MyProductsControllerBase: AbpController
    {
        protected MyProductsControllerBase()
        {
            LocalizationSourceName = MyProductsConsts.LocalizationSourceName;
        }
    }
}