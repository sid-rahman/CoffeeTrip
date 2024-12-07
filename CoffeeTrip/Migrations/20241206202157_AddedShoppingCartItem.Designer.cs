﻿// <auto-generated />
using CoffeeTrip.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CoffeeTrip.Migrations
{
    [DbContext(typeof(CoffeeTripDbContext))]
    [Migration("20241206202157_AddedShoppingCartItem")]
    partial class AddedShoppingCartItem
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CoffeeTrip.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsTrending")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "A rich, bold coffee made by diluting a shot of espresso with hot water, offering a smooth and robust flavor.",
                            ImgUrl = "/images/americano.jpg",
                            IsTrending = false,
                            Name = "Americano",
                            Price = 299m
                        },
                        new
                        {
                            Id = 2,
                            Description = "A concentrated coffee shot with a bold, intense flavor, serving as the foundation for many coffee beverages.",
                            ImgUrl = "/images/espresso.jpg",
                            IsTrending = true,
                            Name = "Espresso",
                            Price = 249m
                        },
                        new
                        {
                            Id = 3,
                            Description = "A traditional brewed coffee prepared using a drip filter, known for its balanced and smooth taste.",
                            ImgUrl = "/images/drip-coffee.jpg",
                            IsTrending = false,
                            Name = "Drip Coffee",
                            Price = 199m
                        },
                        new
                        {
                            Id = 4,
                            Description = "A classic Italian coffee combining equal parts espresso, steamed milk, and milk foam for a creamy texture.",
                            ImgUrl = "/images/cappuccino.jpg",
                            IsTrending = true,
                            Name = "Cappuccino",
                            Price = 349m
                        },
                        new
                        {
                            Id = 5,
                            Description = "A creamy coffee drink made with a shot of espresso and steamed milk, topped with a thin layer of foam.",
                            ImgUrl = "/images/latte.jpg",
                            IsTrending = true,
                            Name = "Latte",
                            Price = 399m
                        },
                        new
                        {
                            Id = 6,
                            Description = "A decadent coffee treat blending espresso, steamed milk, and chocolate syrup, topped with whipped cream.",
                            ImgUrl = "/images/mocha.jpg",
                            IsTrending = true,
                            Name = "Mocha",
                            Price = 449m
                        });
                });

            modelBuilder.Entity("CoffeeTrip.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("ShoppingCartId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("productId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("productId");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("CoffeeTrip.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("CoffeeTrip.Models.Product", "product")
                        .WithMany()
                        .HasForeignKey("productId");

                    b.Navigation("product");
                });
#pragma warning restore 612, 618
        }
    }
}
