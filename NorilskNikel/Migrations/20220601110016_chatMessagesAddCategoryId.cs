using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NorilskNikel.Migrations
{
    public partial class chatMessagesAddCategoryId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdCategory",
                table: "chatMessages",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdCategory",
                table: "chatMessages");
        }
    }
}
