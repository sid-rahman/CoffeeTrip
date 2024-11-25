using Microsoft.AspNetCore.Mvc;
using CoffeeTrip.Models.Interfaces;

namespace CoffeeTrip.Controllers
{
    public class HomeController : Controller
    {
        private IProductRepository productRepository;

        public HomeController (IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public IActionResult Index()
        {
            var trendingProducts = productRepository.GetAllTrendingProducts();
            return View(trendingProducts);
        }
    }
}
