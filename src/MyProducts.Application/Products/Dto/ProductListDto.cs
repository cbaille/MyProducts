using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProducts.Products.Dto
{
    [AutoMapFrom(typeof(Product))]
    public class ProductListDto : EntityDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int? CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
