using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _002_AutnenticationWithIdentity.Migrations
{
    /// <inheritdoc />
    public partial class addSeedIdenetiyUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b847ae02-e80d-42e2-bd5d-e76f71f059be", 0, "e4f76e7e-f2bb-468e-8f0a-2dbc9e922436", "mt.khademi@gmail.com", false, false, null, null, null, "123", null, false, "b17c6f8a-bc73-47a4-8df6-6dc94fd0c498", false, "mt.khademi" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b847ae02-e80d-42e2-bd5d-e76f71f059be");
        }
    }
}
