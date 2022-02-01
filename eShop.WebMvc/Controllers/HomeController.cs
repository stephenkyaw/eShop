using eShop.WebMvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace eShop.WebMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductService _productService;
        public HomeController(ILogger<HomeController> logger, IProductService productService)
        {
            _logger = logger;
            _productService = productService;
        }

        public async Task<IActionResult> Index()
        {

            Product product = new Product()
            {
                Code = "Widge 002",
                Description = "Widge 002"
            };

            Variant variantSize = new Variant();
            variantSize.Name = "Size";
            variantSize.ProductId = product.Id;

            VariantOption variantOptionLarge = new VariantOption();
            variantOptionLarge.Option = "large";
            variantOptionLarge.ProductId = product.Id;
            variantOptionLarge.Sku = "widge_002_L";
            variantOptionLarge.Price = 100;

            VariantOption variantOptionSmall = new VariantOption();
            variantOptionSmall.Option = "Small";
            variantOptionSmall.ProductId = product.Id;
            variantOptionSmall.Sku = "widge_002_S";
            variantOptionSmall.Price = 80;

            VariantOption variantOptionMedium = new VariantOption();
            variantOptionMedium.Option = "Medium";
            variantOptionMedium.ProductId = product.Id;
            variantOptionMedium.Sku = "widge_002_M";
            variantOptionMedium.Price = 90;


            variantSize.Options.Add(variantOptionLarge);
            variantSize.Options.Add(variantOptionMedium);
            variantSize.Options.Add(variantOptionSmall);

            product.Variants.Add(variantSize);

            await _productService.Add(product);

            var products = await _productService.GetProductsAsync();

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}