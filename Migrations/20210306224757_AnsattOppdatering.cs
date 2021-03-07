using Microsoft.EntityFrameworkCore.Migrations;

namespace VismaE2interRPWDWEDN.Migrations
{
    public partial class AnsattOppdatering : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Ansatt",
                table: "Stilling",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ansatt",
                table: "Oppgave",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Stilling",
                table: "Oppgave",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Stilling",
                table: "Ansatt",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ansatt",
                table: "Stilling");

            migrationBuilder.DropColumn(
                name: "Ansatt",
                table: "Oppgave");

            migrationBuilder.DropColumn(
                name: "Stilling",
                table: "Oppgave");

            migrationBuilder.DropColumn(
                name: "Stilling",
                table: "Ansatt");
        }
    }
}
