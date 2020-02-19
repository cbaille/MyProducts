using Abp.Application.Services;

namespace MyProducts
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class MyProductsAppServiceBase : ApplicationService
    {
        protected MyProductsAppServiceBase()
        {
            LocalizationSourceName = MyProductsConsts.LocalizationSourceName;
        }
    }
}