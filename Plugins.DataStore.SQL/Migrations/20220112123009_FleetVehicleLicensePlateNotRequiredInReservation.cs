using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Plugins.DataStore.SQL.Migrations
{
    public partial class FleetVehicleLicensePlateNotRequiredInReservation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_FleetVehicles_FleetVehicleLicensePlate",
                table: "Reservations");

            migrationBuilder.AlterColumn<string>(
                name: "FleetVehicleLicensePlate",
                table: "Reservations",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "ReservationGuid",
                table: "Reservations",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_FleetVehicles_FleetVehicleLicensePlate",
                table: "Reservations",
                column: "FleetVehicleLicensePlate",
                principalTable: "FleetVehicles",
                principalColumn: "FleetVehicleLicensePlate",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_FleetVehicles_FleetVehicleLicensePlate",
                table: "Reservations");

            migrationBuilder.AlterColumn<string>(
                name: "FleetVehicleLicensePlate",
                table: "Reservations",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ReservationGuid",
                table: "Reservations",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "GD19791",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2022, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "GD23372",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2021, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 2, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "GD38400",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "KR14805",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2022, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "KR14819",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2021, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 2, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "KR17430",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "KR19676",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2022, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "KR27495",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2021, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 2, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "KR37442",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 1, 31, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "WW21759",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2021, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 2, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "WW51732",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "WW81713",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2022, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_FleetVehicles_FleetVehicleLicensePlate",
                table: "Reservations",
                column: "FleetVehicleLicensePlate",
                principalTable: "FleetVehicles",
                principalColumn: "FleetVehicleLicensePlate",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
