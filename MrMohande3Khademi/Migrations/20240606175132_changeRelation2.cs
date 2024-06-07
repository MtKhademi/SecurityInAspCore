using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MrMohande3Khademi.Migrations
{
    /// <inheritdoc />
    public partial class changeRelation2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RoleEntityUserEntity");

            migrationBuilder.AddColumn<int>(
                name: "UserEntityId",
                table: "Roles",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDateTime", "InsertDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2024, 6, 6, 21, 21, 32, 188, DateTimeKind.Local).AddTicks(8384), new DateTime(2024, 6, 6, 21, 21, 32, 188, DateTimeKind.Local).AddTicks(8398), new DateTime(2024, 6, 6, 21, 21, 32, 188, DateTimeKind.Local).AddTicks(8397) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDateTime", "InsertDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2024, 6, 6, 21, 21, 32, 188, DateTimeKind.Local).AddTicks(8400), new DateTime(2024, 6, 6, 21, 21, 32, 188, DateTimeKind.Local).AddTicks(8402), new DateTime(2024, 6, 6, 21, 21, 32, 188, DateTimeKind.Local).AddTicks(8401) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDateTime", "InsertDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2024, 6, 6, 21, 21, 32, 188, DateTimeKind.Local).AddTicks(8403), new DateTime(2024, 6, 6, 21, 21, 32, 188, DateTimeKind.Local).AddTicks(8404), new DateTime(2024, 6, 6, 21, 21, 32, 188, DateTimeKind.Local).AddTicks(8404) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDateTime", "InsertDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2024, 6, 6, 21, 21, 32, 188, DateTimeKind.Local).AddTicks(8405), new DateTime(2024, 6, 6, 21, 21, 32, 188, DateTimeKind.Local).AddTicks(8407), new DateTime(2024, 6, 6, 21, 21, 32, 188, DateTimeKind.Local).AddTicks(8406) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDateTime", "InsertDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2024, 6, 6, 21, 21, 32, 188, DateTimeKind.Local).AddTicks(8408), new DateTime(2024, 6, 6, 21, 21, 32, 188, DateTimeKind.Local).AddTicks(8410), new DateTime(2024, 6, 6, 21, 21, 32, 188, DateTimeKind.Local).AddTicks(8409) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserEntityId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "UserEntityId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Roles_UserEntityId",
                table: "Roles",
                column: "UserEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Roles_Users_UserEntityId",
                table: "Roles",
                column: "UserEntityId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Roles_Users_UserEntityId",
                table: "Roles");

            migrationBuilder.DropIndex(
                name: "IX_Roles_UserEntityId",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "UserEntityId",
                table: "Roles");

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

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDateTime", "InsertDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2024, 6, 6, 21, 20, 6, 401, DateTimeKind.Local).AddTicks(7972), new DateTime(2024, 6, 6, 21, 20, 6, 401, DateTimeKind.Local).AddTicks(7990), new DateTime(2024, 6, 6, 21, 20, 6, 401, DateTimeKind.Local).AddTicks(7988) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDateTime", "InsertDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2024, 6, 6, 21, 20, 6, 401, DateTimeKind.Local).AddTicks(7992), new DateTime(2024, 6, 6, 21, 20, 6, 401, DateTimeKind.Local).AddTicks(7994), new DateTime(2024, 6, 6, 21, 20, 6, 401, DateTimeKind.Local).AddTicks(7994) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDateTime", "InsertDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2024, 6, 6, 21, 20, 6, 401, DateTimeKind.Local).AddTicks(7996), new DateTime(2024, 6, 6, 21, 20, 6, 401, DateTimeKind.Local).AddTicks(7998), new DateTime(2024, 6, 6, 21, 20, 6, 401, DateTimeKind.Local).AddTicks(7997) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDateTime", "InsertDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2024, 6, 6, 21, 20, 6, 401, DateTimeKind.Local).AddTicks(8000), new DateTime(2024, 6, 6, 21, 20, 6, 401, DateTimeKind.Local).AddTicks(8002), new DateTime(2024, 6, 6, 21, 20, 6, 401, DateTimeKind.Local).AddTicks(8001) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDateTime", "InsertDateTime", "UpdateDateTime" },
                values: new object[] { new DateTime(2024, 6, 6, 21, 20, 6, 401, DateTimeKind.Local).AddTicks(8003), new DateTime(2024, 6, 6, 21, 20, 6, 401, DateTimeKind.Local).AddTicks(8005), new DateTime(2024, 6, 6, 21, 20, 6, 401, DateTimeKind.Local).AddTicks(8004) });

            migrationBuilder.CreateIndex(
                name: "IX_RoleEntityUserEntity_UsersId",
                table: "RoleEntityUserEntity",
                column: "UsersId");
        }
    }
}
