using Microsoft.EntityFrameworkCore.Migrations;

namespace Book_My_Show.Data.Migrations
{
    public partial class Initial_Create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MovieId",
                table: "UserBags");

            migrationBuilder.DropColumn(
                name: "TheatreId",
                table: "UserBags");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "UserBags",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MovieName",
                table: "UserBags",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TheatreName",
                table: "UserBags",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "UserBags");

            migrationBuilder.DropColumn(
                name: "MovieName",
                table: "UserBags");

            migrationBuilder.DropColumn(
                name: "TheatreName",
                table: "UserBags");

            migrationBuilder.AddColumn<int>(
                name: "MovieId",
                table: "UserBags",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TheatreId",
                table: "UserBags",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
