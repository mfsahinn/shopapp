using Microsoft.AspNetCore.Mvc;
using shopapp.data.Abstract;

namespace shopapp.webui.Controllers
{
    public class ShopController : Controller
    {
        private IProductRepository _productService;
        public ShopController(IProductRepository productService)
        {
            this._productService = productService;
        }

        public IActionResult List()
        {
            var productViewModel = new ProductListViewModel()
            {
                Products = _productService.GetAll()

            };

            return View(productViewModel);
        }
    }
}