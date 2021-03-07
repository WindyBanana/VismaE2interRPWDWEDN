using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VismaE2interRPWDWEDN.Migrations
{
    public partial class Stillinger : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Stilling",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    PositionStartDate = table.Column<DateTime>(type: "Date", nullable: false),
                    PositionEndDate = table.Column<DateTime>(type: "Date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stilling", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stilling");
        }
    }
}
