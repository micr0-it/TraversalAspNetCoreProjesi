using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class migChangeColumnToDestination : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ThirdDescription",
                table: "Destinations",
                newName: "ThirdDetail");

            migrationBuilder.RenameColumn(
                name: "SecondDescription",
                table: "Destinations",
                newName: "SecondDetail");

            migrationBuilder.RenameColumn(
                name: "FirstDescription",
                table: "Destinations",
                newName: "FirstDetail");

            migrationBuilder.RenameColumn(
                name: "DescriptionImg",
                table: "Destinations",
                newName: "DetailImg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ThirdDetail",
                table: "Destinations",
                newName: "ThirdDescription");

            migrationBuilder.RenameColumn(
                name: "SecondDetail",
                table: "Destinations",
                newName: "SecondDescription");

            migrationBuilder.RenameColumn(
                name: "FirstDetail",
                table: "Destinations",
                newName: "FirstDescription");

            migrationBuilder.RenameColumn(
                name: "DetailImg",
                table: "Destinations",
                newName: "DescriptionImg");
        }
    }
}
