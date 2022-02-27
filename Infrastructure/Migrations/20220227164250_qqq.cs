using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class qqq : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Funds",
                keyColumn: "Id",
                keyValue: new Guid("d9b55238-4720-4cbb-b026-2338528a5870"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "09ce4ad1-8f20-4e85-aa94-9758cf9fb88d");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "FundId", "IsActive", "LockoutEnabled", "LockoutEnd", "NationalCode", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UserName", "userRoles" },
                values: new object[] { "c6cce804-26ae-40ba-8675-a2ac8992ce3c", 0, "e2c50fa1-de26-450b-9857-d47fa875ced1", null, false, null, new Guid("fe95365e-6a69-48de-80c0-6f5ac9d074ba"), false, false, null, null, null, null, null, "12345", null, false, null, "ec3378a3-2e4b-419b-aad5-22af5f6f957d", false, "test", 0 });

            migrationBuilder.InsertData(
                table: "Funds",
                columns: new[] { "Id", "AdminName", "FundName", "FundRules", "FundSubmitDate", "UserId" },
                values: new object[] { new Guid("fe95365e-6a69-48de-80c0-6f5ac9d074ba"), "test", "همکاران", null, new DateTime(2022, 2, 27, 20, 12, 50, 55, DateTimeKind.Local).AddTicks(9527), "c6cce804-26ae-40ba-8675-a2ac8992ce3c" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Funds",
                keyColumn: "Id",
                keyValue: new Guid("fe95365e-6a69-48de-80c0-6f5ac9d074ba"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c6cce804-26ae-40ba-8675-a2ac8992ce3c");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "FundId", "IsActive", "LockoutEnabled", "LockoutEnd", "NationalCode", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UserName", "userRoles" },
                values: new object[] { "09ce4ad1-8f20-4e85-aa94-9758cf9fb88d", 0, "e91089b7-b4a5-4553-b646-03f14b768d4c", null, false, null, new Guid("d9b55238-4720-4cbb-b026-2338528a5870"), false, false, null, null, null, null, "12345", null, false, null, "ed99d67c-d1c5-4526-8119-ccc90f3175b1", false, "test", 0 });

            migrationBuilder.InsertData(
                table: "Funds",
                columns: new[] { "Id", "AdminName", "FundName", "FundRules", "FundSubmitDate", "UserId" },
                values: new object[] { new Guid("d9b55238-4720-4cbb-b026-2338528a5870"), "test", "همکاران", null, new DateTime(2022, 2, 27, 15, 17, 27, 464, DateTimeKind.Local).AddTicks(7497), "09ce4ad1-8f20-4e85-aa94-9758cf9fb88d" });
        }
    }
}
