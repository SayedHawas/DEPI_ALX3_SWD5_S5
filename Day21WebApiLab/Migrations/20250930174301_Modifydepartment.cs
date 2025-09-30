using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Day21WebApiLab.Migrations
{
    /// <inheritdoc />
    public partial class Modifydepartment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ManagerName",
                table: "TblDepartments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "TblDepartments",
                keyColumn: "DepartmentId",
                keyValue: 1,
                column: "ManagerName",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblDepartments",
                keyColumn: "DepartmentId",
                keyValue: 2,
                column: "ManagerName",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ManagerName",
                table: "TblDepartments");
        }
    }
}
