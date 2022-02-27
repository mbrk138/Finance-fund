using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class aaa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Funds",
                keyColumn: "Id",
                keyValue: new Guid("380747af-995b-4bb0-8372-f974ced51e50"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a6f55e0f-9cf0-46c2-8be9-5298779b5d24");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "FundId", "IsActive", "LockoutEnabled", "LockoutEnd", "NationalCode", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UserName", "userRoles" },
                values: new object[] { "09ce4ad1-8f20-4e85-aa94-9758cf9fb88d", 0, "e91089b7-b4a5-4553-b646-03f14b768d4c", null, false, null, new Guid("d9b55238-4720-4cbb-b026-2338528a5870"), false, false, null, null, null, null, "12345", null, false, null, "ed99d67c-d1c5-4526-8119-ccc90f3175b1", false, "test", 0 });

            migrationBuilder.InsertData(
                table: "Funds",
                columns: new[] { "Id", "AdminName", "FundName", "FundRules", "FundSubmitDate", "UserId" },
                values: new object[] { new Guid("d9b55238-4720-4cbb-b026-2338528a5870"), "test", "همکاران", null, new DateTime(2022, 2, 27, 15, 17, 27, 464, DateTimeKind.Local).AddTicks(7497), "09ce4ad1-8f20-4e85-aa94-9758cf9fb88d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Funds",
                keyColumn: "Id",
                keyValue: new Guid("d9b55238-4720-4cbb-b026-2338528a5870"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "09ce4ad1-8f20-4e85-aa94-9758cf9fb88d");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "FundId", "IsActive", "LockoutEnabled", "LockoutEnd", "NationalCode", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UserName", "userRoles" },
                values: new object[] { "a6f55e0f-9cf0-46c2-8be9-5298779b5d24", 0, "87ab04c6-7887-4716-a287-0fee8bab923e", null, false, null, new Guid("380747af-995b-4bb0-8372-f974ced51e50"), false, false, null, null, null, null, "12345", null, false, null, "9b1c4cbf-c378-4d69-8446-a998833fd232", false, "test", 0 });

            migrationBuilder.InsertData(
                table: "Funds",
                columns: new[] { "Id", "AdminName", "FundName", "FundRules", "FundSubmitDate", "UserId" },
                values: new object[] { new Guid("380747af-995b-4bb0-8372-f974ced51e50"), "test", "همکاران", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "a6f55e0f-9cf0-46c2-8be9-5298779b5d24" });
        }
    }
}
