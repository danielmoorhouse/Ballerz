using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Ballerz.Migrations
{
    public partial class jimmyking : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CurrentValue",
                table: "Players",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ManagerHistories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    ManagerId = table.Column<int>(nullable: false),
                    TeamId = table.Column<int>(nullable: false),
                    TeamsId = table.Column<int>(nullable: true),
                    Season = table.Column<string>(nullable: true),
                    SeasonsId = table.Column<int>(nullable: true),
                    LeagueName = table.Column<string>(nullable: true),
                    LeaguesId = table.Column<int>(nullable: true),
                    Position = table.Column<string>(nullable: true),
                    Points = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManagerHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ManagerHistories_Leagues_LeaguesId",
                        column: x => x.LeaguesId,
                        principalTable: "Leagues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ManagerHistories_Seasons_SeasonsId",
                        column: x => x.SeasonsId,
                        principalTable: "Seasons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ManagerHistories_Teams_TeamsId",
                        column: x => x.TeamsId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PlayerHistories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    PlayerId = table.Column<int>(nullable: false),
                    TeamId = table.Column<int>(nullable: false),
                    TeamsId = table.Column<int>(nullable: true),
                    Season = table.Column<string>(nullable: true),
                    SeasonsId = table.Column<int>(nullable: true),
                    LeagueName = table.Column<string>(nullable: true),
                    LeaguesId = table.Column<int>(nullable: true),
                    RedCards = table.Column<string>(nullable: true),
                    YellowCards = table.Column<string>(nullable: true),
                    Goals = table.Column<string>(nullable: true),
                    Position = table.Column<string>(nullable: true),
                    Points = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlayerHistories_Leagues_LeaguesId",
                        column: x => x.LeaguesId,
                        principalTable: "Leagues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PlayerHistories_Seasons_SeasonsId",
                        column: x => x.SeasonsId,
                        principalTable: "Seasons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PlayerHistories_Teams_TeamsId",
                        column: x => x.TeamsId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ManagerHistories_LeaguesId",
                table: "ManagerHistories",
                column: "LeaguesId");

            migrationBuilder.CreateIndex(
                name: "IX_ManagerHistories_SeasonsId",
                table: "ManagerHistories",
                column: "SeasonsId");

            migrationBuilder.CreateIndex(
                name: "IX_ManagerHistories_TeamsId",
                table: "ManagerHistories",
                column: "TeamsId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerHistories_LeaguesId",
                table: "PlayerHistories",
                column: "LeaguesId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerHistories_SeasonsId",
                table: "PlayerHistories",
                column: "SeasonsId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerHistories_TeamsId",
                table: "PlayerHistories",
                column: "TeamsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ManagerHistories");

            migrationBuilder.DropTable(
                name: "PlayerHistories");

            migrationBuilder.DropColumn(
                name: "CurrentValue",
                table: "Players");
        }
    }
}
