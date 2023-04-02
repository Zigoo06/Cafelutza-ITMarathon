using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cafelutza.Data.Migrations
{
    public partial class AddedRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Users_Id",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Raports_Id",
                table: "Raports");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Raports",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Raports_UserId",
                table: "Raports",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Raports_Users_UserId",
                table: "Raports",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Raports_Users_UserId",
                table: "Raports");

            migrationBuilder.DropIndex(
                name: "IX_Raports_UserId",
                table: "Raports");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Raports");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Id",
                table: "Users",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Raports_Id",
                table: "Raports",
                column: "Id",
                unique: true);
        }
    }
}
