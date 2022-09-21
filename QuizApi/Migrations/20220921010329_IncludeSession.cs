using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuizApi.Migrations
{
    public partial class IncludeSession : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Game_User_UserIdUser",
                table: "Game");

            migrationBuilder.DropIndex(
                name: "IX_Game_UserIdUser",
                table: "Game");

            migrationBuilder.DropColumn(
                name: "IdUser",
                table: "Game");

            migrationBuilder.DropColumn(
                name: "Score",
                table: "Game");

            migrationBuilder.DropColumn(
                name: "UserIdUser",
                table: "Game");

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "User",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "GameIdGame",
                table: "Question",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TitleOption",
                table: "Option",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Game",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Session",
                columns: table => new
                {
                    IdSession = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Score = table.Column<int>(type: "int", nullable: false),
                    IdUser = table.Column<int>(type: "int", nullable: false),
                    IdGame = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Session", x => x.IdSession);
                    table.ForeignKey(
                        name: "FK_Session_Game_IdGame",
                        column: x => x.IdGame,
                        principalTable: "Game",
                        principalColumn: "IdGame",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Session_User_IdUser",
                        column: x => x.IdUser,
                        principalTable: "User",
                        principalColumn: "IdUser",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Question_GameIdGame",
                table: "Question",
                column: "GameIdGame");

            migrationBuilder.CreateIndex(
                name: "IX_Session_IdGame",
                table: "Session",
                column: "IdGame");

            migrationBuilder.CreateIndex(
                name: "IX_Session_IdUser",
                table: "Session",
                column: "IdUser");

            migrationBuilder.AddForeignKey(
                name: "FK_Question_Game_GameIdGame",
                table: "Question",
                column: "GameIdGame",
                principalTable: "Game",
                principalColumn: "IdGame");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Question_Game_GameIdGame",
                table: "Question");

            migrationBuilder.DropTable(
                name: "Session");

            migrationBuilder.DropIndex(
                name: "IX_Question_GameIdGame",
                table: "Question");

            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "User");

            migrationBuilder.DropColumn(
                name: "GameIdGame",
                table: "Question");

            migrationBuilder.DropColumn(
                name: "TitleOption",
                table: "Option");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Game");

            migrationBuilder.AddColumn<int>(
                name: "IdUser",
                table: "Game",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Score",
                table: "Game",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserIdUser",
                table: "Game",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Game_UserIdUser",
                table: "Game",
                column: "UserIdUser");

            migrationBuilder.AddForeignKey(
                name: "FK_Game_User_UserIdUser",
                table: "Game",
                column: "UserIdUser",
                principalTable: "User",
                principalColumn: "IdUser",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
