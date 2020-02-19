using Abp.EntityFrameworkCore;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace MyProducts.EntityFrameworkCore
{
    [DependsOn(
        typeof(MyProductsCoreModule), 
        typeof(AbpEntityFrameworkCoreModule))]
    public class MyProductsEntityFrameworkCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyProductsEntityFrameworkCoreModule).GetAssembly());
        }
    }
}