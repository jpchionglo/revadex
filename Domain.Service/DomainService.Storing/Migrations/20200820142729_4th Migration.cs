using Microsoft.EntityFrameworkCore.Migrations;

namespace DomainService.Storing.Migrations
{
    public partial class _4thMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Distance",
                table: "Planet");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Distance",
                table: "Planet",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
