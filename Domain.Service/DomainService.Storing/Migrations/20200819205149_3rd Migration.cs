using Microsoft.EntityFrameworkCore.Migrations;

namespace DomainService.Storing.Migrations
{
    public partial class _3rdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Radius",
                table: "Star");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Radius",
                table: "Star",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
