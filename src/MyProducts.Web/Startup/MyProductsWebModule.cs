using Abp.AspNetCore;
using Abp.AspNetCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyProducts.Configuration;
using MyProducts.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace MyProducts.Web.Startup
{
    [DependsOn(
        typeof(MyProductsApplicationModule), 
        typeof(MyProductsEntityFrameworkCoreModule), 
        typeof(AbpAspNetCoreModule))]
    public class MyProductsWebModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public MyProductsWebModule(IHostingEnvironment env)
        {
            _appConfiguration = AppConfigurations.Get(env.ContentRootPath, env.EnvironmentName);
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(MyProductsConsts.ConnectionStringName);

            Configuration.Navigation.Providers.Add<MyProductsNavigationProvider>();

            Configuration.Modules.AbpAspNetCore()
                .CreateControllersForAppServices(
                    typeof(MyProductsApplicationModule).GetAssembly()
                );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyProductsWebModule).GetAssembly());
        }
    }
}