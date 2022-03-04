using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieApp_UsingMvc.Migrations
{
    public partial class Movie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "movieLists",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: false),
                    BoxOffice = table.Column<string>(nullable: false),
                    ActiveStatus = table.Column<bool>(nullable: false),
                    DateOfLaunch = table.Column<DateTime>(nullable: false),
                    SelectGenere = table.Column<string>(nullable: false),
                    MovieGenere = table.Column<int>(nullable: false),
                    hasTeaser = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movieLists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "signUps",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Roles = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    ConfirmPassword = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_signUps", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "movieLists");

            migrationBuilder.DropTable(
                name: "signUps");
        }
    }
}
