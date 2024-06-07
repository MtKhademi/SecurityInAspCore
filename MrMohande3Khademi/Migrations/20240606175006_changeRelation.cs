using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MrMohande3Khademi.Migrations
{
    /// <inheritdoc />
    public partial class changeRelation : Migration
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
                name: "RoleEntityUserEntity",
                columns: table => new
                {
                    RolesId = table.Column<int>(type: "INTEGER", nullable: false),
                    UsersId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleEntityUserEntity", x => new { x.RolesId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_RoleEntityUserEntity_Roles_RolesId",
                        column: x => x.RolesId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoleEntityUserEntity_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CreateDateTime", "CreatedBy", "DeletedDateTime", "Description", "InsertDateTime", "IsDeleted", "Name", "Rate", "UpdateDateTime" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 6, 21, 20, 6, 401, DateTimeKind.Local).AddTicks(7972), "Mt.khademi", null, "", new DateTime(2024, 6, 6, 21, 20, 6, 401, DateTimeKind.Local).AddTicks(7990), false, "Movie 001", 10, new DateTime(2024, 6, 6, 21, 20, 6, 401, DateTimeKind.Local).AddTicks(7988) },
                    { 2, new DateTime(2024, 6, 6, 21, 20, 6, 401, DateTimeKind.Local).AddTicks(7992), "Brother warner", null, "", new DateTime(2024, 6, 6, 21, 20, 6, 401, DateTimeKind.Local).AddTicks(7994), false, "Movie 002", 10, new DateTime(2024, 6, 6, 21, 20, 6, 401, DateTimeKind.Local).AddTicks(7994) },
                    { 3, new DateTime(2024, 6, 6, 21, 20, 6, 401, DateTimeKind.Local).AddTicks(7996), "Pixar", null, "", new DateTime(2024, 6, 6, 21, 20, 6, 401, DateTimeKind.Local).AddTicks(7998), false, "Movie 003", 10, new DateTime(2024, 6, 6, 21, 20, 6, 401, DateTimeKind.Local).AddTicks(7997) },
                    { 4, new DateTime(2024, 6, 6, 21, 20, 6, 401, DateTimeKind.Local).AddTicks(8000), "Alibaba", null, "", new DateTime(2024, 6, 6, 21, 20, 6, 401, DateTimeKind.Local).AddTicks(8002), false, "Movie 004", 10, new DateTime(2024, 6, 6, 21, 20, 6, 401, DateTimeKind.Local).AddTicks(8001) },
                    { 5, new DateTime(2024, 6, 6, 21, 20, 6, 401, DateTimeKind.Local).AddTicks(8003), "Vedio Full intertanment", null, "", new DateTime(2024, 6, 6, 21, 20, 6, 401, DateTimeKind.Local).AddTicks(8005), false, "Movie 005", 10, new DateTime(2024, 6, 6, 21, 20, 6, 401, DateTimeKind.Local).AddTicks(8004) }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ControllerAccess", "Name" },
                values: new object[,]
                {
                    { 1, "api/movie", "administrator" },
                    { 2, "", "user" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_RoleEntityUserEntity_UsersId",
                table: "RoleEntityUserEntity",
                column: "UsersId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "RoleEntityUserEntity");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
