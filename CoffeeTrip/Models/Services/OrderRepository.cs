using CoffeeTrip.Data;
using CoffeeTrip.Models.Interfaces;

namespace CoffeeTrip.Models.Services
{
    public class OrderRepository : IOrderRepository
    {
        private CoffeeTripDbContext dbcontex;
        private IShoppingCartRepository shoppingCartRepository;
        public OrderRepository (CoffeeTripDbContext dbcontex, IShoppingCartRepository shoppingCartRepository)
        {
            this.dbcontex = dbcontex;
            this.shoppingCartRepository = shoppingCartRepository;
        }
        public void PlaceOrder(Order order)
        {
            var shoppingCartItems = shoppingCartRepository.GetShoppingCartItems();
            order.OrderDetails = new List<OrderDetail>();
            foreach (var item in shoppingCartItems)
            {
                var orderDetail = new OrderDetail
                {
                    ProductId = item.Product.Id,
                    OrderQuantity = item.Quantity,
                    Price = item.Product.Price
                };
                order.OrderDetails.Add(orderDetail);
            }
            order.OrderTotalPrice = shoppingCartRepository.GetTotalPrice();
            order.OrderPlacedDate = DateTime.Now;
            dbcontex.Orders.Add(order);
            dbcontex.SaveChanges();
        }
    }
}
