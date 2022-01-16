using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Plugins.DataStore.SQL.Migrations
{
    public partial class AssignmentFleetVehicleVehicleModelRelationships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FleetVehicleLicensePlate",
                table: "Assignments",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VehicleModelId",
                table: "Assignments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "GD19791",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2022, 1, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 1, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "GD23372",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2021, 1, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 2, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "GD38400",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2021, 10, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 1, 30, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "KR14805",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2022, 1, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 1, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "KR14819",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2021, 1, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 2, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "KR17430",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2021, 10, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 1, 30, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "KR19676",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2022, 1, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 1, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "KR27495",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2021, 1, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 2, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "KR37442",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2021, 10, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "WW21759",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2021, 1, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 2, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "WW51732",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2021, 10, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 1, 30, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "WW81713",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2022, 1, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 1, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.CreateIndex(
                name: "IX_Assignments_FleetVehicleLicensePlate",
                table: "Assignments",
                column: "FleetVehicleLicensePlate");

            migrationBuilder.CreateIndex(
                name: "IX_Assignments_VehicleModelId",
                table: "Assignments",
                column: "VehicleModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Assignments_FleetVehicles_FleetVehicleLicensePlate",
                table: "Assignments",
                column: "FleetVehicleLicensePlate",
                principalTable: "FleetVehicles",
                principalColumn: "FleetVehicleLicensePlate");

            migrationBuilder.AddForeignKey(
                name: "FK_Assignments_VehicleModels_VehicleModelId",
                table: "Assignments",
                column: "VehicleModelId",
                principalTable: "VehicleModels",
                principalColumn: "VehicleModelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assignments_FleetVehicles_FleetVehicleLicensePlate",
                table: "Assignments");

            migrationBuilder.DropForeignKey(
                name: "FK_Assignments_VehicleModels_VehicleModelId",
                table: "Assignments");

            migrationBuilder.DropIndex(
                name: "IX_Assignments_FleetVehicleLicensePlate",
                table: "Assignments");

            migrationBuilder.DropIndex(
                name: "IX_Assignments_VehicleModelId",
                table: "Assignments");

            migrationBuilder.DropColumn(
                name: "FleetVehicleLicensePlate",
                table: "Assignments");

            migrationBuilder.DropColumn(
                name: "VehicleModelId",
                table: "Assignments");

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "GD19791",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2022, 1, 15, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "GD23372",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2021, 1, 15, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 2, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "GD38400",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2021, 10, 15, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 1, 29, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "KR14805",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2022, 1, 15, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "KR14819",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2021, 1, 15, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 2, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "KR17430",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2021, 10, 15, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 1, 29, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "KR19676",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2022, 1, 15, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "KR27495",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2021, 1, 15, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 2, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "KR37442",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2021, 10, 15, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 2, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "WW21759",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2021, 1, 15, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 2, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "WW51732",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2021, 10, 15, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 1, 29, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "WW81713",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2022, 1, 15, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Local) });
        }
    }
}
