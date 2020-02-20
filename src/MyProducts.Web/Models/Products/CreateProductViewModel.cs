using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProducts.Web.Models.Products
{
    public class CreateProductViewModel
    {
        public List<SelectListItem> Category { get; set; }

        public CreateProductViewModel(List<SelectListItem> category)
        {
            Category = category;
        }
    }
}
