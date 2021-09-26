using Microsoft.EntityFrameworkCore.Migrations;

namespace BankingApp.Infra.Migrations
{
    public partial class D : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "YieldType",
                table: "Calculator",
                newName: "YieldName");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Calculator",
                newName: "Yield");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "YieldName",
                table: "Calculator",
                newName: "YieldType");

            migrationBuilder.RenameColumn(
                name: "Yield",
                table: "Calculator",
                newName: "Id");
        }
    }
}
