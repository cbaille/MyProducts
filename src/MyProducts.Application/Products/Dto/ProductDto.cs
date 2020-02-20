using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyProducts.Products.Dto
{
    [AutoMap(typeof(Product))]
    public class ProductDto: EntityDto
    {

        public const int MaxNameLength = 32;
        public const int MaxDescriptionLength = 32;

        [Required]
        [StringLength(MaxNameLength)]
        public string Name { get; set; }

        [Required]
        [StringLength(MaxDescriptionLength)]
        public string Description { get; set; }

        public int? CategoryId { get; set; }
    }
}
