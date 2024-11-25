using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CoffeeTrip.Migrations
{
    /// <inheritdoc />
    public partial class SeedingData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsTrending = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImgUrl", "IsTrending", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "A rich, bold coffee made by diluting a shot of espresso with hot water, offering a smooth and robust flavor.", "/images/americano.jpg", false, "Americano", 299m },
                    { 2, "A concentrated coffee shot with a bold, intense flavor, serving as the foundation for many coffee beverages.", "/images/espresso.jpg", true, "Espresso", 249m },
                    { 3, "A traditional brewed coffee prepared using a drip filter, known for its balanced and smooth taste.", "/images/drip-coffee.jpg", false, "Drip Coffee", 199m },
                    { 4, "A classic Italian coffee combining equal parts espresso, steamed milk, and milk foam for a creamy texture.", "/images/cappuccino.jpg", true, "Cappuccino", 349m },
                    { 5, "A creamy coffee drink made with a shot of espresso and steamed milk, topped with a thin layer of foam.", "/images/latte.jpg", true, "Latte", 399m },
                    { 6, "A decadent coffee treat blending espresso, steamed milk, and chocolate syrup, topped with whipped cream.", "/images/mocha.jpg", true, "Mocha", 449m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
