using MyProducts.Products.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProducts.Web.Models.Products
{
    public class ProductListViewModel
    {
        public IReadOnlyList<ProductListDto> Products { get; set; } //no need to keep Dto?

    }
}
