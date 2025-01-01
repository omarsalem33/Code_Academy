using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CodeAcademy.Migrations
{
    /// <inheritdoc />
    public partial class AddEnrollmentConfiguration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Enrollments",
                columns: new[] { "SectionId", "StudentId" },
                values: new object[,]
                {
                    { 6, 1 },
                    { 6, 2 },
                    { 7, 3 },
                    { 7, 4 },
                    { 8, 5 },
                    { 8, 6 },
                    { 9, 7 },
                    { 9, 8 },
                    { 10, 9 },
                    { 10, 10 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumns: new[] { "SectionId", "StudentId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumns: new[] { "SectionId", "StudentId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumns: new[] { "SectionId", "StudentId" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumns: new[] { "SectionId", "StudentId" },
                keyValues: new object[] { 7, 4 });

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumns: new[] { "SectionId", "StudentId" },
                keyValues: new object[] { 8, 5 });

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumns: new[] { "SectionId", "StudentId" },
                keyValues: new object[] { 8, 6 });

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumns: new[] { "SectionId", "StudentId" },
                keyValues: new object[] { 9, 7 });

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumns: new[] { "SectionId", "StudentId" },
                keyValues: new object[] { 9, 8 });

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumns: new[] { "SectionId", "StudentId" },
                keyValues: new object[] { 10, 9 });

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumns: new[] { "SectionId", "StudentId" },
                keyValues: new object[] { 10, 10 });
        }
    }
}
