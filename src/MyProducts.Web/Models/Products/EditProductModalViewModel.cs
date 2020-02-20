using Abp.AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyProducts.Products.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProducts.Web.Models.Products
{
    [AutoMapFrom(typeof(ProductDto))]

    public class EditProductModalViewModel : ProductDto
    {
        public List<SelectListItem> Category { get; set; }
    }
}
