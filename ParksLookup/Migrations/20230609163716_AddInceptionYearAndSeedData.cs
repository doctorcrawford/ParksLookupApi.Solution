using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ParksLookup.Migrations
{
    public partial class AddInceptionYearAndSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Parks",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "FeaturedAnimal", "InceptionYear", "Name", "State", "Type" },
                values: new object[,]
                {
                    { 1, "Elk", 1872, "Yellowstone", "Wyoming", "National" },
                    { 2, "Golden-Mantled Ground Squirrel", 1902, "Crater Lake", "Oregon", "National" },
                    { 3, "Desert Bighorn Sheep", 1964, "Canyonlands", "Utah", "National" },
                    { 4, "Great Horned Owl", 1958, "Oswald West State Park", "Oregon", "State" },
                    { 5, "Red-Shouldered Hawks", 1929, "Fahnestock", "New York", "State" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Parks");
        }
    }
}
