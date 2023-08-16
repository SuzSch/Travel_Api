using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelApi.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TravelDests",
                columns: new[] { "TravelDestId", "CityName", "CountryName", "Rating" },
                values: new object[,]
                {
                    { 1, "Oslo", "Norway", 9 },
                    { 2, "Taipei", "Tiawan", 7 },
                    { 3, "Victoria", "Canada", 8 },
                    { 4, "Kona", "United States of America", 8 },
                    { 5, "Copenhagen", "Denmark", 8 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TravelDests",
                keyColumn: "TravelDestId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TravelDests",
                keyColumn: "TravelDestId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TravelDests",
                keyColumn: "TravelDestId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TravelDests",
                keyColumn: "TravelDestId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TravelDests",
                keyColumn: "TravelDestId",
                keyValue: 5);
        }
    }
}
