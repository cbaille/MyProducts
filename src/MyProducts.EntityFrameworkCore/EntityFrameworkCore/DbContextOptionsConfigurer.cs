using Microsoft.EntityFrameworkCore;

namespace MyProducts.EntityFrameworkCore
{
    public static class DbContextOptionsConfigurer
    {
        public static void Configure(
            DbContextOptionsBuilder<MyProductsDbContext> dbContextOptions, 
            string connectionString
            )
        {
            /* This is the single point to configure DbContextOptions for MyProductsDbContext */
            dbContextOptions.UseSqlServer(connectionString);
        }
    }
}
