using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyProducts.ProductCategories;
using MyProducts.Products;

namespace MyProducts.EntityFrameworkCore
{
    public class MyProductsDbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...

        public MyProductsDbContext(DbContextOptions<MyProductsDbContext> options) 
            : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }

        public DbSet<ProductCategory> ProductCategories { get; set; }


    }
}
