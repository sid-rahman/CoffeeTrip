using CoffeeTrip.Models.Interfaces;

namespace CoffeeTrip.Models.Services
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> _productList = new List<Product>()
        {
            new Product
            {
                Id = 1,
                Name = "Americano",
                Description = "A rich, bold coffee made by diluting a shot of espresso with hot water, offering a smooth and robust flavor.",
                Price = 2.99m,
                ImgUrl = "/images/americano.jpg",
                IsTrending = false
            },
            new Product
            {
                Id = 2,
                Name = "Cappuccino",
                Description = "A classic Italian coffee combining equal parts espresso, steamed milk, and milk foam for a creamy texture.",
                Price = 3.49m,
                ImgUrl = "/images/cappuccino.jpg",
                IsTrending = true
            },
            new Product
            {
                Id = 3,
                Name = "Drip Coffee",
                Description = "A traditional brewed coffee prepared using a drip filter, known for its balanced and smooth taste.",
                Price = 1.99m,
                ImgUrl = "/images/drip-coffee.jpg",
                IsTrending = false
            },
            new Product
            {
                Id = 4,
                Name = "Espresso",
                Description = "A concentrated coffee shot with a bold, intense flavor, serving as the foundation for many coffee beverages.",
                Price = 2.49m,
                ImgUrl = "/images/espresso.jpg",
                IsTrending = true
            },
            new Product
            {
                Id = 5,
                Name = "Latte",
                Description = "A creamy coffee drink made with a shot of espresso and steamed milk, topped with a thin layer of foam.",
                Price = 3.99m,
                ImgUrl = "/images/latte.jpg",
                IsTrending = true
            },
            new Product
            {
                Id = 6,
                Name = "Mocha",
                Description = "A decadent coffee treat blending espresso, steamed milk, and chocolate syrup, topped with whipped cream.",
                Price = 4.49m,
                ImgUrl = "/images/mocha.jpg",
                IsTrending = true
            }
        };

        public IEnumerable<Product> GetAllProducts()
        {
            return _productList;
        }

        public IEnumerable<Product> GetAllTrendingProducts()
        {
            return _productList.Where(p => p.IsTrending);
        }

        public Product GetProductDetailsById(int id)
        {
            return _productList.FirstOrDefault(p => p.Id == id);
        }
    };
}
