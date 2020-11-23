using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopServices.Author.Api.Migrations
{
    public partial class FixedInitialPostgresMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AcademicDegreeGuid",
                table: "Authors");

            migrationBuilder.AddColumn<string>(
                name: "AcademicDegreeGuid",
                table: "AcademicDegrees",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AcademicDegreeGuid",
                table: "AcademicDegrees");

            migrationBuilder.AddColumn<string>(
                name: "AcademicDegreeGuid",
                table: "Authors",
                type: "text",
                nullable: true);
        }
    }
}
