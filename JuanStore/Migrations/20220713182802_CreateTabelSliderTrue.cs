using Microsoft.EntityFrameworkCore.Migrations;

namespace JuanStore.Migrations
{
    public partial class CreateTabelSliderTrue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isMainSlider",
                table: "Sliders",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isProductSlider",
                table: "Sliders",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isMainSlider",
                table: "Sliders");

            migrationBuilder.DropColumn(
                name: "isProductSlider",
                table: "Sliders");
        }
    }
}
