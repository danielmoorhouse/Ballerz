using Microsoft.EntityFrameworkCore.Migrations;

namespace Ballerz.Migrations
{
    public partial class stevemcdonald : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlayerHistories_Leagues_LeaguesId",
                table: "PlayerHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayerHistories_Players_PlayersId",
                table: "PlayerHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayerHistories_Seasons_SeasonsId",
                table: "PlayerHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayerHistories_Teams_TeamsId",
                table: "PlayerHistories");

            migrationBuilder.DropIndex(
                name: "IX_PlayerHistories_LeaguesId",
                table: "PlayerHistories");

            migrationBuilder.DropIndex(
                name: "IX_PlayerHistories_PlayersId",
                table: "PlayerHistories");

            migrationBuilder.DropIndex(
                name: "IX_PlayerHistories_SeasonsId",
                table: "PlayerHistories");

            migrationBuilder.DropIndex(
                name: "IX_PlayerHistories_TeamsId",
                table: "PlayerHistories");

            migrationBuilder.DropColumn(
                name: "LeaguesId",
                table: "PlayerHistories");

            migrationBuilder.DropColumn(
                name: "PlayerId",
                table: "PlayerHistories");

            migrationBuilder.DropColumn(
                name: "PlayersId",
                table: "PlayerHistories");

            migrationBuilder.DropColumn(
                name: "SeasonsId",
                table: "PlayerHistories");

            migrationBuilder.DropColumn(
                name: "TeamsId",
                table: "PlayerHistories");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LeaguesId",
                table: "PlayerHistories",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PlayerId",
                table: "PlayerHistories",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PlayersId",
                table: "PlayerHistories",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SeasonsId",
                table: "PlayerHistories",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TeamsId",
                table: "PlayerHistories",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PlayerHistories_LeaguesId",
                table: "PlayerHistories",
                column: "LeaguesId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerHistories_PlayersId",
                table: "PlayerHistories",
                column: "PlayersId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerHistories_SeasonsId",
                table: "PlayerHistories",
                column: "SeasonsId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerHistories_TeamsId",
                table: "PlayerHistories",
                column: "TeamsId");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerHistories_Leagues_LeaguesId",
                table: "PlayerHistories",
                column: "LeaguesId",
                principalTable: "Leagues",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerHistories_Players_PlayersId",
                table: "PlayerHistories",
                column: "PlayersId",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerHistories_Seasons_SeasonsId",
                table: "PlayerHistories",
                column: "SeasonsId",
                principalTable: "Seasons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerHistories_Teams_TeamsId",
                table: "PlayerHistories",
                column: "TeamsId",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
