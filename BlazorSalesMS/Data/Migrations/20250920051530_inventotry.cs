using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorSalesMS.Migrations
{
    /// <inheritdoc />
    public partial class inventotry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Inventories",
                newName: "SalesPrice");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Inventories",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdatePriceDate",
                table: "Inventories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdateQtyDate",
                table: "Inventories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<decimal>(
                name: "PdnPrice",
                table: "Inventories",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "QuantityOH",
                table: "Inventories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Unit",
                table: "Inventories",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "Inventories");

            migrationBuilder.DropColumn(
                name: "LastUpdatePriceDate",
                table: "Inventories");

            migrationBuilder.DropColumn(
                name: "LastUpdateQtyDate",
                table: "Inventories");

            migrationBuilder.DropColumn(
                name: "PdnPrice",
                table: "Inventories");

            migrationBuilder.DropColumn(
                name: "QuantityOH",
                table: "Inventories");

            migrationBuilder.DropColumn(
                name: "Unit",
                table: "Inventories");

            migrationBuilder.RenameColumn(
                name: "SalesPrice",
                table: "Inventories",
                newName: "Price");
        }
    }
}
