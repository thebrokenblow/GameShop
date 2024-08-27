using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameShopModel.Migrations
{
    /// <inheritdoc />
    public partial class AddMinimumSystemRequirementsAndRecommendedSystemRequirements : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MinimumSystemRequirements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Processor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RandomAccessMemory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VideoCard = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DirectX = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiskSpace = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoundCard = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Network = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Additionally = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MinimumSystemRequirements", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RecommendedSystemRequirements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Processor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RandomAccessMemory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VideoCard = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DirectX = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiskSpace = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoundCard = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Network = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Additionally = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecommendedSystemRequirements", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MinimumSystemRequirements");

            migrationBuilder.DropTable(
                name: "RecommendedSystemRequirements");
        }
    }
}
