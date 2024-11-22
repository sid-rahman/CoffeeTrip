using CoffeeTrip.Data;
using CoffeeTrip.Models.Interfaces;

namespace CoffeeTrip.Models.Services
{
    public class ProductRepository : IProductRepository
    {
        private CoffeeTripDbContext _context;
        public ProductRepository(CoffeeTripDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _context.Products;
        }

        public IEnumerable<Product> GetAllTrendingProducts()
        {
            return _context.Products.Where(p => p.IsTrending);
        }

        public Product? GetProductDetailsById(int id)
        {
            return _context.Products.FirstOrDefault(p => p.Id == id);
        }
    };
}
