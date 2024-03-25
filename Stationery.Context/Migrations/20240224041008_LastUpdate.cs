using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stationery.Context.Migrations
{
    /// <inheritdoc />
    public partial class LastUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Categories",
                newName: "CategoryId");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Categories");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Categories",
                newName: "Id");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
