using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class qqqr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Funds",
                keyColumn: "Id",
                keyValue: new Guid("fe95365e-6a69-48de-80c0-6f5ac9d074ba"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c6cce804-26ae-40ba-8675-a2ac8992ce3c");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "FundId", "IsActive", "LockoutEnabled", "LockoutEnd", "NationalCode", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UserName", "userRoles" },
                values: new object[] { "1e1a7f1c-046a-4b4c-b691-200d8785ce3a", 0, "0c49b173-3a7e-400a-8515-ce17ef01dafe", null, false, null, new Guid("d79fb832-f949-4bfe-ab8f-d586876944d1"), false, false, null, null, null, null, "12345", null, null, false, null, "d092705a-ace2-445d-90fc-64bbcf2ce073", false, "test", 0 });

            migrationBuilder.InsertData(
                table: "Funds",
                columns: new[] { "Id", "AdminName", "FundName", "FundRules", "FundSubmitDate", "UserId" },
                values: new object[] { new Guid("d79fb832-f949-4bfe-ab8f-d586876944d1"), "test", "همکاران", null, new DateTime(2022, 2, 27, 20, 14, 0, 934, DateTimeKind.Local).AddTicks(1333), "1e1a7f1c-046a-4b4c-b691-200d8785ce3a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Funds",
                keyColumn: "Id",
                keyValue: new Guid("d79fb832-f949-4bfe-ab8f-d586876944d1"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1e1a7f1c-046a-4b4c-b691-200d8785ce3a");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "FundId", "IsActive", "LockoutEnabled", "LockoutEnd", "NationalCode", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UserName", "userRoles" },
                values: new object[] { "c6cce804-26ae-40ba-8675-a2ac8992ce3c", 0, "e2c50fa1-de26-450b-9857-d47fa875ced1", null, false, null, new Guid("fe95365e-6a69-48de-80c0-6f5ac9d074ba"), false, false, null, null, null, null, null, "12345", null, false, null, "ec3378a3-2e4b-419b-aad5-22af5f6f957d", false, "test", 0 });

            migrationBuilder.InsertData(
                table: "Funds",
                columns: new[] { "Id", "AdminName", "FundName", "FundRules", "FundSubmitDate", "UserId" },
                values: new object[] { new Guid("fe95365e-6a69-48de-80c0-6f5ac9d074ba"), "test", "همکاران", null, new DateTime(2022, 2, 27, 20, 12, 50, 55, DateTimeKind.Local).AddTicks(9527), "c6cce804-26ae-40ba-8675-a2ac8992ce3c" });
        }
    }
}
