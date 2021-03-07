using Microsoft.EntityFrameworkCore.Migrations;

namespace VismaE2interRPWDWEDN.Migrations
{
    public partial class AnsattOppdOppgaver : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Oppgave",
                table: "Ansatt",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Oppgave",
                table: "Ansatt");
        }
    }
}
