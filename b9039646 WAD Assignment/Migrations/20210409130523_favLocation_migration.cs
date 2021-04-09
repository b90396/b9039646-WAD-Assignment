using Microsoft.EntityFrameworkCore.Migrations;

namespace b9039646_WAD_Assignment.Migrations
{
    public partial class favLocation_migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FavouriteLocations",
                columns: table => new
                {
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserIDDuplicate = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    locationCoordinates1 = table.Column<string>(type: "varchar(200)", nullable: true),
                    locationCoordinates2 = table.Column<string>(type: "varchar(200)", nullable: true),
                    locationCoordinates3 = table.Column<string>(type: "varchar(200)", nullable: true),
                    locationCoordinates4 = table.Column<string>(type: "varchar(200)", nullable: true),
                    locationCoordinates5 = table.Column<string>(type: "varchar(200)", nullable: true),
                    locationCoordinates6 = table.Column<string>(type: "varchar(200)", nullable: true),
                    locationCoordinates7 = table.Column<string>(type: "varchar(200)", nullable: true),
                    locationCoordinates8 = table.Column<string>(type: "varchar(200)", nullable: true),
                    locationCoordinates9 = table.Column<string>(type: "varchar(200)", nullable: true),
                    locationCoordinates10 = table.Column<string>(type: "varchar(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavouriteLocations", x => x.UserID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FavouriteLocations");
        }
    }
}
