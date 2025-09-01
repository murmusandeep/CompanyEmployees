using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CompanyEmployees.Migrations
{
    /// <inheritdoc />
    public partial class AddedRolesToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b49b9efc-20af-4d3f-bcb9-4c23556db8c6", "b49b9efc-20af-4d3f-bcb9-4c23556db8c6", "Manager", "MANAGER" },
                    { "c2301d1f-9f45-4a84-a0a1-d0b60a74b312", "c2301d1f-9f45-4a84-a0a1-d0b60a74b312", "Administrator", "ADMINISTRATOR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b49b9efc-20af-4d3f-bcb9-4c23556db8c6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c2301d1f-9f45-4a84-a0a1-d0b60a74b312");
        }
    }
}
