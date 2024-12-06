namespace CoffeeTrip.Models.Interfaces
{
    public interface IShoppingCartRepository
    {
        void AddToCart(Product product);
        void RemoveFromCart(Product product);
        void ClearCart();
        List<ShoppingCartItem> GetShoppingCartItems();
        decimal GetTotalAmount();
        public List<ShoppingCartItem>? ShoppingCartItems { get; set; }
    }
}
