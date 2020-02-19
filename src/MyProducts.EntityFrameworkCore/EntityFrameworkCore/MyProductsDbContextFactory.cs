using MyProducts.Configuration;
using MyProducts.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace MyProducts.EntityFrameworkCore
{
    /* This class is needed to run EF Core PMC commands. Not used anywhere else */
    public class MyProductsDbContextFactory : IDesignTimeDbContextFactory<MyProductsDbContext>
    {
        public MyProductsDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<MyProductsDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DbContextOptionsConfigurer.Configure(
                builder,
                configuration.GetConnectionString(MyProductsConsts.ConnectionStringName)
            );

            return new MyProductsDbContext(builder.Options);
        }
    }
}