using Microsoft.EntityFrameworkCore.Migrations;

namespace BankingApp.Infra.Migrations
{
    public partial class E : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Yield",
                table: "Calculator",
                newName: "YieldId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "YieldId",
                table: "Calculator",
                newName: "Yield");
        }
    }
}
