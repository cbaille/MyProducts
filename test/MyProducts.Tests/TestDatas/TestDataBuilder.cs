using MyProducts.EntityFrameworkCore;

namespace MyProducts.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly MyProductsDbContext _context;

        public TestDataBuilder(MyProductsDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            //create test data here...
        }
    }
}