using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MrMohande3Khademi.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
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
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    ControllerAccess = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
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

            migrationBuilder.CreateTable(
                name: "UserRoleEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    RoleId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoleEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserRoleEntity_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoleEntity_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CreateDateTime", "CreatedBy", "DeletedDateTime", "Description", "InsertDateTime", "IsDeleted", "Name", "Rate", "UpdateDateTime" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 5, 14, 36, 39, 677, DateTimeKind.Local).AddTicks(5227), "Mt.khademi", null, "", new DateTime(2024, 6, 5, 14, 36, 39, 677, DateTimeKind.Local).AddTicks(5248), false, "Movie 001", 10, new DateTime(2024, 6, 5, 14, 36, 39, 677, DateTimeKind.Local).AddTicks(5247) },
                    { 2, new DateTime(2024, 6, 5, 14, 36, 39, 677, DateTimeKind.Local).AddTicks(5250), "Brother warner", null, "", new DateTime(2024, 6, 5, 14, 36, 39, 677, DateTimeKind.Local).AddTicks(5252), false, "Movie 002", 10, new DateTime(2024, 6, 5, 14, 36, 39, 677, DateTimeKind.Local).AddTicks(5251) },
                    { 3, new DateTime(2024, 6, 5, 14, 36, 39, 677, DateTimeKind.Local).AddTicks(5253), "Pixar", null, "", new DateTime(2024, 6, 5, 14, 36, 39, 677, DateTimeKind.Local).AddTicks(5256), false, "Movie 003", 10, new DateTime(2024, 6, 5, 14, 36, 39, 677, DateTimeKind.Local).AddTicks(5255) },
                    { 4, new DateTime(2024, 6, 5, 14, 36, 39, 677, DateTimeKind.Local).AddTicks(5257), "Alibaba", null, "", new DateTime(2024, 6, 5, 14, 36, 39, 677, DateTimeKind.Local).AddTicks(5259), false, "Movie 004", 10, new DateTime(2024, 6, 5, 14, 36, 39, 677, DateTimeKind.Local).AddTicks(5258) },
                    { 5, new DateTime(2024, 6, 5, 14, 36, 39, 677, DateTimeKind.Local).AddTicks(5260), "Vedio Full intertanment", null, "", new DateTime(2024, 6, 5, 14, 36, 39, 677, DateTimeKind.Local).AddTicks(5262), false, "Movie 005", 10, new DateTime(2024, 6, 5, 14, 36, 39, 677, DateTimeKind.Local).AddTicks(5262) }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ControllerAccess", "Name" },
                values: new object[,]
                {
                    { 1, "movieController", "administrator" },
                    { 2, "", "user" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserRoleEntity_RoleId",
                table: "UserRoleEntity",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoleEntity_UserId",
                table: "UserRoleEntity",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "UserRoleEntity");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
