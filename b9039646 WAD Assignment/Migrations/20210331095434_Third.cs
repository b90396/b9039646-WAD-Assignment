using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace b9039646_WAD_Assignment.Migrations
{
    public partial class Third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Locations",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "LocationID",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "LocationNameEN",
                table: "Locations");

            migrationBuilder.RenameColumn(
                name: "LocationNameFR",
                table: "Locations",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "LocationDescriptionFR",
                table: "Locations",
                newName: "DescriptionF");

            migrationBuilder.RenameColumn(
                name: "LocationDescriptionEN",
                table: "Locations",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "JustificationFR",
                table: "Locations",
                newName: "JustificationF");

            migrationBuilder.RenameColumn(
                name: "JustificationEN",
                table: "Locations",
                newName: "Justification");

            migrationBuilder.RenameColumn(
                name: "Hectares",
                table: "Locations",
                newName: "Area");

            migrationBuilder.RenameColumn(
                name: "DateListed",
                table: "Locations",
                newName: "NameF");

            migrationBuilder.RenameColumn(
                name: "DangerStatus",
                table: "Locations",
                newName: "Danger");

            migrationBuilder.RenameColumn(
                name: "CountryFR",
                table: "Locations",
                newName: "CountryF");

            migrationBuilder.RenameColumn(
                name: "CountryEN",
                table: "Locations",
                newName: "Country");

            migrationBuilder.RenameColumn(
                name: "ContinentFR",
                table: "Locations",
                newName: "ContinentF");

            migrationBuilder.RenameColumn(
                name: "ContinentEN",
                table: "Locations",
                newName: "Continent");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Locations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Locations",
                table: "Locations",
                column: "Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Locations",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Locations");

            migrationBuilder.RenameColumn(
                name: "NameF",
                table: "Locations",
                newName: "DateListed");

            migrationBuilder.RenameColumn(
                name: "JustificationF",
                table: "Locations",
                newName: "JustificationFR");

            migrationBuilder.RenameColumn(
                name: "Justification",
                table: "Locations",
                newName: "JustificationEN");

            migrationBuilder.RenameColumn(
                name: "DescriptionF",
                table: "Locations",
                newName: "LocationDescriptionFR");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Locations",
                newName: "LocationDescriptionEN");

            migrationBuilder.RenameColumn(
                name: "Danger",
                table: "Locations",
                newName: "DangerStatus");

            migrationBuilder.RenameColumn(
                name: "CountryF",
                table: "Locations",
                newName: "CountryFR");

            migrationBuilder.RenameColumn(
                name: "Country",
                table: "Locations",
                newName: "CountryEN");

            migrationBuilder.RenameColumn(
                name: "ContinentF",
                table: "Locations",
                newName: "ContinentFR");

            migrationBuilder.RenameColumn(
                name: "Continent",
                table: "Locations",
                newName: "ContinentEN");

            migrationBuilder.RenameColumn(
                name: "Area",
                table: "Locations",
                newName: "Hectares");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Locations",
                newName: "LocationNameFR");

            migrationBuilder.AddColumn<int>(
                name: "LocationID",
                table: "Locations",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "LocationNameEN",
                table: "Locations",
                type: "varchar(200)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Locations",
                table: "Locations",
                column: "LocationID");
        }
    }
}
