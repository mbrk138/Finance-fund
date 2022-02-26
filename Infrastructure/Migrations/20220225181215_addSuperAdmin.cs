using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class addSuperAdmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdminId",
                table: "Funds");

            migrationBuilder.AddColumn<int>(
                name: "userRoles",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "FundId", "IsActive", "LockoutEnabled", "LockoutEnd", "NationalCode", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UserName", "userRoles" },
                values: new object[] { "a6f55e0f-9cf0-46c2-8be9-5298779b5d24", 0, "87ab04c6-7887-4716-a287-0fee8bab923e", null, false, null, new Guid("380747af-995b-4bb0-8372-f974ced51e50"), false, false, null, null, null, null, "12345", null, false, null, "9b1c4cbf-c378-4d69-8446-a998833fd232", false, "test", 0 });

            migrationBuilder.InsertData(
                table: "Funds",
                columns: new[] { "Id", "AdminName", "FundName", "FundRules", "FundSubmitDate", "UserId" },
                values: new object[] { new Guid("380747af-995b-4bb0-8372-f974ced51e50"), "test", "همکاران", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "a6f55e0f-9cf0-46c2-8be9-5298779b5d24" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Funds",
                keyColumn: "Id",
                keyValue: new Guid("380747af-995b-4bb0-8372-f974ced51e50"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a6f55e0f-9cf0-46c2-8be9-5298779b5d24");

            migrationBuilder.DropColumn(
                name: "userRoles",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "AdminId",
                table: "Funds",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
