using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyProducts.Products.Dto
{
    [AutoMapTo(typeof(Product))]
    public class CreateProductDto
    {
        [Required]
        [StringLength(Product.MaxNameLength)]
        public string Name { get; set; }

        [StringLength(Product.MaxDescriptionLength)]
        public string Description { get; set; }

        public int? CategoryId { get; set; }
    }
}
