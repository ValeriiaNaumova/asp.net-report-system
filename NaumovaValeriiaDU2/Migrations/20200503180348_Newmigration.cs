using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NaumovaValeriiaDU2.Migrations
{
    public partial class Newmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "NameOfCategory" },
                values: new object[] { 2, "Furniture" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "NameOfProduct", "CategoryId" },
                values: new object[] { "Chair", 2 });

            migrationBuilder.UpdateData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 5, 3, 20, 3, 40, 795, DateTimeKind.Local).AddTicks(3231));

            migrationBuilder.UpdateData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 5, 3, 20, 3, 40, 819, DateTimeKind.Local).AddTicks(8281));

            migrationBuilder.InsertData(
                table: "Requests",
                columns: new[] { "Id", "Category", "Date", "Email", "File", "Product", "Text", "responseId" },
                values: new object[] { 3, "Furniture", new DateTime(2020, 5, 3, 20, 3, 40, 819, DateTimeKind.Local).AddTicks(8652), "marie@gmail.com", null, "Chair", "Some text", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "NameOfProduct",
                keyValue: "Chair");

            migrationBuilder.DeleteData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 4, 29, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Requests",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 4, 29, 0, 0, 0, 0, DateTimeKind.Local));
        }
    }
}
