using Abp.Domain.Entities;
using MyProducts.ProductCategories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyProducts.Products
{
    [Table("Products")]
    public class Product: Entity
    {
        public const int MaxNameLength = 32;
        public const int MaxDescriptionLength = 32;


        [Required]
        [StringLength(MaxNameLength)]
        public string Name { get; set; }

        [Required]
        [StringLength(MaxDescriptionLength)]
        public string Description { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public ProductCategory Category { get; set; }
        public int? CategoryId { get; set; }

        public Product()
        {

        }
        public Product(string name, string description = null, int? categoryId = null)
            : this()
        {
            Name = name;
            Description = description;
            CategoryId = categoryId;
        }


    }
}
