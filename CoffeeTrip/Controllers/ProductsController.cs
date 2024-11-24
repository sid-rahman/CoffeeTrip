using CoffeeTrip.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeTrip.Controllers
{
    public class ProductsController : Controller
    {
        private IProductRepository _productRepository;
        public ProductsController(IProductRepository productRepository)
        {
                _productRepository = productRepository;
        }

        public IActionResult Shop()
        {
            return View(_productRepository.GetAllProducts());
        }

        public IActionResult Detail(int id)
        {
            var product = _productRepository.GetProductDetailsById(id);
            if (product == null)
                return NotFound();
            return View(product);
        }
    }
}
