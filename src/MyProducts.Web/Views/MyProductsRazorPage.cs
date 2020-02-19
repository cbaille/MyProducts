using Abp.AspNetCore.Mvc.Views;

namespace MyProducts.Web.Views
{
    public abstract class MyProductsRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected MyProductsRazorPage()
        {
            LocalizationSourceName = MyProductsConsts.LocalizationSourceName;
        }
    }
}
