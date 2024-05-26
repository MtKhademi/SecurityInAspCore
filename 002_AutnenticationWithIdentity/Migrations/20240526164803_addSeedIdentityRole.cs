using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace _002_AutnenticationWithIdentity.Migrations
{
    /// <inheritdoc />
    public partial class addSeedIdentityRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b847ae02-e80d-42e2-bd5d-e76f71f059be");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6929fb5d-8ebf-4684-bb98-4f3e1110b59e", null, "administrator", null },
                    { "729d4ae2-6996-4270-a032-ae675e1c2fad", null, "seller", null },
                    { "c7e7a36f-85c7-4557-9192-6e04185aecb2", null, "user", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a1f851db-9e21-45e7-96f4-f6ff4fc04b84", 0, "5359ed30-85e9-4e66-84cd-3a7f5341b174", "mt.khademi@gmail.com", false, false, null, null, null, "123", null, false, "09a37160-e1d8-44fc-8054-ea355f70a18d", false, "mt.khademi" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6929fb5d-8ebf-4684-bb98-4f3e1110b59e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "729d4ae2-6996-4270-a032-ae675e1c2fad");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c7e7a36f-85c7-4557-9192-6e04185aecb2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1f851db-9e21-45e7-96f4-f6ff4fc04b84");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b847ae02-e80d-42e2-bd5d-e76f71f059be", 0, "e4f76e7e-f2bb-468e-8f0a-2dbc9e922436", "mt.khademi@gmail.com", false, false, null, null, null, "123", null, false, "b17c6f8a-bc73-47a4-8df6-6dc94fd0c498", false, "mt.khademi" });
        }
    }
}
