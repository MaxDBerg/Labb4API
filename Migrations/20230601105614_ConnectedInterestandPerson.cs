using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hobbies.Migrations
{
    /// <inheritdoc />
    public partial class ConnectedInterestandPerson : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "InterestPerson",
                columns: new[] { "InterestsInterestID", "PersonsPersonID" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 3 },
                    { 2, 1 },
                    { 3, 2 },
                    { 4, 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "InterestPerson",
                keyColumns: new[] { "InterestsInterestID", "PersonsPersonID" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "InterestPerson",
                keyColumns: new[] { "InterestsInterestID", "PersonsPersonID" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "InterestPerson",
                keyColumns: new[] { "InterestsInterestID", "PersonsPersonID" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "InterestPerson",
                keyColumns: new[] { "InterestsInterestID", "PersonsPersonID" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "InterestPerson",
                keyColumns: new[] { "InterestsInterestID", "PersonsPersonID" },
                keyValues: new object[] { 4, 4 });
        }
    }
}
