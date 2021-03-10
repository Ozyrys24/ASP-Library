using Microsoft.EntityFrameworkCore.Migrations;

namespace Biblioteka.Migrations.LibraryDB
{
    public partial class AddQuantityToBooksModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "BooksModel",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "BooksModel");
        }
    }
}
