using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelApi.Migrations
{
    public partial class AddRatingSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TravelDests",
                keyColumn: "TravelDestId",
                keyValue: 1,
                column: "Review",
                value: "Peaceful and clean city with lots of unique art and history");

            migrationBuilder.UpdateData(
                table: "TravelDests",
                keyColumn: "TravelDestId",
                keyValue: 2,
                column: "Review",
                value: "Taroko National Park is a must see!");

            migrationBuilder.UpdateData(
                table: "TravelDests",
                keyColumn: "TravelDestId",
                keyValue: 3,
                columns: new[] { "CityName", "Review" },
                values: new object[] { "Victoria BC", "An overlooked gem. The Royal BC Museum is the single best dispaly of Native American artifacts and totem poles." });

            migrationBuilder.UpdateData(
                table: "TravelDests",
                keyColumn: "TravelDestId",
                keyValue: 4,
                column: "Review",
                value: "Amazing beaches and shaved ice. Be sure to take a trip around the whole island. Can be done in a weekend.");

            migrationBuilder.UpdateData(
                table: "TravelDests",
                keyColumn: "TravelDestId",
                keyValue: 5,
                column: "Review",
                value: "So easy to get around by bike. Amazing bread and pastries on every corner.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TravelDests",
                keyColumn: "TravelDestId",
                keyValue: 1,
                column: "Review",
                value: null);

            migrationBuilder.UpdateData(
                table: "TravelDests",
                keyColumn: "TravelDestId",
                keyValue: 2,
                column: "Review",
                value: null);

            migrationBuilder.UpdateData(
                table: "TravelDests",
                keyColumn: "TravelDestId",
                keyValue: 3,
                columns: new[] { "CityName", "Review" },
                values: new object[] { "Victoria", null });

            migrationBuilder.UpdateData(
                table: "TravelDests",
                keyColumn: "TravelDestId",
                keyValue: 4,
                column: "Review",
                value: null);

            migrationBuilder.UpdateData(
                table: "TravelDests",
                keyColumn: "TravelDestId",
                keyValue: 5,
                column: "Review",
                value: null);
        }
    }
}
