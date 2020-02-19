using Abp.Modules;
using Abp.Reflection.Extensions;
using MyProducts.Localization;

namespace MyProducts
{
    public class MyProductsCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            MyProductsLocalizationConfigurer.Configure(Configuration.Localization);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyProductsCoreModule).GetAssembly());
        }
    }
}