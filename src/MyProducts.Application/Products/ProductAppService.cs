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

        public async Task Create(CreateProductDto input)
        {
            var product = ObjectMapper.Map<Product>(input);
            await _productRepository.InsertAsync(product);
        }

        public async Task Delete(int ProductId)
        {
            //var product = ObjectMapper.Map<Product>(input);
            await _productRepository.DeleteAsync(ProductId);
        }

        public async Task<ProductDto> GetProductForEdit(int productID)
        {
            var product = await _productRepository.GetAsync(productID);
            return ObjectMapper.Map<ProductDto>(product);
        }

        public async Task Update(ProductDto input)
        {
            var product = await _productRepository.GetAsync(input.Id);

            ObjectMapper.Map(input, product);
            await _productRepository.UpdateAsync(product);
            //product.SetNormalizedNames();

            //MapToEntity(input, user);


            //var product = ObjectMapper.Map<Product>(input);
            //await _productRepository.InsertAsync(product);
        }
    }
}
