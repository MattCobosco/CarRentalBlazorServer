using Microsoft.EntityFrameworkCore.Migrations;

namespace Plugins.DataStore.SQL.Migrations
{
    public partial class AddedDbSetForEmployees : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assignments_Employee_EmployeeGuid",
                table: "Assignments");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Branches_BranchId",
                table: "Employee");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employee",
                table: "Employee");

            migrationBuilder.RenameTable(
                name: "Employee",
                newName: "Employees");

            migrationBuilder.RenameColumn(
                name: "Guid",
                table: "Employees",
                newName: "EmployeeGuid");

            migrationBuilder.RenameIndex(
                name: "IX_Employee_BranchId",
                table: "Employees",
                newName: "IX_Employees_BranchId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "EmployeeGuid");

            migrationBuilder.AddForeignKey(
                name: "FK_Assignments_Employees_EmployeeGuid",
                table: "Assignments",
                column: "EmployeeGuid",
                principalTable: "Employees",
                principalColumn: "EmployeeGuid",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Branches_BranchId",
                table: "Employees",
                column: "BranchId",
                principalTable: "Branches",
                principalColumn: "BranchId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assignments_Employees_EmployeeGuid",
                table: "Assignments");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Branches_BranchId",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.RenameTable(
                name: "Employees",
                newName: "Employee");

            migrationBuilder.RenameColumn(
                name: "EmployeeGuid",
                table: "Employee",
                newName: "Guid");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_BranchId",
                table: "Employee",
                newName: "IX_Employee_BranchId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employee",
                table: "Employee",
                column: "Guid");

            migrationBuilder.AddForeignKey(
                name: "FK_Assignments_Employee_EmployeeGuid",
                table: "Assignments",
                column: "EmployeeGuid",
                principalTable: "Employee",
                principalColumn: "Guid",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Branches_BranchId",
                table: "Employee",
                column: "BranchId",
                principalTable: "Branches",
                principalColumn: "BranchId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
