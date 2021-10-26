using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BankingApp.Infra.Migrations
{
    public partial class C : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Calculator",
                table: "Calculator");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Transaction");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "PersonalLoan");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Notification");

            migrationBuilder.DropColumn(
                name: "FirstMidName",
                table: "LoanManager");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "LoanManager");

            migrationBuilder.DropColumn(
                name: "Photo",
                table: "LoanManager");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "LoanManager");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Investment");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "HomeLoan");

            migrationBuilder.DropColumn(
                name: "FirstMidName",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Photo",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "CarLoan");

            migrationBuilder.DropColumn(
                name: "YieldId",
                table: "Calculator");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Bank");

            migrationBuilder.DropColumn(
                name: "FirstMidName",
                table: "ATMManager");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "ATMManager");

            migrationBuilder.DropColumn(
                name: "Photo",
                table: "ATMManager");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "ATMManager");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "ATM");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Account");

            migrationBuilder.RenameColumn(
                name: "YieldName",
                table: "Calculator",
                newName: "Name");

            migrationBuilder.AddColumn<DateTime>(
                name: "From",
                table: "Transaction",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "To",
                table: "Transaction",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "From",
                table: "PersonalLoan",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "To",
                table: "PersonalLoan",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "From",
                table: "Notification",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "To",
                table: "Notification",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "LoanManager",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "LoanManager",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "From",
                table: "LoanManager",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "LoanManager",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "To",
                table: "LoanManager",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "From",
                table: "Investment",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "To",
                table: "Investment",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "From",
                table: "HomeLoan",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "To",
                table: "HomeLoan",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "From",
                table: "Customer",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "To",
                table: "Customer",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "From",
                table: "CarLoan",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "To",
                table: "CarLoan",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "Calculator",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Calculator",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "From",
                table: "Calculator",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "To",
                table: "Calculator",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Bank",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Bank",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "From",
                table: "Bank",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "To",
                table: "Bank",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "ATMManager",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "ATMManager",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "From",
                table: "ATMManager",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "ATMManager",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "To",
                table: "ATMManager",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "From",
                table: "ATM",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "To",
                table: "ATM",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AccountNickname",
                table: "Account",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "From",
                table: "Account",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "To",
                table: "Account",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Calculator",
                table: "Calculator",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Calculator",
                table: "Calculator");

            migrationBuilder.DropColumn(
                name: "From",
                table: "Transaction");

            migrationBuilder.DropColumn(
                name: "To",
                table: "Transaction");

            migrationBuilder.DropColumn(
                name: "From",
                table: "PersonalLoan");

            migrationBuilder.DropColumn(
                name: "To",
                table: "PersonalLoan");

            migrationBuilder.DropColumn(
                name: "From",
                table: "Notification");

            migrationBuilder.DropColumn(
                name: "To",
                table: "Notification");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "LoanManager");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "LoanManager");

            migrationBuilder.DropColumn(
                name: "From",
                table: "LoanManager");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "LoanManager");

            migrationBuilder.DropColumn(
                name: "To",
                table: "LoanManager");

            migrationBuilder.DropColumn(
                name: "From",
                table: "Investment");

            migrationBuilder.DropColumn(
                name: "To",
                table: "Investment");

            migrationBuilder.DropColumn(
                name: "From",
                table: "HomeLoan");

            migrationBuilder.DropColumn(
                name: "To",
                table: "HomeLoan");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "From",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "To",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "From",
                table: "CarLoan");

            migrationBuilder.DropColumn(
                name: "To",
                table: "CarLoan");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Calculator");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "Calculator");

            migrationBuilder.DropColumn(
                name: "From",
                table: "Calculator");

            migrationBuilder.DropColumn(
                name: "To",
                table: "Calculator");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "Bank");

            migrationBuilder.DropColumn(
                name: "From",
                table: "Bank");

            migrationBuilder.DropColumn(
                name: "To",
                table: "Bank");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "ATMManager");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "ATMManager");

            migrationBuilder.DropColumn(
                name: "From",
                table: "ATMManager");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "ATMManager");

            migrationBuilder.DropColumn(
                name: "To",
                table: "ATMManager");

            migrationBuilder.DropColumn(
                name: "From",
                table: "ATM");

            migrationBuilder.DropColumn(
                name: "To",
                table: "ATM");

            migrationBuilder.DropColumn(
                name: "AccountNickname",
                table: "Account");

            migrationBuilder.DropColumn(
                name: "From",
                table: "Account");

            migrationBuilder.DropColumn(
                name: "To",
                table: "Account");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Calculator",
                newName: "YieldName");

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "Transaction",
                type: "rowversion",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "PersonalLoan",
                type: "rowversion",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "Notification",
                type: "rowversion",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstMidName",
                table: "LoanManager",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "LoanManager",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Photo",
                table: "LoanManager",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "LoanManager",
                type: "rowversion",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "Investment",
                type: "rowversion",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "HomeLoan",
                type: "rowversion",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstMidName",
                table: "Customer",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Customer",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Photo",
                table: "Customer",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "Customer",
                type: "rowversion",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "CarLoan",
                type: "rowversion",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "YieldId",
                table: "Calculator",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Bank",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "Bank",
                type: "rowversion",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstMidName",
                table: "ATMManager",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "ATMManager",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Photo",
                table: "ATMManager",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "ATMManager",
                type: "rowversion",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "ATM",
                type: "rowversion",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "Account",
                type: "rowversion",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Calculator",
                table: "Calculator",
                column: "YieldId");
        }
    }
}
