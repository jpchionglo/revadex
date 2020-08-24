using Microsoft.EntityFrameworkCore.Migrations;

namespace DomainService.Storing.Migrations
{
    public partial class _1stMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Constellation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Constellation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Planet",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Magnitude = table.Column<double>(nullable: false),
                    Distance = table.Column<double>(nullable: false),
                    Radius = table.Column<double>(nullable: false),
                    Mass = table.Column<double>(nullable: false),
                    Volume = table.Column<double>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planet", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SolarSystem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SolarSystem", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Star",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Magnitude = table.Column<double>(nullable: false),
                    Distance = table.Column<double>(nullable: false),
                    Temperature = table.Column<double>(nullable: false),
                    Radius = table.Column<double>(nullable: false),
                    Mass = table.Column<double>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Star", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlanetSolarSystJunction",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlanetId = table.Column<int>(nullable: true),
                    SolarSystemId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanetSolarSystJunction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlanetSolarSystJunction_Planet_PlanetId",
                        column: x => x.PlanetId,
                        principalTable: "Planet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PlanetSolarSystJunction_SolarSystem_SolarSystemId",
                        column: x => x.SolarSystemId,
                        principalTable: "SolarSystem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StarConstJunction",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StarId = table.Column<int>(nullable: true),
                    ConstellationId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StarConstJunction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StarConstJunction_Constellation_ConstellationId",
                        column: x => x.ConstellationId,
                        principalTable: "Constellation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StarConstJunction_Star_StarId",
                        column: x => x.StarId,
                        principalTable: "Star",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PlanetSolarSystJunction_PlanetId",
                table: "PlanetSolarSystJunction",
                column: "PlanetId");

            migrationBuilder.CreateIndex(
                name: "IX_PlanetSolarSystJunction_SolarSystemId",
                table: "PlanetSolarSystJunction",
                column: "SolarSystemId");

            migrationBuilder.CreateIndex(
                name: "IX_StarConstJunction_ConstellationId",
                table: "StarConstJunction",
                column: "ConstellationId");

            migrationBuilder.CreateIndex(
                name: "IX_StarConstJunction_StarId",
                table: "StarConstJunction",
                column: "StarId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlanetSolarSystJunction");

            migrationBuilder.DropTable(
                name: "StarConstJunction");

            migrationBuilder.DropTable(
                name: "Planet");

            migrationBuilder.DropTable(
                name: "SolarSystem");

            migrationBuilder.DropTable(
                name: "Constellation");

            migrationBuilder.DropTable(
                name: "Star");
        }
    }
}
