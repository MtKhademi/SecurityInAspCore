using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Khademi.Migrations
{
    /// <inheritdoc />
    public partial class changeDbContext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "04be86ad-13dd-4f4a-af13-723ee5bdce1a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "58e30350-7d36-437f-acf8-c8103f8f08c1");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0daeaa6c-6aa5-4fca-bef0-0e42a861541e", null, "administrator", null },
                    { "2366efe7-a5e1-4c24-90f7-c435f36e42b4", null, "user", null }
                });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDateTime", "InsertDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2024, 6, 5, 22, 59, 46, 236, DateTimeKind.Local).AddTicks(83), new DateTime(2024, 6, 5, 22, 59, 46, 236, DateTimeKind.Local).AddTicks(97), new DateTime(2024, 6, 5, 22, 59, 46, 236, DateTimeKind.Local).AddTicks(97) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDateTime", "InsertDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2024, 6, 5, 22, 59, 46, 236, DateTimeKind.Local).AddTicks(133), new DateTime(2024, 6, 5, 22, 59, 46, 236, DateTimeKind.Local).AddTicks(135), new DateTime(2024, 6, 5, 22, 59, 46, 236, DateTimeKind.Local).AddTicks(134) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDateTime", "InsertDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2024, 6, 5, 22, 59, 46, 236, DateTimeKind.Local).AddTicks(136), new DateTime(2024, 6, 5, 22, 59, 46, 236, DateTimeKind.Local).AddTicks(138), new DateTime(2024, 6, 5, 22, 59, 46, 236, DateTimeKind.Local).AddTicks(137) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDateTime", "InsertDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2024, 6, 5, 22, 59, 46, 236, DateTimeKind.Local).AddTicks(139), new DateTime(2024, 6, 5, 22, 59, 46, 236, DateTimeKind.Local).AddTicks(140), new DateTime(2024, 6, 5, 22, 59, 46, 236, DateTimeKind.Local).AddTicks(140) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDateTime", "InsertDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2024, 6, 5, 22, 59, 46, 236, DateTimeKind.Local).AddTicks(141), new DateTime(2024, 6, 5, 22, 59, 46, 236, DateTimeKind.Local).AddTicks(143), new DateTime(2024, 6, 5, 22, 59, 46, 236, DateTimeKind.Local).AddTicks(142) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0daeaa6c-6aa5-4fca-bef0-0e42a861541e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2366efe7-a5e1-4c24-90f7-c435f36e42b4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "04be86ad-13dd-4f4a-af13-723ee5bdce1a", null, "user", null },
                    { "58e30350-7d36-437f-acf8-c8103f8f08c1", null, "administrator", null }
                });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDateTime", "InsertDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2024, 6, 5, 22, 52, 0, 657, DateTimeKind.Local).AddTicks(5104), new DateTime(2024, 6, 5, 22, 52, 0, 657, DateTimeKind.Local).AddTicks(5118), new DateTime(2024, 6, 5, 22, 52, 0, 657, DateTimeKind.Local).AddTicks(5117) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDateTime", "InsertDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2024, 6, 5, 22, 52, 0, 657, DateTimeKind.Local).AddTicks(5119), new DateTime(2024, 6, 5, 22, 52, 0, 657, DateTimeKind.Local).AddTicks(5121), new DateTime(2024, 6, 5, 22, 52, 0, 657, DateTimeKind.Local).AddTicks(5120) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDateTime", "InsertDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2024, 6, 5, 22, 52, 0, 657, DateTimeKind.Local).AddTicks(5122), new DateTime(2024, 6, 5, 22, 52, 0, 657, DateTimeKind.Local).AddTicks(5124), new DateTime(2024, 6, 5, 22, 52, 0, 657, DateTimeKind.Local).AddTicks(5123) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDateTime", "InsertDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2024, 6, 5, 22, 52, 0, 657, DateTimeKind.Local).AddTicks(5125), new DateTime(2024, 6, 5, 22, 52, 0, 657, DateTimeKind.Local).AddTicks(5126), new DateTime(2024, 6, 5, 22, 52, 0, 657, DateTimeKind.Local).AddTicks(5126) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDateTime", "InsertDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2024, 6, 5, 22, 52, 0, 657, DateTimeKind.Local).AddTicks(5127), new DateTime(2024, 6, 5, 22, 52, 0, 657, DateTimeKind.Local).AddTicks(5129), new DateTime(2024, 6, 5, 22, 52, 0, 657, DateTimeKind.Local).AddTicks(5128) });
        }
    }
}
