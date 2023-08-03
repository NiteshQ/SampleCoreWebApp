using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SampleCoreWebApp.Migrations
{
    /// <inheritdoc />
    public partial class CommonNameDepartmentOneToOne : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "CommonNames",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CommonNames_DepartmentId",
                table: "CommonNames",
                column: "DepartmentId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CommonNames_Departments_DepartmentId",
                table: "CommonNames",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CommonNames_Departments_DepartmentId",
                table: "CommonNames");

            migrationBuilder.DropIndex(
                name: "IX_CommonNames_DepartmentId",
                table: "CommonNames");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "CommonNames");
        }
    }
}
