using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace MyProducts
{
    [DependsOn(
        typeof(MyProductsCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class MyProductsApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyProductsApplicationModule).GetAssembly());
        }
    }
}