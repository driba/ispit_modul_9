using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_CodeFirst.Migrations
{
    public partial class SeedingDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "StudentName",
                table: "Students",
                type: "nchar(20)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nchar");

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentID", "DateOfBirth", "Height", "StudentName", "Weight" },
                values: new object[] { 1, new DateTime(1988, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 201.5m, "Ivan Ivic", 100.0 });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentID", "DateOfBirth", "Height", "StudentName", "Weight" },
                values: new object[] { 2, new DateTime(1950, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 181.5m, "Hrvoje Horvat", 83.0 });

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "GradeId", "GradeName", "Section", "StudentId" },
                values: new object[,]
                {
                    { 1, "Dovoljan", "Modul 1", 1 },
                    { 2, "Nedovoljan", "Modul 1", 2 },
                    { 3, "Odličan", "Modul 2", 1 },
                    { 4, "Odličan", "Modul 2", 2 },
                    { 5, "Odličan", "Modul 3", 1 },
                    { 6, "Odličan", "Modul 3", 2 },
                    { 7, "Odličan", "Modul 1", 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "GradeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "GradeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "GradeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "GradeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "GradeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "GradeId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "GradeId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 2);

            migrationBuilder.AlterColumn<string>(
                name: "StudentName",
                table: "Students",
                type: "nchar",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nchar(20)");
        }
    }
}
