using Microsoft.EntityFrameworkCore.Migrations;

namespace BookManagement.Migrations
{
    public partial class AddPropToBookTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsCompleted",
                table: "Books",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "TotalChapter",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsCompleted",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "TotalChapter",
                table: "Books");
        }
    }
}
