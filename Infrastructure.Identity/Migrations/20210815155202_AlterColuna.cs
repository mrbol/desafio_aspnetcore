using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Identity.Migrations
{
    public partial class AlterColuna : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastName",
                schema: "Identity",
                table: "TB_User",
                newName: "UltimoNome");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                schema: "Identity",
                table: "TB_User",
                newName: "PrimeiroNome");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UltimoNome",
                schema: "Identity",
                table: "TB_User",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "PrimeiroNome",
                schema: "Identity",
                table: "TB_User",
                newName: "FirstName");
        }
    }
}
