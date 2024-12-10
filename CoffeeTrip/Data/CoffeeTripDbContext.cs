using CoffeeTrip.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CoffeeTrip.Data
{
    public class CoffeeTripDbContext : IdentityDbContext
    {
        public CoffeeTripDbContext(DbContextOptions<CoffeeTripDbContext> options) : base(options) 
        { 

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Americano",
                    Description = "A rich, bold coffee made by diluting a shot of espresso with hot water, offering a smooth and robust flavor.",
                    Price = 299m,
                    ImgUrl = "/images/americano.jpg",
                    IsTrending = false
                },
                new Product
                {
                    Id = 2,
                    Name = "Espresso",
                    Description = "A concentrated coffee shot with a bold, intense flavor, serving as the foundation for many coffee beverages.",
                    Price = 249m,
                    ImgUrl = "/images/espresso.jpg",
                    IsTrending = true
                },
                new Product
                {
                    Id = 3,
                    Name = "Drip Coffee",
                    Description = "A traditional brewed coffee prepared using a drip filter, known for its balanced and smooth taste.",
                    Price = 199m,
                    ImgUrl = "/images/drip-coffee.jpg",
                    IsTrending = false
                },
                new Product
                {
                    Id = 4,
                    Name = "Cappuccino",
                    Description = "A classic Italian coffee combining equal parts espresso, steamed milk, and milk foam for a creamy texture.",
                    Price = 349m,
                    ImgUrl = "/images/cappuccino.jpg",
                    IsTrending = true
                },
                new Product
                {
                    Id = 5,
                    Name = "Latte",
                    Description = "A creamy coffee drink made with a shot of espresso and steamed milk, topped with a thin layer of foam.",
                    Price = 399m,
                    ImgUrl = "/images/latte.jpg",
                    IsTrending = true
                },
                new Product
                {
                    Id = 6,
                    Name = "Mocha",
                    Description = "A decadent coffee treat blending espresso, steamed milk, and chocolate syrup, topped with whipped cream.",
                    Price = 449m,
                    ImgUrl = "/images/mocha.jpg",
                    IsTrending = true
                }
            );
        }
    }
}
