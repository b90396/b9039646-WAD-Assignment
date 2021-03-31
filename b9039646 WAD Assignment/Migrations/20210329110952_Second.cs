using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace b9039646_WAD_Assignment.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tracks");

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    LocationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocationNameEN = table.Column<string>(type: "varchar(200)", nullable: false),
                    LocationNameFR = table.Column<string>(type: "varchar(200)", nullable: false),
                    LocationDescriptionEN = table.Column<string>(type: "varchar(500)", nullable: true),
                    LocationDescriptionFR = table.Column<string>(type: "varchar(500)", nullable: true),
                    JustificationEN = table.Column<string>(type: "varchar(1000)", nullable: true),
                    JustificationFR = table.Column<string>(type: "varchar(1000)", nullable: true),
                    DateListed = table.Column<string>(type: "varchar(200)", nullable: true),
                    DangerStatus = table.Column<string>(type: "varchar(200)", nullable: true),
                    Longitude = table.Column<double>(type: "float(25)", nullable: false),
                    Latitude = table.Column<double>(type: "float(25)", nullable: false),
                    Hectares = table.Column<double>(type: "float(25)", nullable: false),
                    Category = table.Column<string>(type: "varchar(200)", nullable: true),
                    CountryEN = table.Column<string>(type: "varchar(200)", nullable: true),
                    CountryFR = table.Column<string>(type: "varchar(200)", nullable: true),
                    ContinentEN = table.Column<string>(type: "varchar(200)", nullable: true),
                    ContinentFR = table.Column<string>(type: "varchar(200)", nullable: true),
                    GeographicalCoordinates = table.Column<string>(type: "varchar(200)", nullable: true),
                    Rating = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.LocationID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.CreateTable(
                name: "Tracks",
                columns: table => new
                {
                    TrackID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrackImage = table.Column<string>(type: "varchar(100)", nullable: true),
                    TrackLength = table.Column<int>(type: "int", nullable: false),
                    TrackName = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tracks", x => x.TrackID);
                });
        }
    }
}
