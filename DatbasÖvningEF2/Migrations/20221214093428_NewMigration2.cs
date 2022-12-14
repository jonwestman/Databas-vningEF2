using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatbasÖvningEF2.Migrations
{
    public partial class NewMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AgeOfPersonel",
                table: "VacayTables",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AgeOfPersonel",
                table: "VacayTables");
        }
    }
}
