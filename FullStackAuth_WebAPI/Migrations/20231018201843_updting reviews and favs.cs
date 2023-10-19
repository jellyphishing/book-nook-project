using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FullStackAuth_WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class updtingreviewsandfavs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7f7b9f6c-a1f8-4661-b016-d93984fa7320");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b11c8853-f9c4-42e9-a174-22b2faf9d5d9");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8e0bb08f-e46e-4803-b1ba-632d12f407bd", null, "Admin", "ADMIN" },
                    { "f147dd0d-7754-4aef-913b-899402ee0291", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8e0bb08f-e46e-4803-b1ba-632d12f407bd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f147dd0d-7754-4aef-913b-899402ee0291");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7f7b9f6c-a1f8-4661-b016-d93984fa7320", null, "User", "USER" },
                    { "b11c8853-f9c4-42e9-a174-22b2faf9d5d9", null, "Admin", "ADMIN" }
                });
        }
    }
}
