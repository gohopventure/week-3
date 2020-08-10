using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaStore.Storing.Migrations
{
    public partial class fourthmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pizzas_Orders_OrderModelId",
                table: "Pizzas");

            migrationBuilder.DropIndex(
                name: "IX_Pizzas_OrderModelId",
                table: "Pizzas");

            migrationBuilder.DropColumn(
                name: "OrderModelId",
                table: "Pizzas");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderModelId",
                table: "Pizzas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pizzas_OrderModelId",
                table: "Pizzas",
                column: "OrderModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pizzas_Orders_OrderModelId",
                table: "Pizzas",
                column: "OrderModelId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
