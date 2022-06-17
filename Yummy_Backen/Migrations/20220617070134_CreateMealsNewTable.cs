using Microsoft.EntityFrameworkCore.Migrations;

namespace Yummy_Backen.Migrations
{
    public partial class CreateMealsNewTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Meals",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Meals");
        }
    }
}
