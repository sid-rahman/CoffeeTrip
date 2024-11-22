namespace CoffeeTrip.Models.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();
        IEnumerable<Product> GetAllTrendingProducts();
        Product GetProductDetailsById(int id);
    }
}
