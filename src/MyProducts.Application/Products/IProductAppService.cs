using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MyProducts.Products.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyProducts.Products
{
    public interface IProductAppService : IApplicationService
    {
        Task<ListResultDto<ProductListDto>> GetAll();
        Task Create(CreateProductDto input);
        Task<ProductDto> GetProductForEdit(int productID);
    }
}
