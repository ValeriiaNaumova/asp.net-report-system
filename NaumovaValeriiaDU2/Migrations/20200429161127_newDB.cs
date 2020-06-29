using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NaumovaValeriiaDU2.Migrations
{
    public partial class newDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameOfCategory = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    NameOfProduct = table.Column<string>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.NameOfProduct);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "NameOfCategory" },
                values: new object[] { 1, "Electronics" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "NameOfProduct", "CategoryId" },
                values: new object[,]
                {
                    { "Computer", 1 },
                    { "Vacuum Cleaner", 1 }
                });

            migrationBuilder.UpdateData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: 1,
                column: "Category",
                value: "Electronics");

            migrationBuilder.InsertData(
                table: "Requests",
                columns: new[] { "Id", "Category", "Date", "Email", "File", "Product", "Text", "responseId" },
                values: new object[] { 2, "Electronics", new DateTime(2020, 4, 29, 0, 0, 0, 0, DateTimeKind.Local), "hhh@gmail.com", null, "Vacuum cleaner", "ooooo", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DeleteData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: 1,
                column: "Category",
                value: "Electronic");
        }
    }
}
