using Microsoft.EntityFrameworkCore.Migrations;

namespace JuanStore.Migrations
{
    public partial class CreateSliderTabel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sliders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(maxLength: 255, nullable: false),
                    Description = table.Column<string>(maxLength: 1200, nullable: false),
                    MainTitel = table.Column<string>(maxLength: 255, nullable: false),
                    SubTitel = table.Column<string>(maxLength: 255, nullable: false),
                    RedirectUrl = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sliders", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sliders");
        }
    }
}
