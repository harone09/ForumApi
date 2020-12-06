using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HASOapi2.Migrations
{
    public partial class HASOapi2ModelsHASODBContext2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classe_User_userId",
                table: "Classe");

            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Publication_publicationId",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_Comment_User_userId",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_Publication_Classe_classeId",
                table: "Publication");

            migrationBuilder.DropForeignKey(
                name: "FK_Publication_User_userId",
                table: "Publication");

            migrationBuilder.DropIndex(
                name: "IX_Publication_classeId",
                table: "Publication");

            migrationBuilder.DropIndex(
                name: "IX_Publication_userId",
                table: "Publication");

            migrationBuilder.DropIndex(
                name: "IX_Comment_publicationId",
                table: "Comment");

            migrationBuilder.DropIndex(
                name: "IX_Comment_userId",
                table: "Comment");

            migrationBuilder.DropIndex(
                name: "IX_Classe_userId",
                table: "Classe");

            migrationBuilder.DropColumn(
                name: "classeId",
                table: "Publication");

            migrationBuilder.DropColumn(
                name: "userId",
                table: "Publication");

            migrationBuilder.DropColumn(
                name: "publicationId",
                table: "Comment");

            migrationBuilder.DropColumn(
                name: "userId",
                table: "Comment");

            migrationBuilder.DropColumn(
                name: "id_prof",
                table: "Classe");

            migrationBuilder.DropColumn(
                name: "userId",
                table: "Classe");

            migrationBuilder.AddColumn<long>(
                name: "IdProf",
                table: "Classe",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.InsertData(
                table: "Classe",
                columns: new[] { "Id", "Description", "IdProf", "Members", "Name" },
                values: new object[,]
                {
                    { 1L, "this is specially made to be able to share with your math teacher", 1L, 0L, "MATHEMATICS" },
                    { 2L, "this is specially made to be able to share with your PHYSICS teacher", 1L, 0L, "PHYSICS" },
                    { 3L, "this is specially made to be able to share with your CHEMISTRY teacher", 1L, 0L, "CHEMISTRY" },
                    { 4L, "this is specially made to be able to share with your FRENSH teacher", 2L, 0L, "FRENSH" },
                    { 5L, "this is specially made to be able to share with your ENGLISH teacher", 2L, 0L, "ENGLISH" }
                });

            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "Id", "Contenus", "Date", "IdPublication", "IdUser" },
                values: new object[] { 1L, "first comment", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 1L });

            migrationBuilder.InsertData(
                table: "Publication",
                columns: new[] { "Id", "Contenus", "Date", "IdClasse", "IdUser" },
                values: new object[,]
                {
                    { 8L, "this is the eightth publication.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5L, 4L },
                    { 7L, "this is the seventh publication.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5L, 1L },
                    { 6L, "this is the sixth publication.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4L, 3L },
                    { 5L, "this is the fifth publication.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3L, 3L },
                    { 4L, "this is the fourth publication.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, 3L },
                    { 3L, "this is the third publication.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 2L },
                    { 2L, "this is the second publication.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 1L },
                    { 1L, "this is the first publication.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 1L }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Email", "Login", "Name", "Password", "Phone", "Role" },
                values: new object[,]
                {
                    { 1L, "prof1@bla.com", "prof1", "Professor 1", "123", "0123456789", "Professor" },
                    { 2L, "prof2@bla.com", "prof2", "Professor 2", "123", "0123456789", "Professor" },
                    { 3L, "stud1@bla.com", "stud1", "Student 1", "123", "0123456789", "Student" },
                    { 4L, "stud2@bla.com", "stud2", "Student 2", "123", "0123456789", "Student" },
                    { 5L, "stud3@bla.com", "stud3", "Student 3", "123", "0123456789", "Student" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Classe",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Classe",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Classe",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Classe",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Classe",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Publication",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Publication",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Publication",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Publication",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Publication",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Publication",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Publication",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Publication",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DropColumn(
                name: "IdProf",
                table: "Classe");

            migrationBuilder.AddColumn<long>(
                name: "classeId",
                table: "Publication",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "userId",
                table: "Publication",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "publicationId",
                table: "Comment",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "userId",
                table: "Comment",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "id_prof",
                table: "Classe",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "userId",
                table: "Classe",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Publication_classeId",
                table: "Publication",
                column: "classeId");

            migrationBuilder.CreateIndex(
                name: "IX_Publication_userId",
                table: "Publication",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_publicationId",
                table: "Comment",
                column: "publicationId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_userId",
                table: "Comment",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_Classe_userId",
                table: "Classe",
                column: "userId");

            migrationBuilder.AddForeignKey(
                name: "FK_Classe_User_userId",
                table: "Classe",
                column: "userId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Publication_publicationId",
                table: "Comment",
                column: "publicationId",
                principalTable: "Publication",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_User_userId",
                table: "Comment",
                column: "userId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Publication_Classe_classeId",
                table: "Publication",
                column: "classeId",
                principalTable: "Classe",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Publication_User_userId",
                table: "Publication",
                column: "userId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
