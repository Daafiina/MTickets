using Microsoft.EntityFrameworkCore.Migrations;

namespace MTickets.Data.Migrations
{
    public partial class update_cinemas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Cinema_CinemaId",
                table: "Movies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cinema",
                table: "Cinema");

            migrationBuilder.RenameTable(
                name: "Cinema",
                newName: "Cinemas");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cinemas",
                table: "Cinemas",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Cinemas_CinemaId",
                table: "Movies",
                column: "CinemaId",
                principalTable: "Cinemas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Cinemas_CinemaId",
                table: "Movies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cinemas",
                table: "Cinemas");

            migrationBuilder.RenameTable(
                name: "Cinemas",
                newName: "Cinema");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cinema",
                table: "Cinema",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Cinema_CinemaId",
                table: "Movies",
                column: "CinemaId",
                principalTable: "Cinema",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
