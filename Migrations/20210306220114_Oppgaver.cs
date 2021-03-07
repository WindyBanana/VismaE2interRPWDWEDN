using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VismaE2interRPWDWEDN.Migrations
{
    public partial class Oppgaver : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Oppgave",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Oppgavetittel = table.Column<string>(nullable: true),
                    OppgaveDato = table.Column<DateTime>(type: "Date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oppgave", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Oppgave");
        }
    }
}
