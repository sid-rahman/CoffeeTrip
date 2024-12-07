using CoffeeTrip.Models.Interfaces;
using CoffeeTrip.Data;
using Microsoft.EntityFrameworkCore;

namespace CoffeeTrip.Models.Services
{
    public class ShoppingCartRepository : IShoppingCartRepository
    {
        private CoffeeTripDbContext dbContext;
        public string? ShoppingCartId { get; set; }
        public List<ShoppingCartItem>? ShoppingCartItems { get; set; }

        public ShoppingCartRepository(CoffeeTripDbContext context)
        {
            dbContext = context;
        }    

        public static ShoppingCartRepository GetCart(IServiceProvider service)
        {      
            ISession? session = service.GetRequiredService<IHttpContextAccessor>()?.HttpContext?.Session;
            string cartId = session?.GetString("CartId") ?? Guid.NewGuid().ToString();
            session?.SetString("CartId", cartId);

            CoffeeTripDbContext context = service.GetService<CoffeeTripDbContext>() ?? throw new Exception("Error initializing CoffeshopDbContext");
            var CartRepository = new ShoppingCartRepository(context);
            CartRepository.ShoppingCartId = cartId;
            return CartRepository;
        }
      
        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            return ShoppingCartItems ??= dbContext.ShoppingCartItems.Where(s => s.ShoppingCartId == ShoppingCartId)
                .Include(p => p.Product).ToList();
        }

        public void AddToCart(Product product)
        {
            var shoppingCartItem = dbContext.ShoppingCartItems.FirstOrDefault(s  => s.Product.Id == product.Id && s.ShoppingCartId == ShoppingCartId);
            if (shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItem
                {
                    ShoppingCartId = ShoppingCartId,
                    Product = product,
                    Quantity = 1
                };
                dbContext.ShoppingCartItems.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Quantity++;
            }
            dbContext.SaveChanges();
        }

        public int RemoveFromCart(Product product)
        {
            var quantity = 0;
            var shoppingCartItem = dbContext.ShoppingCartItems.FirstOrDefault(s  => s.Product.Id == product.Id && s.ShoppingCartId == ShoppingCartId);        
            if (shoppingCartItem != null)
            {
                if (shoppingCartItem.Quantity > 1)
                {
                    shoppingCartItem.Quantity--;
                    quantity = shoppingCartItem.Quantity;
                }
                else
                {
                    dbContext.ShoppingCartItems.Remove(shoppingCartItem);
                }
            }
            dbContext.SaveChanges();
            return quantity;
        }

        public void ClearCart()
        {
            var cartItems = dbContext.ShoppingCartItems.Where(s => s.ShoppingCartId == ShoppingCartId);
            dbContext.ShoppingCartItems.RemoveRange(cartItems);
            dbContext.SaveChanges();
        }

        public decimal GetTotalPrice()
        {
            var totalPrice = dbContext.ShoppingCartItems.Where(s => s.ShoppingCartId == ShoppingCartId)
                .Select(s => s.Product.Price * s.Quantity).Sum();
            return totalPrice;
        }

    }
}
