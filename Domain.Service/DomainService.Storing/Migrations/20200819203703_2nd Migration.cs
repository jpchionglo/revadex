using Microsoft.EntityFrameworkCore.Migrations;

namespace DomainService.Storing.Migrations
{
    public partial class _2ndMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Magnitude",
                table: "Star");

            migrationBuilder.DropColumn(
                name: "Magnitude",
                table: "Planet");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Magnitude",
                table: "Star",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Magnitude",
                table: "Planet",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
