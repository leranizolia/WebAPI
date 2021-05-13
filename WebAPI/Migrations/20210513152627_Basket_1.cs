using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class Basket_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ShopCarId",
                table: "ShopCarItem",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "ShopCar",
                columns: table => new
                {
                    ShopCarId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopCar", x => x.ShopCarId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShopCarItem_ShopCarId",
                table: "ShopCarItem",
                column: "ShopCarId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShopCarItem_ShopCar_ShopCarId",
                table: "ShopCarItem",
                column: "ShopCarId",
                principalTable: "ShopCar",
                principalColumn: "ShopCarId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShopCarItem_ShopCar_ShopCarId",
                table: "ShopCarItem");

            migrationBuilder.DropTable(
                name: "ShopCar");

            migrationBuilder.DropIndex(
                name: "IX_ShopCarItem_ShopCarId",
                table: "ShopCarItem");

            migrationBuilder.AlterColumn<string>(
                name: "ShopCarId",
                table: "ShopCarItem",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
