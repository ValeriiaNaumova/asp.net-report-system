using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NaumovaValeriiaDU2.Migrations
{
    public partial class SeedRequestTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Requests",
                columns: new[] { "Id", "Category", "Date", "Email", "File", "Product", "Text", "responseId" },
                values: new object[] { 1, "Electronic", new DateTime(2020, 4, 28, 0, 0, 0, 0, DateTimeKind.Local), "ssss@gmail.com", null, "Computer", "jjjjj", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
