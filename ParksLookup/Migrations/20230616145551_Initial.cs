using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ParksLookup.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Parks",
                columns: table => new
                {
                    ParkId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    State = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    InceptionYear = table.Column<int>(type: "int", nullable: false),
                    FeaturedAnimal = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parks", x => x.ParkId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "FeaturedAnimal", "InceptionYear", "Name", "State" },
                values: new object[,]
                {
                    { 1, "Elk", 1872, "Yellowstone", "Wyoming" },
                    { 2, "Golden-Mantled Ground Squirrel", 1902, "Crater Lake", "Oregon" },
                    { 3, "Desert Bighorn Sheep", 1964, "Canyonlands", "Utah" },
                    { 4, "Great Horned Owl", 1958, "Oswald West State Park", "Oregon" },
                    { 5, "Red-Shouldered Hawks", 1929, "Fahnestock", "New York" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Parks");
        }
    }
}
