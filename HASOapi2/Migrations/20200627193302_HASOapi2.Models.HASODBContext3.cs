using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HASOapi2.Migrations
{
    public partial class HASOapi2ModelsHASODBContext3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Uploadedfile",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false),
                    path = table.Column<string>(nullable: true),
                    IdUser = table.Column<long>(nullable: false),
                    IdPublication = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uploadedfile", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Uploadedfile");
        }
    }
}
