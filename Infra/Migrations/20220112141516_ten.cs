﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace BankingApp.Infra.Migrations
{
    public partial class ten : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccountId",
                table: "Customer");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Stock",
                type: "decimal(16,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Stock",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(16,4)");

            migrationBuilder.AddColumn<string>(
                name: "AccountId",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
