using Microsoft.EntityFrameworkCore.Migrations;

namespace Yummy_Backen.Migrations
{
    public partial class CreateAboutTableNew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image2",
                table: "Abouts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image2",
                table: "Abouts");
        }
    }
}
