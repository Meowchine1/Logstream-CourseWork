using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NorilskNikel.Migrations
{
    public partial class addcategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "Id", "Article", "Description", "Name" },
                values: new object[] { 20, "", "", "Diamond" });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "Id", "Article", "Description", "Name" },
                values: new object[] { 21, "", "", "Metal" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 21);
        }
    }
}
