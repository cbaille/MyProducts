using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyProducts.Web.Startup;
namespace MyProducts.Web.Tests
{
    [DependsOn(
        typeof(MyProductsWebModule),
        typeof(AbpAspNetCoreTestBaseModule)
        )]
    public class MyProductsWebTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyProductsWebTestModule).GetAssembly());
        }
    }
}