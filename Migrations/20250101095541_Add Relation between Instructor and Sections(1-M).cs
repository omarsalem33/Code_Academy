using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeAcademy.Migrations
{
    /// <inheritdoc />
    public partial class AddRelationbetweenInstructorandSections1M : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InsId",
                table: "Sections",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 9,
                column: "InsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 10,
                column: "InsId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 11,
                column: "InsId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Sections_InsId",
                table: "Sections",
                column: "InsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sections_Instructors_InsId",
                table: "Sections",
                column: "InsId",
                principalTable: "Instructors",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sections_Instructors_InsId",
                table: "Sections");

            migrationBuilder.DropIndex(
                name: "IX_Sections_InsId",
                table: "Sections");

            migrationBuilder.DropColumn(
                name: "InsId",
                table: "Sections");
        }
    }
}
