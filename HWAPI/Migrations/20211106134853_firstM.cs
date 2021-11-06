using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HWAPI.Migrations
{
    public partial class firstM : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Quotes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Text = table.Column<string>(type: "TEXT", nullable: true),
                    Author = table.Column<string>(type: "TEXT", nullable: true),
                    InsertDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quotes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "InsertDate", "Text" },
                values: new object[] { 1, "Наполеон Хилл", new DateTime(2020, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Что разум человека может постигнуть и во что он может поверить, того он способен достичь" });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "InsertDate", "Text" },
                values: new object[] { 2, "Альберт Эйнштейн", new DateTime(1890, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Стремитесь не к успеху, а к ценностям, которые он дает" });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "InsertDate", "Text" },
                values: new object[] { 3, "Достоевский", new DateTime(1890, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Надо любить жизнь больше, чем смысл жизни." });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "InsertDate", "Text" },
                values: new object[] { 4, "Амелия Эрхарт", new DateTime(1800, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Сложнее всего начать действовать, все остальное зависит только от упорства" });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "InsertDate", "Text" },
                values: new object[] { 5, "Борис Стругацкий", new DateTime(1810, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Начинать всегда стоит с того, что сеет сомнения." });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Quotes");
        }
    }
}
