using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Plugins.DataStore.SQL.Migrations
{
    public partial class AddedEmployeesAndTasks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AssignmentGuid",
                table: "Transfers",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EndAssignmentGuid",
                table: "Reservations",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StartAssignmentGuid",
                table: "Reservations",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AssignmentTypes",
                columns: table => new
                {
                    AssignmentTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssignmentTypes", x => x.AssignmentTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Guid = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_Employee_Branches_BranchId1",
                        column: x => x.BranchId1,
                        principalTable: "Branches",
                        principalColumn: "BranchId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Assignments",
                columns: table => new
                {
                    AssignmentGuid = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AssignmentTypeId = table.Column<int>(type: "int", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmployeeGuid = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assignments", x => x.AssignmentGuid);
                    table.ForeignKey(
                        name: "FK_Assignments_AssignmentTypes_AssignmentTypeId",
                        column: x => x.AssignmentTypeId,
                        principalTable: "AssignmentTypes",
                        principalColumn: "AssignmentTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Assignments_Employee_EmployeeGuid",
                        column: x => x.EmployeeGuid,
                        principalTable: "Employee",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AssignmentTypes",
                columns: new[] { "AssignmentTypeId", "Type" },
                values: new object[,]
                {
                    { 1, "ReservationStart" },
                    { 2, "ReservationEnd" },
                    { 3, "Maintenance" },
                    { 4, "Transfer" }
                });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "GD19791",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2022, 1, 14, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 1, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "GD23372",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2021, 1, 14, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 2, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "GD38400",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2021, 10, 14, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 1, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "KR14805",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2022, 1, 14, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 1, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "KR14819",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2021, 1, 14, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 2, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "KR17430",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2021, 10, 14, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 1, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "KR19676",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2022, 1, 14, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 1, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "KR27495",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2021, 1, 14, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 2, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "KR37442",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2021, 10, 14, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 2, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "WW21759",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2021, 1, 14, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 2, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "WW51732",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2021, 10, 14, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 1, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "WW81713",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2022, 1, 14, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 1, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.CreateIndex(
                name: "IX_Transfers_AssignmentGuid",
                table: "Transfers",
                column: "AssignmentGuid",
                unique: true,
                filter: "[AssignmentGuid] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_EndAssignmentGuid",
                table: "Reservations",
                column: "EndAssignmentGuid",
                unique: true,
                filter: "[EndAssignmentGuid] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_StartAssignmentGuid",
                table: "Reservations",
                column: "StartAssignmentGuid",
                unique: true,
                filter: "[StartAssignmentGuid] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Assignments_AssignmentTypeId",
                table: "Assignments",
                column: "AssignmentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Assignments_EmployeeGuid",
                table: "Assignments",
                column: "EmployeeGuid");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_BranchId1",
                table: "Employee",
                column: "BranchId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Assignments_EndAssignmentGuid",
                table: "Reservations",
                column: "EndAssignmentGuid",
                principalTable: "Assignments",
                principalColumn: "AssignmentGuid",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Assignments_StartAssignmentGuid",
                table: "Reservations",
                column: "StartAssignmentGuid",
                principalTable: "Assignments",
                principalColumn: "AssignmentGuid",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Transfers_Assignments_AssignmentGuid",
                table: "Transfers",
                column: "AssignmentGuid",
                principalTable: "Assignments",
                principalColumn: "AssignmentGuid",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Assignments_EndAssignmentGuid",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Assignments_StartAssignmentGuid",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Transfers_Assignments_AssignmentGuid",
                table: "Transfers");

            migrationBuilder.DropTable(
                name: "Assignments");

            migrationBuilder.DropTable(
                name: "AssignmentTypes");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropIndex(
                name: "IX_Transfers_AssignmentGuid",
                table: "Transfers");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_EndAssignmentGuid",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_StartAssignmentGuid",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "AssignmentGuid",
                table: "Transfers");

            migrationBuilder.DropColumn(
                name: "EndAssignmentGuid",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "StartAssignmentGuid",
                table: "Reservations");

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "GD19791",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2022, 1, 12, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 1, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "GD23372",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2021, 1, 12, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 2, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "GD38400",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2021, 10, 12, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 1, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "KR14805",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2022, 1, 12, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 1, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "KR14819",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2021, 1, 12, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 2, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "KR17430",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2021, 10, 12, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 1, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "KR19676",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2022, 1, 12, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 1, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "KR27495",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2021, 1, 12, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 2, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "KR37442",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2021, 10, 12, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "WW21759",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2021, 1, 12, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 2, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "WW51732",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2021, 10, 12, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 1, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "WW81713",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2022, 1, 12, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 1, 12, 0, 0, 0, 0, DateTimeKind.Local) });
        }
    }
}
