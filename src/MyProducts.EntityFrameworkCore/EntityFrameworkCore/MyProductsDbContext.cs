using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MyProducts.EntityFrameworkCore
{
    public class MyProductsDbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...

        public MyProductsDbContext(DbContextOptions<MyProductsDbContext> options) 
            : base(options)
        {

        }
    }
}
