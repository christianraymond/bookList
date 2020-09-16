using Microsoft.EntityFrameworkCore.Migrations;

namespace BookListRazor.Migrations
{
    public partial class FixedAuthorSynthax : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Auther",
                table: "Book");

            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "Book",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Author",
                table: "Book");

            migrationBuilder.AddColumn<string>(
                name: "Auther",
                table: "Book",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
