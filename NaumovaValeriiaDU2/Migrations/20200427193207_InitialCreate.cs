using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NaumovaValeriiaDU2.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Responses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(500)", nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    File = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Requests",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Product = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Text = table.Column<string>(type: "nvarchar(500)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    File = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    responseId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Requests_Responses_responseId",
                        column: x => x.responseId,
                        principalTable: "Responses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Requests_responseId",
                table: "Requests",
                column: "responseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Requests");

            migrationBuilder.DropTable(
                name: "Responses");
        }
    }
}
