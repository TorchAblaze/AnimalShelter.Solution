using Microsoft.EntityFrameworkCore.Migrations;

namespace Shelter.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "AdoptionStatus", "ApproximateAge", "Biography", "Breed", "FluffinessLevel", "HasShots", "Name", "Type" },
                values: new object[,]
                {
                    { 1, "unadopted", 0, "Likes green apples, long walks on the beach, and eyepatches", "Pitbull Mix", 6, true, "Captian Furbossa", "dog" },
                    { 2, "pending", 0, "Likes looking out windows, chasing lasers, and adventuring into laundry baskets", "Norwegian Forest Cat", 10, true, "Pawme Amidala", "cat" },
                    { 3, "unadopted", 0, "Likes sniffing, climbing on everything, and intelligent converstaions", "Brussels Griffon Mix", 7, true, "Wicket", "dog" },
                    { 4, "unadopted", 0, "Likes hiding things that don't belong to him, barking orders, and naps", "unknown", 4, true, "Admiral Ackbark", "dog" },
                    { 5, "unadopted", 0, "Likes causing chaos, destroying everything in sight, and belly rubs", "Birman", 6, true, "Catsian", "cat" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 5);
        }
    }
}
