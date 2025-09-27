using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorSalesMS.Migrations
{
    /// <inheritdoc />
    public partial class deii : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "recepits",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "recepits");
        }
    }
}
