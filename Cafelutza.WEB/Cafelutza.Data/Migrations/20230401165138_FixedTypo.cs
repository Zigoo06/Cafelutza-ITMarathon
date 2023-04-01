using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cafelutza.Data.Migrations
{
    public partial class FixedTypo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Descrition",
                table: "Raports",
                newName: "Description");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Raports",
                newName: "Descrition");
        }
    }
}
