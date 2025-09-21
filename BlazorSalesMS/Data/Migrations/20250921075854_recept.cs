using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorSalesMS.Migrations
{
    /// <inheritdoc />
    public partial class recept : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "recepits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Supplyer = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    ContactNo = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    IvoiceNo = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    PaymentMethod = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    UrlDocName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RecepitDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_recepits", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "recepits");
        }
    }
}
