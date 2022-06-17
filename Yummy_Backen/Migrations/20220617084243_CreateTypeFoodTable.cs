using Microsoft.EntityFrameworkCore.Migrations;

namespace Yummy_Backen.Migrations
{
    public partial class CreateTypeFoodTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MenuLink",
                table: "TypesofFoods",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MenuLink",
                table: "TypesofFoods");
        }
    }
}
