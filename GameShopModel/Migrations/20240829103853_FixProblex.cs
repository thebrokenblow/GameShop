using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameShopModel.Migrations
{
    /// <inheritdoc />
    public partial class FixProblex : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GameProducts_Carts_CartId",
                table: "GameProducts");

            migrationBuilder.DropIndex(
                name: "IX_GameProducts_CartId",
                table: "GameProducts");

            migrationBuilder.DropColumn(
                name: "CartId",
                table: "GameProducts");

            migrationBuilder.CreateTable(
                name: "CartGameProduct",
                columns: table => new
                {
                    CartsId = table.Column<int>(type: "int", nullable: false),
                    GameProductsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartGameProduct", x => new { x.CartsId, x.GameProductsId });
                    table.ForeignKey(
                        name: "FK_CartGameProduct_Carts_CartsId",
                        column: x => x.CartsId,
                        principalTable: "Carts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartGameProduct_GameProducts_GameProductsId",
                        column: x => x.GameProductsId,
                        principalTable: "GameProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CartGameProduct_GameProductsId",
                table: "CartGameProduct",
                column: "GameProductsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartGameProduct");

            migrationBuilder.AddColumn<int>(
                name: "CartId",
                table: "GameProducts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_GameProducts_CartId",
                table: "GameProducts",
                column: "CartId");

            migrationBuilder.AddForeignKey(
                name: "FK_GameProducts_Carts_CartId",
                table: "GameProducts",
                column: "CartId",
                principalTable: "Carts",
                principalColumn: "Id");
        }
    }
}
