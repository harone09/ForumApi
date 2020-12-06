using Microsoft.EntityFrameworkCore.Migrations;

namespace HASOapi2.Migrations
{
    public partial class HASOapi2ModelsHASODBContext4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Listeatt",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true),
                    ide = table.Column<long>(nullable: false),
                    idc = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Listeatt", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Listefinal",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true),
                    ide = table.Column<long>(nullable: false),
                    idc = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Listefinal", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Listeatt",
                columns: new[] { "Id", "idc", "ide", "name" },
                values: new object[] { 1L, 1L, 3L, "Student 1" });

            migrationBuilder.InsertData(
                table: "Listeatt",
                columns: new[] { "Id", "idc", "ide", "name" },
                values: new object[] { 2L, 1L, 4L, "Student 2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Listeatt");

            migrationBuilder.DropTable(
                name: "Listefinal");
        }
    }
}
