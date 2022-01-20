using Microsoft.EntityFrameworkCore.Migrations;

namespace BankingApp.Infra.Migrations
{
    public partial class _1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RecipientId",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "RecipientName",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "SenderId",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "SenderName",
                table: "Transactions");

            migrationBuilder.AddColumn<string>(
                name: "ATMProcessId",
                table: "Notifications",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CurrencySwapId",
                table: "Notifications",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InvestmentId",
                table: "Notifications",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LoanId",
                table: "Notifications",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TransactionId",
                table: "Notifications",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ATMProcessId",
                table: "Notifications");

            migrationBuilder.DropColumn(
                name: "CurrencySwapId",
                table: "Notifications");

            migrationBuilder.DropColumn(
                name: "InvestmentId",
                table: "Notifications");

            migrationBuilder.DropColumn(
                name: "LoanId",
                table: "Notifications");

            migrationBuilder.DropColumn(
                name: "TransactionId",
                table: "Notifications");

            migrationBuilder.AddColumn<string>(
                name: "RecipientId",
                table: "Transactions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RecipientName",
                table: "Transactions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SenderId",
                table: "Transactions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SenderName",
                table: "Transactions",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
