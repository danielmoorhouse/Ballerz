using Microsoft.EntityFrameworkCore.Migrations;

namespace Ballerz.Migrations
{
    public partial class teamUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AverageAttendance",
                table: "Teams",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClubValue",
                table: "Teams",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SocialFollowing",
                table: "Teams",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WorldwideFans",
                table: "Teams",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AverageAttendance",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "ClubValue",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "SocialFollowing",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "WorldwideFans",
                table: "Teams");
        }
    }
}
