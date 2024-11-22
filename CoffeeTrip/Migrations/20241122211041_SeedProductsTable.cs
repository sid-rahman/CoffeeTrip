using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CoffeeTrip.Migrations
{
    /// <inheritdoc />
    public partial class SeedProductsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImgUrl", "IsTrending", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "A rich, bold coffee made by diluting a shot of espresso with hot water, offering a smooth and robust flavor.", "/images/americano.jpg", false, "Americano", 299m },
                    { 2, "A classic Italian coffee combining equal parts espresso, steamed milk, and milk foam for a creamy texture.", "/images/cappuccino.jpg", true, "Cappuccino", 349m },
                    { 3, "A traditional brewed coffee prepared using a drip filter, known for its balanced and smooth taste.", "/images/drip-coffee.jpg", false, "Drip Coffee", 199m },
                    { 4, "A concentrated coffee shot with a bold, intense flavor, serving as the foundation for many coffee beverages.", "/images/espresso.jpg", true, "Espresso", 249m },
                    { 5, "A creamy coffee drink made with a shot of espresso and steamed milk, topped with a thin layer of foam.", "/images/latte.jpg", true, "Latte", 399m },
                    { 6, "A decadent coffee treat blending espresso, steamed milk, and chocolate syrup, topped with whipped cream.", "/images/mocha.jpg", true, "Mocha", 449m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
