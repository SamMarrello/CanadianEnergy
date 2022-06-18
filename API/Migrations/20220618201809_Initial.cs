using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace API.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Provinces",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    PercentHydro = table.Column<double>(type: "double precision", nullable: false),
                    PercentCoal = table.Column<double>(type: "double precision", nullable: false),
                    PercentOil = table.Column<double>(type: "double precision", nullable: false),
                    PercentNaturalGas = table.Column<double>(type: "double precision", nullable: false),
                    PercentNuclear = table.Column<double>(type: "double precision", nullable: false),
                    PercentWind = table.Column<double>(type: "double precision", nullable: false),
                    PercentSolar = table.Column<double>(type: "double precision", nullable: false),
                    PercentGeothermalBiomass = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provinces", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Provinces");
        }
    }
}
