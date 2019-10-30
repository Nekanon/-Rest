using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Serenity.Migrations
{
    public partial class initialMigrate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "public");

            migrationBuilder.CreateTable(
                name: "Any",
                schema: "public",
                columns: table => new
                {
                    Name = table.Column<Guid>(nullable: false),
                    Any_Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Any", x => x.Name);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Any",
                schema: "public");
        }
    }
}
