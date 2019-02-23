using Microsoft.EntityFrameworkCore.Migrations;

namespace Ballerz.Migrations
{
    public partial class peter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PlayersId",
                table: "PlayerHistories",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PlayerHistories_PlayersId",
                table: "PlayerHistories",
                column: "PlayersId");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerHistories_Players_PlayersId",
                table: "PlayerHistories",
                column: "PlayersId",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlayerHistories_Players_PlayersId",
                table: "PlayerHistories");

            migrationBuilder.DropIndex(
                name: "IX_PlayerHistories_PlayersId",
                table: "PlayerHistories");

            migrationBuilder.DropColumn(
                name: "PlayersId",
                table: "PlayerHistories");
        }
    }
}
