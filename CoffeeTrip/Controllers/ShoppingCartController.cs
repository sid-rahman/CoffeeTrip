using CoffeeTrip.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeTrip.Controllers
{
    public class ShoppingCartController : Controller
    {
        private IShoppingCartRepository _shoppingCartRepository;
        private IProductRepository _productRepository;
        int cartCount = 0;

        public ShoppingCartController (IShoppingCartRepository shoppingCartRepository, IProductRepository productRepository)
        {
            _shoppingCartRepository = shoppingCartRepository;
            _productRepository = productRepository;
        }

        public IActionResult Index()
        {
            var items = _shoppingCartRepository.GetShoppingCartItems();
            _shoppingCartRepository.ShoppingCartItems = items;
            ViewBag.TotalPrice = _shoppingCartRepository.GetTotalPrice();
            return View(items);
        }

        public RedirectToActionResult AddToShoppingCart(int productId)
        {
            var product = _productRepository.GetProductDetailsById(productId);
            if (product != null) 
            {
                _shoppingCartRepository.AddToCart(product);
                cartCount = _shoppingCartRepository.GetShoppingCartItems().Count();
                HttpContext.Session.SetInt32("CartCount", cartCount);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int productId)
        {
            var product = _productRepository.GetProductDetailsById(productId);
            if (product != null)
            {
                _shoppingCartRepository.RemoveFromCart(product);
                cartCount = _shoppingCartRepository.GetShoppingCartItems().Count();
                HttpContext.Session.SetInt32("CartCount", cartCount);
            }
            return RedirectToAction("Index");
        }
    }
}
