using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CodeAcademy.Migrations
{
    /// <inheritdoc />
    public partial class AddSectionScheduleConfiguration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "SectionSchedules",
                columns: new[] { "Id", "EndTime", "ScheduleId", "SectionId", "StartTime" },
                values: new object[,]
                {
                    { 1, new TimeSpan(0, 10, 0, 0, 0), 1, 1, new TimeSpan(0, 8, 0, 0, 0) },
                    { 2, new TimeSpan(0, 18, 0, 0, 0), 3, 2, new TimeSpan(0, 14, 0, 0, 0) },
                    { 3, new TimeSpan(0, 15, 0, 0, 0), 4, 3, new TimeSpan(0, 10, 0, 0, 0) },
                    { 4, new TimeSpan(0, 12, 0, 0, 0), 1, 4, new TimeSpan(0, 10, 0, 0, 0) },
                    { 5, new TimeSpan(0, 18, 0, 0, 0), 1, 5, new TimeSpan(0, 16, 0, 0, 0) },
                    { 6, new TimeSpan(0, 10, 0, 0, 0), 2, 6, new TimeSpan(0, 8, 0, 0, 0) },
                    { 7, new TimeSpan(0, 14, 0, 0, 0), 3, 7, new TimeSpan(0, 11, 0, 0, 0) },
                    { 8, new TimeSpan(0, 14, 0, 0, 0), 4, 8, new TimeSpan(0, 10, 0, 0, 0) },
                    { 9, new TimeSpan(0, 18, 0, 0, 0), 4, 9, new TimeSpan(0, 16, 0, 0, 0) },
                    { 10, new TimeSpan(0, 15, 0, 0, 0), 3, 10, new TimeSpan(0, 12, 0, 0, 0) },
                    { 11, new TimeSpan(0, 11, 0, 0, 0), 5, 11, new TimeSpan(0, 9, 0, 0, 0) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SectionSchedules",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SectionSchedules",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SectionSchedules",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SectionSchedules",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SectionSchedules",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SectionSchedules",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SectionSchedules",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "SectionSchedules",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "SectionSchedules",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "SectionSchedules",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "SectionSchedules",
                keyColumn: "Id",
                keyValue: 11);
        }
    }
}
