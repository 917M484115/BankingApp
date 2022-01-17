using Microsoft.EntityFrameworkCore.Migrations;

namespace BankingApp.Infra.Migrations
{
    public partial class two : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amount",
                table: "Calculators");

            migrationBuilder.DropColumn(
                name: "Result",
                table: "Calculators");

            migrationBuilder.DropColumn(
                name: "Revenue",
                table: "Calculators");

            migrationBuilder.DropColumn(
                name: "TimeInMonths",
                table: "Calculators");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Amount",
                table: "Calculators",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Result",
                table: "Calculators",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Revenue",
                table: "Calculators",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "TimeInMonths",
                table: "Calculators",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
