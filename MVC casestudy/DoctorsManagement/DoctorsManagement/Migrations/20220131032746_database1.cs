using Microsoft.EntityFrameworkCore.Migrations;

namespace DoctorsManagement.Migrations
{
    public partial class database1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "name",
                table: "Doctors",
                newName: "Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Doctors",
                newName: "name");
        }
    }
}
