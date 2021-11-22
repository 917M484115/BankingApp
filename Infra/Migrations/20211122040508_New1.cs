﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace BankingApp.Infra.Migrations
{
    public partial class New1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Amount",
                table: "Calculator",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "TimeInMonths",
                table: "Calculator",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amount",
                table: "Calculator");

            migrationBuilder.DropColumn(
                name: "TimeInMonths",
                table: "Calculator");
        }
    }
}