using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace _002_AutnenticationWithIdentity.Migrations
{
    /// <inheritdoc />
    public partial class sedd2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "00e3a53b-5619-4974-a7bb-e7b5bf9c8f4a", null, "administrator", null },
                    { "4c951984-f9f3-4be6-85ab-c965cc27c752", null, "user", null },
                    { "ec9791c1-3f08-4ce5-aa42-b6763d83c77b", null, "seller", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1a35d1d8-866f-4222-be3d-3fccff7d4ff2", 0, "cbff6074-536e-4aa4-88d6-84fbe33f6207", "mt.khademi2@gmail.com", false, false, null, "mt.khademi2@gmail.com", null, "123", null, false, "bb84a786-d064-40dd-83d7-c5c0d1c53c2f", false, "mt.khademi2" },
                    { "2d2adbf3-14c5-491b-b05c-4a53af15da20", 0, "35314552-565c-458a-9bbe-cb09e2634630", "mt.khademi@gmail.com", false, false, null, "mt.khademi@gmail.com", null, "123", null, false, "98a647a0-8d95-4136-bd0b-ca8cae05bb58", false, "mt.khademi" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00e3a53b-5619-4974-a7bb-e7b5bf9c8f4a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4c951984-f9f3-4be6-85ab-c965cc27c752");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ec9791c1-3f08-4ce5-aa42-b6763d83c77b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1a35d1d8-866f-4222-be3d-3fccff7d4ff2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2d2adbf3-14c5-491b-b05c-4a53af15da20");

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
    }
}
