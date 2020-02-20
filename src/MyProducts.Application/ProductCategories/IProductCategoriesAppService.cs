using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MyProducts.Products.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyProducts.ProductCategories
{
    public interface IProductCategoriesAppService: IApplicationService
    {
        Task<ListResultDto<ComboboxItemDto>> GetCategoryRepositoryComboboxItems();
    }
}
