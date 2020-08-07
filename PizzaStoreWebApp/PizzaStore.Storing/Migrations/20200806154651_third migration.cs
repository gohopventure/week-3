using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaStore.Storing.Migrations
{
    public partial class thirdmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pizzas_CrustModel_crustId",
                table: "Pizzas");

            migrationBuilder.DropForeignKey(
                name: "FK_Pizzas_SizeModel_sizeId",
                table: "Pizzas");

            migrationBuilder.DropForeignKey(
                name: "FK_ToppingModel_Pizzas_PizzaModelId",
                table: "ToppingModel");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Stores");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ToppingModel",
                table: "ToppingModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SizeModel",
                table: "SizeModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CrustModel",
                table: "CrustModel");

            migrationBuilder.RenameTable(
                name: "ToppingModel",
                newName: "Toppings");

            migrationBuilder.RenameTable(
                name: "SizeModel",
                newName: "Sizes");

            migrationBuilder.RenameTable(
                name: "CrustModel",
                newName: "Crusts");

            migrationBuilder.RenameColumn(
                name: "sizeId",
                table: "Pizzas",
                newName: "SizeId");

            migrationBuilder.RenameColumn(
                name: "crustId",
                table: "Pizzas",
                newName: "CrustId");

            migrationBuilder.RenameIndex(
                name: "IX_Pizzas_sizeId",
                table: "Pizzas",
                newName: "IX_Pizzas_SizeId");

            migrationBuilder.RenameIndex(
                name: "IX_Pizzas_crustId",
                table: "Pizzas",
                newName: "IX_Pizzas_CrustId");

            migrationBuilder.RenameIndex(
                name: "IX_ToppingModel_PizzaModelId",
                table: "Toppings",
                newName: "IX_Toppings_PizzaModelId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Toppings",
                table: "Toppings",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sizes",
                table: "Sizes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Crusts",
                table: "Crusts",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pizzas_Crusts_CrustId",
                table: "Pizzas",
                column: "CrustId",
                principalTable: "Crusts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pizzas_Sizes_SizeId",
                table: "Pizzas",
                column: "SizeId",
                principalTable: "Sizes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Toppings_Pizzas_PizzaModelId",
                table: "Toppings",
                column: "PizzaModelId",
                principalTable: "Pizzas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pizzas_Crusts_CrustId",
                table: "Pizzas");

            migrationBuilder.DropForeignKey(
                name: "FK_Pizzas_Sizes_SizeId",
                table: "Pizzas");

            migrationBuilder.DropForeignKey(
                name: "FK_Toppings_Pizzas_PizzaModelId",
                table: "Toppings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Toppings",
                table: "Toppings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sizes",
                table: "Sizes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Crusts",
                table: "Crusts");

            migrationBuilder.RenameTable(
                name: "Toppings",
                newName: "ToppingModel");

            migrationBuilder.RenameTable(
                name: "Sizes",
                newName: "SizeModel");

            migrationBuilder.RenameTable(
                name: "Crusts",
                newName: "CrustModel");

            migrationBuilder.RenameColumn(
                name: "SizeId",
                table: "Pizzas",
                newName: "sizeId");

            migrationBuilder.RenameColumn(
                name: "CrustId",
                table: "Pizzas",
                newName: "crustId");

            migrationBuilder.RenameIndex(
                name: "IX_Pizzas_SizeId",
                table: "Pizzas",
                newName: "IX_Pizzas_sizeId");

            migrationBuilder.RenameIndex(
                name: "IX_Pizzas_CrustId",
                table: "Pizzas",
                newName: "IX_Pizzas_crustId");

            migrationBuilder.RenameIndex(
                name: "IX_Toppings_PizzaModelId",
                table: "ToppingModel",
                newName: "IX_ToppingModel_PizzaModelId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ToppingModel",
                table: "ToppingModel",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SizeModel",
                table: "SizeModel",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CrustModel",
                table: "CrustModel",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Pizzas_CrustModel_crustId",
                table: "Pizzas",
                column: "crustId",
                principalTable: "CrustModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pizzas_SizeModel_sizeId",
                table: "Pizzas",
                column: "sizeId",
                principalTable: "SizeModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ToppingModel_Pizzas_PizzaModelId",
                table: "ToppingModel",
                column: "PizzaModelId",
                principalTable: "Pizzas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
