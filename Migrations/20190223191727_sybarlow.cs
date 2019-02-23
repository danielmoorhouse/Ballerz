using Microsoft.EntityFrameworkCore.Migrations;

namespace Ballerz.Migrations
{
    public partial class sybarlow : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PlayerName",
                table: "PlayerHistories");

            migrationBuilder.AddColumn<int>(
                name: "PlayerId",
                table: "PlayerHistories",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PlayerId",
                table: "PlayerHistories");

            migrationBuilder.AddColumn<string>(
                name: "PlayerName",
                table: "PlayerHistories",
                nullable: true);
        }
    }
}
