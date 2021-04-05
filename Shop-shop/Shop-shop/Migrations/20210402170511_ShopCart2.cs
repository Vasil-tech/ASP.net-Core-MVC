using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop_shop.Migrations
{
    public partial class ShopCart2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShopCartItem_Car_carId",
                table: "ShopCartItem");

            migrationBuilder.RenameColumn(
                name: "carId",
                table: "ShopCartItem",
                newName: "CarId");

            migrationBuilder.RenameIndex(
                name: "IX_ShopCartItem_carId",
                table: "ShopCartItem",
                newName: "IX_ShopCartItem_CarId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShopCartItem_Car_CarId",
                table: "ShopCartItem",
                column: "CarId",
                principalTable: "Car",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShopCartItem_Car_CarId",
                table: "ShopCartItem");

            migrationBuilder.RenameColumn(
                name: "CarId",
                table: "ShopCartItem",
                newName: "carId");

            migrationBuilder.RenameIndex(
                name: "IX_ShopCartItem_CarId",
                table: "ShopCartItem",
                newName: "IX_ShopCartItem_carId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShopCartItem_Car_carId",
                table: "ShopCartItem",
                column: "carId",
                principalTable: "Car",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
