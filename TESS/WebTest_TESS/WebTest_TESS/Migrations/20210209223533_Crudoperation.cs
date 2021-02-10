using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebTest_TESS.Migrations
{
    public partial class Crudoperation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    pk_Task = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name_Task = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    date_Task = table.Column<DateTime>(type: "datetime2", nullable: false),
                    complete_Task = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.pk_Task);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tasks");
        }
    }
}
