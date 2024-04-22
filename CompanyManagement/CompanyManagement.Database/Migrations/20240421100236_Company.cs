using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryManagement.Database.Migrations
{
    /// <inheritdoc />
    public partial class Company : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Employees",
                newName: "FullName");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Departments",
                newName: "Name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Employees",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Departments",
                newName: "FullName");
        }
    }
}
