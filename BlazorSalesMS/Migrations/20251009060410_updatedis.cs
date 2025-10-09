using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorSalesMS.Migrations
{
    /// <inheritdoc />
    public partial class updatedis : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PdnPrice",
                table: "DisInventories");

            migrationBuilder.AlterColumn<decimal>(
                name: "SalesPrice",
                table: "DisInventories",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<int>(
                name: "PId",
                table: "DisInventories",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<decimal>(
                name: "buingPrice",
                table: "DisInventories",
                type: "decimal(18,2)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "buingPrice",
                table: "DisInventories");

            migrationBuilder.AlterColumn<decimal>(
                name: "SalesPrice",
                table: "DisInventories",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PId",
                table: "DisInventories",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PdnPrice",
                table: "DisInventories",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
