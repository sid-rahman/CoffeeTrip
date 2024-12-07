using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoffeeTrip.Migrations
{
    /// <inheritdoc />
    public partial class AlteredShopingCartItemProperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCartItems_Products_productId",
                table: "ShoppingCartItems");

            migrationBuilder.RenameColumn(
                name: "productId",
                table: "ShoppingCartItems",
                newName: "ProductId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "ShoppingCartItems",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_ShoppingCartItems_productId",
                table: "ShoppingCartItems",
                newName: "IX_ShoppingCartItems_ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCartItems_Products_ProductId",
                table: "ShoppingCartItems",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCartItems_Products_ProductId",
                table: "ShoppingCartItems");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "ShoppingCartItems",
                newName: "productId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ShoppingCartItems",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_ShoppingCartItems_ProductId",
                table: "ShoppingCartItems",
                newName: "IX_ShoppingCartItems_productId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCartItems_Products_productId",
                table: "ShoppingCartItems",
                column: "productId",
                principalTable: "Products",
                principalColumn: "Id");
        }
    }
}
