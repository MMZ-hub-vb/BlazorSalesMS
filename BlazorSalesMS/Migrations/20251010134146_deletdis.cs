using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorSalesMS.Migrations
{
    /// <inheritdoc />
    public partial class deletdis : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExpirationDate",
                table: "DisInventories");

            migrationBuilder.DropColumn(
                name: "LastUpdateQtyDate",
                table: "DisInventories");

            migrationBuilder.RenameColumn(
                name: "RecepitDate",
                table: "DisInventories",
                newName: "OrderDate");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OrderDate",
                table: "DisInventories",
                newName: "RecepitDate");

            migrationBuilder.AddColumn<DateTime>(
                name: "ExpirationDate",
                table: "DisInventories",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdateQtyDate",
                table: "DisInventories",
                type: "datetime2",
                nullable: true);
        }
    }
}
