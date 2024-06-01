using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _003_WriteOwn.Migrations
{
    /// <inheritdoc />
    public partial class User : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDateTime", "InsertDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2024, 5, 30, 11, 40, 18, 322, DateTimeKind.Local).AddTicks(836), new DateTime(2024, 5, 30, 11, 40, 18, 322, DateTimeKind.Local).AddTicks(847), new DateTime(2024, 5, 30, 11, 40, 18, 322, DateTimeKind.Local).AddTicks(847) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDateTime", "InsertDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2024, 5, 30, 11, 40, 18, 322, DateTimeKind.Local).AddTicks(849), new DateTime(2024, 5, 30, 11, 40, 18, 322, DateTimeKind.Local).AddTicks(850), new DateTime(2024, 5, 30, 11, 40, 18, 322, DateTimeKind.Local).AddTicks(850) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDateTime", "InsertDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2024, 5, 30, 11, 40, 18, 322, DateTimeKind.Local).AddTicks(851), new DateTime(2024, 5, 30, 11, 40, 18, 322, DateTimeKind.Local).AddTicks(853), new DateTime(2024, 5, 30, 11, 40, 18, 322, DateTimeKind.Local).AddTicks(852) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDateTime", "InsertDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2024, 5, 30, 11, 40, 18, 322, DateTimeKind.Local).AddTicks(853), new DateTime(2024, 5, 30, 11, 40, 18, 322, DateTimeKind.Local).AddTicks(855), new DateTime(2024, 5, 30, 11, 40, 18, 322, DateTimeKind.Local).AddTicks(854) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDateTime", "InsertDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2024, 5, 30, 11, 40, 18, 322, DateTimeKind.Local).AddTicks(856), new DateTime(2024, 5, 30, 11, 40, 18, 322, DateTimeKind.Local).AddTicks(857), new DateTime(2024, 5, 30, 11, 40, 18, 322, DateTimeKind.Local).AddTicks(857) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDateTime", "InsertDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2024, 5, 29, 10, 56, 32, 360, DateTimeKind.Local).AddTicks(3254), new DateTime(2024, 5, 29, 10, 56, 32, 360, DateTimeKind.Local).AddTicks(3283), new DateTime(2024, 5, 29, 10, 56, 32, 360, DateTimeKind.Local).AddTicks(3281) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDateTime", "InsertDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2024, 5, 29, 10, 56, 32, 360, DateTimeKind.Local).AddTicks(3285), new DateTime(2024, 5, 29, 10, 56, 32, 360, DateTimeKind.Local).AddTicks(3288), new DateTime(2024, 5, 29, 10, 56, 32, 360, DateTimeKind.Local).AddTicks(3287) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDateTime", "InsertDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2024, 5, 29, 10, 56, 32, 360, DateTimeKind.Local).AddTicks(3289), new DateTime(2024, 5, 29, 10, 56, 32, 360, DateTimeKind.Local).AddTicks(3291), new DateTime(2024, 5, 29, 10, 56, 32, 360, DateTimeKind.Local).AddTicks(3290) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDateTime", "InsertDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2024, 5, 29, 10, 56, 32, 360, DateTimeKind.Local).AddTicks(3292), new DateTime(2024, 5, 29, 10, 56, 32, 360, DateTimeKind.Local).AddTicks(3294), new DateTime(2024, 5, 29, 10, 56, 32, 360, DateTimeKind.Local).AddTicks(3293) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDateTime", "InsertDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2024, 5, 29, 10, 56, 32, 360, DateTimeKind.Local).AddTicks(3357), new DateTime(2024, 5, 29, 10, 56, 32, 360, DateTimeKind.Local).AddTicks(3359), new DateTime(2024, 5, 29, 10, 56, 32, 360, DateTimeKind.Local).AddTicks(3359) });
        }
    }
}
