using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Soonet.Migrations
{
    /// <inheritdoc />
    public partial class seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "64740c7a-932a-4cb2-adf6-dd8886e7dd17", null, "User", "USER" },
                    { "cbb08cf6-cee1-416f-a86b-3fa9ee8c27cd", null, "Provider", "PROVIDER" },
                    { "ea91d7bd-31e6-4a46-86b7-53ca5f7e2a81", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "64740c7a-932a-4cb2-adf6-dd8886e7dd17");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbb08cf6-cee1-416f-a86b-3fa9ee8c27cd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ea91d7bd-31e6-4a46-86b7-53ca5f7e2a81");
        }
    }
}
