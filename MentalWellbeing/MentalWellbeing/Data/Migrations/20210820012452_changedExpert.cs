using Microsoft.EntityFrameworkCore.Migrations;

namespace MentalWellbeing.Data.Migrations
{
    public partial class changedExpert : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageURL",
                table: "Experts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageURL",
                table: "Experts");
        }
    }
}
