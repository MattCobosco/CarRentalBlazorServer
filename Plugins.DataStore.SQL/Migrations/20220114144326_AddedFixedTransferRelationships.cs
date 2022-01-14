using Microsoft.EntityFrameworkCore.Migrations;

namespace Plugins.DataStore.SQL.Migrations
{
    public partial class AddedFixedTransferRelationships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Branches_BranchId1",
                table: "Employee");

            migrationBuilder.DropIndex(
                name: "IX_Employee_BranchId1",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "FromBranch",
                table: "Transfers");

            migrationBuilder.DropColumn(
                name: "ToBranch",
                table: "Transfers");

            migrationBuilder.DropColumn(
                name: "BranchId1",
                table: "Employee");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "Transfers",
                newName: "ToBranchId");

            migrationBuilder.AlterColumn<string>(
                name: "FleetVehicleLicensePlate",
                table: "Transfers",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "FromBranchId",
                table: "Transfers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "BranchId",
                table: "Employee",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Position",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Transfers_FleetVehicleLicensePlate",
                table: "Transfers",
                column: "FleetVehicleLicensePlate");

            migrationBuilder.CreateIndex(
                name: "IX_Transfers_FromBranchId",
                table: "Transfers",
                column: "FromBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Transfers_ToBranchId",
                table: "Transfers",
                column: "ToBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_BranchId",
                table: "Employee",
                column: "BranchId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Branches_BranchId",
                table: "Employee",
                column: "BranchId",
                principalTable: "Branches",
                principalColumn: "BranchId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transfers_Branches_FromBranchId",
                table: "Transfers",
                column: "FromBranchId",
                principalTable: "Branches",
                principalColumn: "BranchId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Transfers_Branches_ToBranchId",
                table: "Transfers",
                column: "ToBranchId",
                principalTable: "Branches",
                principalColumn: "BranchId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Transfers_FleetVehicles_FleetVehicleLicensePlate",
                table: "Transfers",
                column: "FleetVehicleLicensePlate",
                principalTable: "FleetVehicles",
                principalColumn: "FleetVehicleLicensePlate",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Branches_BranchId",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_Transfers_Branches_FromBranchId",
                table: "Transfers");

            migrationBuilder.DropForeignKey(
                name: "FK_Transfers_Branches_ToBranchId",
                table: "Transfers");

            migrationBuilder.DropForeignKey(
                name: "FK_Transfers_FleetVehicles_FleetVehicleLicensePlate",
                table: "Transfers");

            migrationBuilder.DropIndex(
                name: "IX_Transfers_FleetVehicleLicensePlate",
                table: "Transfers");

            migrationBuilder.DropIndex(
                name: "IX_Transfers_FromBranchId",
                table: "Transfers");

            migrationBuilder.DropIndex(
                name: "IX_Transfers_ToBranchId",
                table: "Transfers");

            migrationBuilder.DropIndex(
                name: "IX_Employee_BranchId",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "FromBranchId",
                table: "Transfers");

            migrationBuilder.DropColumn(
                name: "Position",
                table: "Employee");

            migrationBuilder.RenameColumn(
                name: "ToBranchId",
                table: "Transfers",
                newName: "EmployeeId");

            migrationBuilder.AlterColumn<string>(
                name: "FleetVehicleLicensePlate",
                table: "Transfers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "FromBranch",
                table: "Transfers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ToBranch",
                table: "Transfers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "BranchId",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "BranchId1",
                table: "Employee",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employee_BranchId1",
                table: "Employee",
                column: "BranchId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Branches_BranchId1",
                table: "Employee",
                column: "BranchId1",
                principalTable: "Branches",
                principalColumn: "BranchId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
