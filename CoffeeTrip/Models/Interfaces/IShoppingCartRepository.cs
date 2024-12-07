namespace CoffeeTrip.Models.Interfaces
{
    public interface IShoppingCartRepository
    {
        void AddToCart(Product product);
        int RemoveFromCart(Product product);
        void ClearCart();
        List<ShoppingCartItem> GetShoppingCartItems();
        decimal GetTotalPrice();
        public List<ShoppingCartItem>? ShoppingCartItems { get; set; }
    }
}
