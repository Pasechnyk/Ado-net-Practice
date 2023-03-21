using Microsoft.EntityFrameworkCore.Migrations;

// Adding Play Count with Migration

namespace MusicApp.Migrations
{
    public partial class AddPlayCount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PlayCount",
                table: "Tracks",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PlayCount",
                table: "Tracks");
        }
    }
}
