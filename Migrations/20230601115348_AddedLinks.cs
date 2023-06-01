using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hobbies.Migrations
{
    /// <inheritdoc />
    public partial class AddedLinks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Links",
                columns: new[] { "LinkID", "InterestID", "LinkURL", "PersonID" },
                values: new object[,]
                {
                    { 1, 1, "https://www.svenskfotboll.se/", 1 },
                    { 2, 1, "https://www.fotbollskanalen.se/", 1 },
                    { 3, 2, "https://www.golf.se/", 2 },
                    { 4, 2, "https://www.golf.se/", 3 },
                    { 5, 2, "https://www.golf.se/", 4 },
                    { 6, 3, "https://www.tennis.se/", 2 },
                    { 7, 3, "https://www.tennis.se/", 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "LinkID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "LinkID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "LinkID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "LinkID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "LinkID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "LinkID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "LinkID",
                keyValue: 7);
        }
    }
}
