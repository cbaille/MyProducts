using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyProducts.ProductCategories;
using MyProducts.Products;
using MyProducts.Web.Models.Products;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyProducts.Web.Controllers
{
    public class ProductsController : MyProductsControllerBase//Controller
    {
        private readonly IProductAppService _productAppService;
        private readonly IProductCategoriesAppService _productCategoriesAppService;


        public ProductsController (
            IProductAppService productAppService,
            IProductCategoriesAppService productCategoriesAppService)
        {
            _productAppService = productAppService;
            _productCategoriesAppService = productCategoriesAppService;
        }

        public async Task<ActionResult> Index()
        {
            var output = (await _productAppService.GetAll()).Items; //change to list

            var model = new ProductListViewModel()
            {
                Products = output
            };

            return View(model);
        }

        public async Task<ActionResult> Create()
        {
            var productCategorieListItems = (await _productCategoriesAppService.GetCategoryRepositoryComboboxItems()).Items
                .Select(p => p.ToSelectListItem())
                .ToList();
            //ProductCategorieListItems.Insert(0, new SelectListItem { Value = string.Empty, Text = L("Unassigned"), Selected = true });

            return View(new CreateProductViewModel(productCategorieListItems));
        }

        public async Task<ActionResult> Edit(int id)
        {
            var output = await _productAppService.GetProductForEdit(id);
            var model = ObjectMapper.Map<EditProductModalViewModel>(output);

            var productCategorieListItems = (await _productCategoriesAppService.GetCategoryRepositoryComboboxItems()).Items
                 .Select(p => p.ToSelectListItem())
                 .ToList();

            model.Category = productCategorieListItems;
            return View(model);
        }

    }
}
