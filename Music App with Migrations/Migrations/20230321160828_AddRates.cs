using Microsoft.EntityFrameworkCore.Migrations;

// Adding Rates with Migration

namespace MusicApp.Migrations
{
    public partial class AddRates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Rate",
                table: "PlayLists",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Rate",
                table: "Tracks",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Rate",
                table: "Albums",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rate",
                table: "PlayLists");

            migrationBuilder.DropColumn(
                name: "Rate",
                table: "Tracks");

            migrationBuilder.DropColumn(
                name: "Rate",
                table: "Albums");
        }
    }
}
