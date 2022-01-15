using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Plugins.DataStore.SQL.Migrations
{
    public partial class AddedContactDetailsToEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ContactDetails",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContactDetails",
                table: "Employees");

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
        }
    }
}
