namespace CoffeeTrip.Models
{
    public class ShoppingCartItem
    {
        public int id { get; set; }
        public Product? product { get; set; }
        public int Quantity {  get; set; }
        public string? ShoppingCartId { get; set; }
    }
}
