using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatbasÖvningEF2.Migrations
{
    public partial class NewMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VacayTables",
                columns: table => new
                {
                    VacayId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Personel = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TypeOfVacay = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    NumberOfDaysOff = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VacayTables", x => x.VacayId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VacayTables");
        }
    }
}
