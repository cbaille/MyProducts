using System;
using System.Threading.Tasks;
using Abp.TestBase;
using MyProducts.EntityFrameworkCore;
using MyProducts.Tests.TestDatas;

namespace MyProducts.Tests
{
    public class MyProductsTestBase : AbpIntegratedTestBase<MyProductsTestModule>
    {
        public MyProductsTestBase()
        {
            UsingDbContext(context => new TestDataBuilder(context).Build());
        }

        protected virtual void UsingDbContext(Action<MyProductsDbContext> action)
        {
            using (var context = LocalIocManager.Resolve<MyProductsDbContext>())
            {
                action(context);
                context.SaveChanges();
            }
        }

        protected virtual T UsingDbContext<T>(Func<MyProductsDbContext, T> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<MyProductsDbContext>())
            {
                result = func(context);
                context.SaveChanges();
            }

            return result;
        }

        protected virtual async Task UsingDbContextAsync(Func<MyProductsDbContext, Task> action)
        {
            using (var context = LocalIocManager.Resolve<MyProductsDbContext>())
            {
                await action(context);
                await context.SaveChangesAsync(true);
            }
        }

        protected virtual async Task<T> UsingDbContextAsync<T>(Func<MyProductsDbContext, Task<T>> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<MyProductsDbContext>())
            {
                result = await func(context);
                context.SaveChanges();
            }

            return result;
        }
    }
}
