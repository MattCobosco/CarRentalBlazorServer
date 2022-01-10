using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Plugins.DataStore.SQL.Migrations
{
    public partial class AddedCustomerTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationGuid",
                keyValue: new Guid("69889894-bf2d-4caa-b969-289fd40673d0"));

            migrationBuilder.AddColumn<string>(
                name: "CustomerGuid",
                table: "Reservations",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerGuid = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonalDocumentNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DrivingLicenseNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pesel = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerGuid);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_CustomerGuid",
                table: "Reservations",
                column: "CustomerGuid");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Customers_CustomerGuid",
                table: "Reservations",
                column: "CustomerGuid",
                principalTable: "Customers",
                principalColumn: "CustomerGuid",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Customers_CustomerGuid",
                table: "Reservations");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_CustomerGuid",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "CustomerGuid",
                table: "Reservations");

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
        }
    }
}
