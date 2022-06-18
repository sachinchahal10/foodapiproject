using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodAPI.Migrations
{
    public partial class CloudCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Food",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    itemname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    itemprice = table.Column<int>(type: "int", nullable: false),
                    foodtype = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    rating = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Food", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Food");
        }
    }
}
