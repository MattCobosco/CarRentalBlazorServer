using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Plugins.DataStore.SQL.Migrations
{
    public partial class FixedVehicleModelName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FleetVehicles_VehicleModels_ModelVehicleId",
                table: "FleetVehicles");

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationGuid",
                keyValue: new Guid("f8537232-49be-4ea3-89b9-893971d2603a"));

            migrationBuilder.RenameColumn(
                name: "ModelVehicleId",
                table: "FleetVehicles",
                newName: "VehicleModelId");

            migrationBuilder.RenameIndex(
                name: "IX_FleetVehicles_ModelVehicleId",
                table: "FleetVehicles",
                newName: "IX_FleetVehicles_VehicleModelId");

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "GD19791",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2022, 1, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 1, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "GD23372",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2021, 1, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 2, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "GD38400",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2021, 10, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 1, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "KR14805",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2022, 1, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 1, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "KR14819",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2021, 1, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 2, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "KR17430",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2021, 10, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 1, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "KR19676",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2022, 1, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 1, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "KR27495",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2021, 1, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 2, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "KR37442",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2021, 10, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 1, 29, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "WW21759",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2021, 1, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 2, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "WW51732",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2021, 10, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 1, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "WW81713",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2022, 1, 8, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 1, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "ReservationGuid", "EndBranchId", "EndDateTime", "FleetVehicleLicensePlate", "Price", "StartBranchId", "StartDateTime" },
                values: new object[] { new Guid("69889894-bf2d-4caa-b969-289fd40673d0"), 1, new DateTime(2022, 1, 10, 18, 56, 27, 210, DateTimeKind.Local).AddTicks(6961), "GD19791", 69, 2, new DateTime(2022, 1, 8, 18, 56, 27, 210, DateTimeKind.Local).AddTicks(6657) });

            migrationBuilder.AddForeignKey(
                name: "FK_FleetVehicles_VehicleModels_VehicleModelId",
                table: "FleetVehicles",
                column: "VehicleModelId",
                principalTable: "VehicleModels",
                principalColumn: "VehicleModelId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FleetVehicles_VehicleModels_VehicleModelId",
                table: "FleetVehicles");

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationGuid",
                keyValue: new Guid("69889894-bf2d-4caa-b969-289fd40673d0"));

            migrationBuilder.RenameColumn(
                name: "VehicleModelId",
                table: "FleetVehicles",
                newName: "ModelVehicleId");

            migrationBuilder.RenameIndex(
                name: "IX_FleetVehicles_VehicleModelId",
                table: "FleetVehicles",
                newName: "IX_FleetVehicles_ModelVehicleId");

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "GD19791",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2022, 1, 6, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 1, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "GD23372",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2021, 1, 6, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "GD38400",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2021, 10, 6, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 1, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "KR14805",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2022, 1, 6, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 1, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "KR14819",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2021, 1, 6, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "KR17430",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2021, 10, 6, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 1, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "KR19676",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2022, 1, 6, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 1, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "KR27495",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2021, 1, 6, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "KR37442",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2021, 10, 6, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 1, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "WW21759",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2021, 1, 6, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 2, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "WW51732",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2021, 10, 6, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 1, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "WW81713",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2022, 1, 6, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 1, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "ReservationGuid", "EndBranchId", "EndDateTime", "FleetVehicleLicensePlate", "Price", "StartBranchId", "StartDateTime" },
                values: new object[] { new Guid("f8537232-49be-4ea3-89b9-893971d2603a"), 1, new DateTime(2022, 1, 8, 17, 1, 50, 495, DateTimeKind.Local).AddTicks(7592), "GD19791", 69, 2, new DateTime(2022, 1, 6, 17, 1, 50, 495, DateTimeKind.Local).AddTicks(7302) });

            migrationBuilder.AddForeignKey(
                name: "FK_FleetVehicles_VehicleModels_ModelVehicleId",
                table: "FleetVehicles",
                column: "ModelVehicleId",
                principalTable: "VehicleModels",
                principalColumn: "VehicleModelId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
