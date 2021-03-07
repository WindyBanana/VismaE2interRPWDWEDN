using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VismaE2interRPWDWEDN.Migrations
{
    public partial class Initilal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ansatt",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Stilling = table.Column<string>(nullable: true),
                    Oppgave = table.Column<string>(nullable: true),
                    PositionStartDate = table.Column<DateTime>(type: "Date", nullable: false),
                    PositionEndDate = table.Column<DateTime>(type: "Date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ansatt", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Oppgave",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Oppgavetittel = table.Column<string>(nullable: true),
                    OppgaveDato = table.Column<DateTime>(type: "Date", nullable: false),
                    Stilling = table.Column<string>(nullable: true),
                    Ansatt = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oppgave", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Stilling",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    PositionStartDate = table.Column<DateTime>(type: "Date", nullable: false),
                    PositionEndDate = table.Column<DateTime>(type: "Date", nullable: false),
                    Ansatt = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stilling", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ansatt");

            migrationBuilder.DropTable(
                name: "Oppgave");

            migrationBuilder.DropTable(
                name: "Stilling");
        }
    }
}
