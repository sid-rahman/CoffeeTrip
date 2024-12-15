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
                                Name = "Morning Bliss Instant Coffee",
                                Description = "Start your day with this smooth and mild coffee, crafted for a gentle yet satisfying wake-up call. " +
                                "Perfect for those who love a classic, balanced cup without overpowering flavors.",
                                Price = 999m,
                                ImgUrl = "/images/MorningBliss.jpg",
                                IsTrending = false
                            },
                            new Product
                            {
                                Id = 2,
                                Name = "Bold Awakening Dark Roast",
                                Description = "A rich and robust instant coffee with deep, smoky notes to power through your busy mornings. " +
                                "Ideal for strong coffee lovers who enjoy bold flavors.",
                                Price = 1050m,
                                ImgUrl = "/images/BoldAwakening.jpg",
                                IsTrending = true
                            },
                            new Product
                            {
                                Id = 3,
                                Name = "Vanilla Velvet Flavored Coffee",
                                Description = " Experience the creamy sweetness of vanilla in every sip with this indulgent instant coffee. " +
                                "A delightful treat for moments when you crave a touch of luxury.",
                                Price = 1200m,
                                ImgUrl = "/images/VanillaVelvet.jpg",
                                IsTrending = false
                            },
                            new Product
                            {
                                Id = 4,
                                Name = "Hazelnut Heaven Instant Blend",
                                Description = "Infused with the irresistible aroma of roasted hazelnuts, this blend offers a nutty twist to your coffee routine. " +
                                "A perfect choice for a cozy, flavorful cup.",
                                Price = 870m,
                                ImgUrl = "/images/HazelnutHeaven.jpg",
                                IsTrending = true
                            },
                            new Product
                            {
                                Id = 5,
                                Name = "Green Brew Healthy Coffee",
                                Description = "Packed with antioxidants, this green coffee blend is a guilt-free way to enjoy your caffeine fix. " +
                                "Ideal for health-conscious coffee drinkers seeking a natural energy boost.",
                                Price = 600m,
                                ImgUrl = "/images/GreenBrew.jpg",
                                IsTrending = false
                            },
                            new Product
                            {
                                Id = 6,
                                Name = "Luxury Reserve Arabica Blend",
                                Description = "Made from 100% premium Arabica beans, this instant coffee delivers a smooth, full-bodied flavor. " +
                                "Perfect for coffee enthusiasts who appreciate quality in every sip.",
                                Price = 1349m,
                                ImgUrl = "/images/LuxuryReserve.jpg",
                                IsTrending = true
                            },
                            new Product
                            {
                                Id = 7,
                                Name = "Mocha Magic Instant Latte",
                                Description = "Indulge in the perfect blend of chocolate and coffee with this mocha-flavored instant latte. " +
                                "Great for sweet-toothed coffee lovers and dessert-style drinks.",
                                Price = 750m,
                                ImgUrl = "/images/MochaMagic.jpg",
                                IsTrending = true
                            },
                            new Product
                            {
                                Id = 8,
                                Name = "Pumpkin Spice Latte",
                                Description = " A cozy mix of cinnamon, nutmeg, and clove infused with coffee, perfect for the autumn season. " +
                                "Sip into the warmth of fall with every cup.",
                                Price = 600m,
                                ImgUrl = "/images/PumpkinSpice.jpg",
                                IsTrending = false
                            },
                            new Product
                            {
                                Id = 9,
                                Name = "Travel Buddy Coffee Sachets (10 Pack)",
                                Description = "Convenient, single-serve sachets for coffee on the go. " +
                                "Each sachet delivers a fresh, balanced brew—perfect for busy mornings or outdoor adventures",
                                Price = 490m,
                                ImgUrl = "/images/TravelBuddy.jpg",
                                IsTrending = true
                            }
                        );
        }
    }
}
