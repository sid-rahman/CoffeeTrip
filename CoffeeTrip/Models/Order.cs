namespace CoffeeTrip.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public decimal OrderTotalPrice { get; set; }
        public DateTime OrderPlacedDate { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
    }
}
