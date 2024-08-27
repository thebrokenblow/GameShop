using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameShopModel.Migrations
{
    /// <inheritdoc />
    public partial class ChangeNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GameProducts_MinimumSystemRequirements_MinimumSystemRequirementId",
                table: "GameProducts");

            migrationBuilder.AlterColumn<int>(
                name: "MinimumSystemRequirementId",
                table: "GameProducts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_GameProducts_MinimumSystemRequirements_MinimumSystemRequirementId",
                table: "GameProducts",
                column: "MinimumSystemRequirementId",
                principalTable: "MinimumSystemRequirements",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GameProducts_MinimumSystemRequirements_MinimumSystemRequirementId",
                table: "GameProducts");

            migrationBuilder.AlterColumn<int>(
                name: "MinimumSystemRequirementId",
                table: "GameProducts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_GameProducts_MinimumSystemRequirements_MinimumSystemRequirementId",
                table: "GameProducts",
                column: "MinimumSystemRequirementId",
                principalTable: "MinimumSystemRequirements",
                principalColumn: "Id");
        }
    }
}
