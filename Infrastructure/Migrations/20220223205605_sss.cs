using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class sss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "AdminId",
                table: "Funds",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<string>(
                name: "AdminName",
                table: "Funds",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NationalCode",
                table: "DisactiveLoanMores",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "DisactiveLoanMores",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "FundId",
                table: "CreditCards",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "FundId",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "getInstallments",
                columns: table => new
                {
                    PayDate = table.Column<DateTime>(nullable: false),
                    Amount = table.Column<decimal>(nullable: false),
                    ReciptId = table.Column<string>(nullable: true),
                    IsPayed = table.Column<bool>(nullable: false),
                    InstallmentNumber = table.Column<long>(nullable: false),
                    InstallmentId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "getInstallments");

            migrationBuilder.DropColumn(
                name: "AdminName",
                table: "Funds");

            migrationBuilder.DropColumn(
                name: "NationalCode",
                table: "DisactiveLoanMores");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "DisactiveLoanMores");

            migrationBuilder.DropColumn(
                name: "FundId",
                table: "CreditCards");

            migrationBuilder.DropColumn(
                name: "FundId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<Guid>(
                name: "AdminId",
                table: "Funds",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
