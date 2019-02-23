using Microsoft.EntityFrameworkCore.Migrations;

namespace Ballerz.Migrations
{
    public partial class frank : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TeamId",
                table: "PlayerHistories");

            migrationBuilder.AddColumn<string>(
                name: "PlayerName",
                table: "PlayerHistories",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TeamName",
                table: "PlayerHistories",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PlayerName",
                table: "PlayerHistories");

            migrationBuilder.DropColumn(
                name: "TeamName",
                table: "PlayerHistories");

            migrationBuilder.AddColumn<int>(
                name: "TeamId",
                table: "PlayerHistories",
                nullable: false,
                defaultValue: 0);
        }
    }
}
