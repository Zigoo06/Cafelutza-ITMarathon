using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cafelutza.Data.Migrations
{
    public partial class ChangedImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Raports");

            migrationBuilder.AddColumn<string>(
                name: "ImageURL",
                table: "Raports",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageURL",
                table: "Raports");

            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "Raports",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);
        }
    }
}
