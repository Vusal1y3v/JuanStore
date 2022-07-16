using Microsoft.EntityFrameworkCore.Migrations;

namespace JuanStore.Migrations
{
    public partial class CreateTabelProductISTopSeller : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsTopSeller",
                table: "Products",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsTopSeller",
                table: "Products");
        }
    }
}
