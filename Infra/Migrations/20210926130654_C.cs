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

            migrationBuilder.AlterColumn<string>(
                name: "YieldType",
                table: "Calculator",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Calculator",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

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
                name: "Id",
                table: "Calculator");

            migrationBuilder.AlterColumn<string>(
                name: "YieldType",
                table: "Calculator",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Calculator",
                table: "Calculator",
                column: "YieldType");
        }
    }
}
