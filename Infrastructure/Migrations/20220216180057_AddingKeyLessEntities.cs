using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class AddingKeyLessEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InstallmentCount",
                table: "ActiveLoans",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ProfilePicture",
                table: "ActiveLoans",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "activeLoanMores",
                columns: table => new
                {
                    UserName = table.Column<string>(nullable: true),
                    Amount = table.Column<decimal>(nullable: false),
                    DayOfMonth = table.Column<string>(nullable: true),
                    LoanType = table.Column<int>(nullable: false),
                    ProfilePicture = table.Column<string>(nullable: true),
                    NationalCode = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    InstallmentCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "DisactiveLoanMores",
                columns: table => new
                {
                    UserName = table.Column<string>(nullable: true),
                    Amount = table.Column<decimal>(nullable: false),
                    ProfilePicture = table.Column<string>(nullable: true),
                    PayTime = table.Column<DateTime>(nullable: false),
                    LoanType = table.Column<int>(nullable: false),
                    InstallmentCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "disActiveLoans",
                columns: table => new
                {
                    UserName = table.Column<string>(nullable: true),
                    Amount = table.Column<decimal>(nullable: false),
                    ProfilePicture = table.Column<string>(nullable: true),
                    PayTime = table.Column<DateTime>(nullable: false),
                    LoanType = table.Column<int>(nullable: false),
                    InstallmentCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "activeLoanMores");

            migrationBuilder.DropTable(
                name: "DisactiveLoanMores");

            migrationBuilder.DropTable(
                name: "disActiveLoans");

            migrationBuilder.DropColumn(
                name: "InstallmentCount",
                table: "ActiveLoans");

            migrationBuilder.DropColumn(
                name: "ProfilePicture",
                table: "ActiveLoans");
        }
    }
}
