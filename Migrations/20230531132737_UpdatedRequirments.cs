using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hobbies.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedRequirments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Interests",
                columns: new[] { "InterestID", "Description" },
                values: new object[,]
                {
                    { 1, "Fotboll" },
                    { 2, "Golf" },
                    { 3, "Tennis" },
                    { 4, "Bordtennis" }
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "PersonID", "Email", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, "Peter.Larsson@gmail.com", "Peter Larsson", "873298479" },
                    { 2, "Lars.Petersson@gmail.com", "Lars Petersson", "873298479" },
                    { 3, "Maja.Larsson@gmail.com", "Maja Larsson", "873298479" },
                    { 4, "Filip.Majasson@gmail.com", "Filip Majasson", "873298479" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "InterestID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "InterestID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "InterestID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "InterestID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonID",
                keyValue: 4);
        }
    }
}
