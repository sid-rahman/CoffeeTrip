using CoffeeTrip.Models.Interfaces;
using CoffeeTrip.Data;

namespace CoffeeTrip.Models.Services
{
    public class ShoppingCartRepository : IShoppingCartRepository
    {
        private CoffeeTripDbContext _context;

        public ShoppingCartRepository(CoffeeTripDbContext context)
        {
            _context = context;
        }

        public List<ShoppingCartItem>? ShoppingCartItems { get; set; }

        public void AddToCart(Product product)
        {
            throw new NotImplementedException();
        }

        public void RemoveFromCart(Product product)
        {
            throw new NotImplementedException();
        }

        public void ClearCart()
        {
            throw new NotImplementedException();
        }

        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            throw new NotImplementedException();
        }

        public decimal GetTotalAmount()
        {
            throw new NotImplementedException();
        }

    }
}
