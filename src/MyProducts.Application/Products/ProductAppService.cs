using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using MyProducts.Products.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyProducts.Products
{
    public class ProductAppService : MyProductsAppServiceBase, IProductAppService
    {
        private readonly IRepository<Product> _productRepository;

        public ProductAppService(IRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<ListResultDto<ProductListDto>> GetAll()
        {
            var products = await _productRepository
                .GetAll()
                .Include(p => p.Category)
                .ToListAsync();

            return new ListResultDto<ProductListDto>(
                ObjectMapper.Map<List<ProductListDto>>(products)
            );
        }

        public async Task Create(CreateProductInput input)
        {
            var product = ObjectMapper.Map<Product>(input);
            await _productRepository.InsertAsync(product);
        }

        public async Task<GetProductForEditOutput> GetProductForEdit(int productID)
        {
            var product = await _productRepository.GetAsync(productID);
            return ObjectMapper.Map<GetProductForEditOutput>(product);
        }

        public async Task Update(ProductDto input)
        {
            var product = await _productRepository.GetAsync(input.Id);

            ObjectMapper.Map(input, product);
            await _productRepository.UpdateAsync(product);

        }

        public async Task Delete(int ProductId)
        {
            await _productRepository.DeleteAsync(ProductId);
        }
    }
}
