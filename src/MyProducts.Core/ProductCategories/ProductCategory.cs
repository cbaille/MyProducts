using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyProducts.ProductCategories
{
    [Table("ProductCategories")]
    public class ProductCategory : Entity
    {
        public const int MaxNameLength = 32;

        [Required]
        [StringLength(MaxNameLength)]
        public string Name { get; set; }

        public ProductCategory()
        {

        }

        public ProductCategory(string name)
        {
            Name = name;
        }
    }

}
