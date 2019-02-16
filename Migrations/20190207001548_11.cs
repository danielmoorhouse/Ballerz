using Microsoft.EntityFrameworkCore.Migrations;

namespace Ballerz.Migrations
{
    public partial class _11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PositionsId",
                table: "Players",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Players_PositionsId",
                table: "Players",
                column: "PositionsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Positions_PositionsId",
                table: "Players",
                column: "PositionsId",
                principalTable: "Positions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Players_Positions_PositionsId",
                table: "Players");

            migrationBuilder.DropIndex(
                name: "IX_Players_PositionsId",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "PositionsId",
                table: "Players");
        }
    }
}
