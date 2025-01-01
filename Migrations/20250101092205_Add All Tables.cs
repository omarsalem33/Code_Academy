using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CodeAcademy.Migrations
{
    /// <inheritdoc />
    public partial class AddAllTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    CourseName = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Instructors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    FName = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    LName = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Offices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    OfficeName = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    OfficeLocation = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Schedules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    SUN = table.Column<bool>(type: "bit", nullable: false),
                    MON = table.Column<bool>(type: "bit", nullable: false),
                    TUE = table.Column<bool>(type: "bit", nullable: false),
                    WED = table.Column<bool>(type: "bit", nullable: false),
                    THU = table.Column<bool>(type: "bit", nullable: false),
                    FRI = table.Column<bool>(type: "bit", nullable: false),
                    SAT = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedules", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "VARCHAR(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sections", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    FName = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    LName = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CourseName", "Price" },
                values: new object[,]
                {
                    { 1, "Mathmatics", 1000m },
                    { 2, "Physics", 2000m },
                    { 3, "Chemistry", 1500m },
                    { 4, "Biology", 1200m },
                    { 5, "CS-50", 3000m }
                });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "Id", "FName", "LName" },
                values: new object[,]
                {
                    { 1, "Ahmed", "Abdullah" },
                    { 2, "Yasmeen", "Yasmeen" },
                    { 3, "Khalid", "Hassan" },
                    { 4, "Nadia", "Ali" },
                    { 5, "Ahmed", "Abdullah" }
                });

            migrationBuilder.InsertData(
                table: "Offices",
                columns: new[] { "Id", "OfficeLocation", "OfficeName" },
                values: new object[,]
                {
                    { 1, "building A", "Off_05" },
                    { 2, "building B", "Off_12" },
                    { 3, "Adminstration", "Off_32" },
                    { 4, "IT Department", "Off_44" },
                    { 5, "IT Department", "Off_43" }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "FRI", "MON", "SAT", "SUN", "THU", "TUE", "Title", "WED" },
                values: new object[,]
                {
                    { 1, false, true, false, true, true, true, "Daily", true },
                    { 2, false, false, false, true, true, true, "DayAfterDay", false },
                    { 3, false, true, false, false, false, false, "Twice-a-Week", true },
                    { 4, true, false, true, false, false, false, "Weekend", false },
                    { 5, true, true, true, true, true, true, "Compact", true }
                });

            migrationBuilder.InsertData(
                table: "Sections",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "S_MA1" },
                    { 2, "S_MA2" },
                    { 3, "S_PH1" },
                    { 4, "S_PH2" },
                    { 5, "S_CH1" },
                    { 6, "S_CH2" },
                    { 7, "S_BI1" },
                    { 8, "S_BI2" },
                    { 9, "S_CS1" },
                    { 10, "S_CS2" },
                    { 11, "S_CS3" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "FName", "LName" },
                values: new object[,]
                {
                    { 1, "Fatima", "Ali" },
                    { 2, "Noor", "Saleh" },
                    { 3, "Omar", "Youssef" },
                    { 4, "Huda", "Ahmed" },
                    { 5, "Amira", "Tariq" },
                    { 6, "Zainab", "Ismail" },
                    { 7, "Yousef", "Farid" },
                    { 8, "Layla", "Mustafa" },
                    { 9, "Mohammed", "Adel" },
                    { 10, "Samira", "Nabil" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Instructors");

            migrationBuilder.DropTable(
                name: "Offices");

            migrationBuilder.DropTable(
                name: "Schedules");

            migrationBuilder.DropTable(
                name: "Sections");

            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
