using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using MyProducts.ProductCategories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProducts.ProductCategories
{
    public class ProductCategoriesAppService : MyProductsAppServiceBase, IProductCategoriesAppService
    {
        private readonly IRepository<ProductCategory, int> _productCategoryRepository;

        public ProductCategoriesAppService(IRepository<ProductCategory, int> productCategoryRepository)
        {
            _productCategoryRepository = productCategoryRepository;
        }

        public async Task<ListResultDto<ComboboxItemDto>> GetCategoryRepositoryComboboxItems()
        {
            var product = await _productCategoryRepository.GetAllListAsync();

            return new ListResultDto<ComboboxItemDto>(
                product.Select(p => new ComboboxItemDto(p.Id.ToString("D"), p.Name)).ToList()
            );
        }

    }
}
