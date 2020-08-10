using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaStore.Storing.Migrations
{
    public partial class thirdmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Stores_StoreModelId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Users_UserModelId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_StoreModelId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_UserModelId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Details",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "OrderTotal",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "StoreModelId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "UserModelId",
                table: "Orders");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Details",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "OrderTotal",
                table: "Orders",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "StoreModelId",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserModelId",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_StoreModelId",
                table: "Orders",
                column: "StoreModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserModelId",
                table: "Orders",
                column: "UserModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Stores_StoreModelId",
                table: "Orders",
                column: "StoreModelId",
                principalTable: "Stores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Users_UserModelId",
                table: "Orders",
                column: "UserModelId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
