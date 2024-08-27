using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameShopModel.Migrations
{
    /// <inheritdoc />
    public partial class AddReference : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MinimumSystemRequirementId",
                table: "GameProducts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RecommendedSystemRequirementId",
                table: "GameProducts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_GameProducts_MinimumSystemRequirementId",
                table: "GameProducts",
                column: "MinimumSystemRequirementId");

            migrationBuilder.CreateIndex(
                name: "IX_GameProducts_RecommendedSystemRequirementId",
                table: "GameProducts",
                column: "RecommendedSystemRequirementId");

            migrationBuilder.AddForeignKey(
                name: "FK_GameProducts_MinimumSystemRequirements_MinimumSystemRequirementId",
                table: "GameProducts",
                column: "MinimumSystemRequirementId",
                principalTable: "MinimumSystemRequirements",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GameProducts_RecommendedSystemRequirements_RecommendedSystemRequirementId",
                table: "GameProducts",
                column: "RecommendedSystemRequirementId",
                principalTable: "RecommendedSystemRequirements",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GameProducts_MinimumSystemRequirements_MinimumSystemRequirementId",
                table: "GameProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_GameProducts_RecommendedSystemRequirements_RecommendedSystemRequirementId",
                table: "GameProducts");

            migrationBuilder.DropIndex(
                name: "IX_GameProducts_MinimumSystemRequirementId",
                table: "GameProducts");

            migrationBuilder.DropIndex(
                name: "IX_GameProducts_RecommendedSystemRequirementId",
                table: "GameProducts");

            migrationBuilder.DropColumn(
                name: "MinimumSystemRequirementId",
                table: "GameProducts");

            migrationBuilder.DropColumn(
                name: "RecommendedSystemRequirementId",
                table: "GameProducts");
        }
    }
}
