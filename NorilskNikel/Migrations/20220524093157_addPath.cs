using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NorilskNikel.Migrations
{
    public partial class addPath : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "path",
                table: "resourses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "resourses",
                keyColumn: "Id",
                keyValue: 1,
                column: "path",
                value: "palaldium");

            migrationBuilder.UpdateData(
                table: "resourses",
                keyColumn: "Id",
                keyValue: 12,
                column: "path",
                value: "gold");

            migrationBuilder.UpdateData(
                table: "resourses",
                keyColumn: "Id",
                keyValue: 13,
                column: "path",
                value: "silver");

            migrationBuilder.UpdateData(
                table: "resourses",
                keyColumn: "Id",
                keyValue: 14,
                column: "path",
                value: "copper");

            migrationBuilder.UpdateData(
                table: "resourses",
                keyColumn: "Id",
                keyValue: 16,
                column: "path",
                value: "typeIa");

            migrationBuilder.UpdateData(
                table: "resourses",
                keyColumn: "Id",
                keyValue: 17,
                column: "path",
                value: "typeIB");

            migrationBuilder.UpdateData(
                table: "resourses",
                keyColumn: "Id",
                keyValue: 18,
                column: "path",
                value: "typeIIa");

            migrationBuilder.UpdateData(
                table: "resourses",
                keyColumn: "Id",
                keyValue: 19,
                column: "path",
                value: "typeIIb");

            migrationBuilder.UpdateData(
                table: "resourses",
                keyColumn: "Id",
                keyValue: 25,
                column: "path",
                value: "cobalt");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "path",
                table: "resourses");
        }
    }
}
