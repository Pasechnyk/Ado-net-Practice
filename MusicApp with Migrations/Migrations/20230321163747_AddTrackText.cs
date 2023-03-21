using Microsoft.EntityFrameworkCore.Migrations;

// Adding Lyrics with Migration

namespace MusicApp.Migrations
{
    public partial class AddTrackText : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Lyrics",
                table: "Tracks",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Lyrics",
                table: "Tracks");
        }
    }
}
