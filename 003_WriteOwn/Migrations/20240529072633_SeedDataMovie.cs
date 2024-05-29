using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace _003_WriteOwn.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataMovie : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Rate = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    CreateDateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    InsertDateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdateDateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DeletedDateTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserName = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false),
                    CreateDateTime = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CreateDateTime", "CreatedBy", "DeletedDateTime", "Description", "InsertDateTime", "IsDeleted", "Name", "Rate", "UpdateDateTime" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 29, 10, 56, 32, 360, DateTimeKind.Local).AddTicks(3254), "Mt.khademi", null, "", new DateTime(2024, 5, 29, 10, 56, 32, 360, DateTimeKind.Local).AddTicks(3283), false, "Movie 001", 10, new DateTime(2024, 5, 29, 10, 56, 32, 360, DateTimeKind.Local).AddTicks(3281) },
                    { 2, new DateTime(2024, 5, 29, 10, 56, 32, 360, DateTimeKind.Local).AddTicks(3285), "Brother warner", null, "", new DateTime(2024, 5, 29, 10, 56, 32, 360, DateTimeKind.Local).AddTicks(3288), false, "Movie 002", 10, new DateTime(2024, 5, 29, 10, 56, 32, 360, DateTimeKind.Local).AddTicks(3287) },
                    { 3, new DateTime(2024, 5, 29, 10, 56, 32, 360, DateTimeKind.Local).AddTicks(3289), "Pixar", null, "", new DateTime(2024, 5, 29, 10, 56, 32, 360, DateTimeKind.Local).AddTicks(3291), false, "Movie 003", 10, new DateTime(2024, 5, 29, 10, 56, 32, 360, DateTimeKind.Local).AddTicks(3290) },
                    { 4, new DateTime(2024, 5, 29, 10, 56, 32, 360, DateTimeKind.Local).AddTicks(3292), "Alibaba", null, "", new DateTime(2024, 5, 29, 10, 56, 32, 360, DateTimeKind.Local).AddTicks(3294), false, "Movie 004", 10, new DateTime(2024, 5, 29, 10, 56, 32, 360, DateTimeKind.Local).AddTicks(3293) },
                    { 5, new DateTime(2024, 5, 29, 10, 56, 32, 360, DateTimeKind.Local).AddTicks(3357), "Vedio Full intertanment", null, "", new DateTime(2024, 5, 29, 10, 56, 32, 360, DateTimeKind.Local).AddTicks(3359), false, "Movie 005", 10, new DateTime(2024, 5, 29, 10, 56, 32, 360, DateTimeKind.Local).AddTicks(3359) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
