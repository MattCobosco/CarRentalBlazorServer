using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Plugins.DataStore.SQL.Migrations
{
    public partial class VehicleModelVehicleBodyTypeRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BodyTypeName",
                table: "VehicleModels");

            migrationBuilder.AddColumn<int>(
                name: "BodyTypeId",
                table: "VehicleModels",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                table: "VehicleBodyTypes",
                columns: new[] { "VehicleBodyTypeId", "Name" },
                values: new object[,]
                {
                    { 13, "Van" },
                    { 11, "SUV" },
                    { 10, "Station Wagon" },
                    { 9, "Sedan" },
                    { 8, "Roadster" },
                    { 7, "Pickup" },
                    { 6, "Minivan" },
                    { 5, "Microvan" },
                    { 4, "Liftback" },
                    { 3, "Hatchback" },
                    { 2, "Cabriolet" },
                    { 12, "Targa" },
                    { 1, "Convertible" }
                });

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "VehicleModelId",
                keyValue: 1,
                column: "BodyTypeId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "VehicleModelId",
                keyValue: 2,
                column: "BodyTypeId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "VehicleModelId",
                keyValue: 3,
                column: "BodyTypeId",
                value: 9);

            migrationBuilder.CreateIndex(
                name: "IX_VehicleModels_BodyTypeId",
                table: "VehicleModels",
                column: "BodyTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleModels_VehicleBodyTypes_BodyTypeId",
                table: "VehicleModels",
                column: "BodyTypeId",
                principalTable: "VehicleBodyTypes",
                principalColumn: "VehicleBodyTypeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VehicleModels_VehicleBodyTypes_BodyTypeId",
                table: "VehicleModels");

            migrationBuilder.DropIndex(
                name: "IX_VehicleModels_BodyTypeId",
                table: "VehicleModels");

            migrationBuilder.DeleteData(
                table: "VehicleBodyTypes",
                keyColumn: "VehicleBodyTypeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "VehicleBodyTypes",
                keyColumn: "VehicleBodyTypeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "VehicleBodyTypes",
                keyColumn: "VehicleBodyTypeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "VehicleBodyTypes",
                keyColumn: "VehicleBodyTypeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "VehicleBodyTypes",
                keyColumn: "VehicleBodyTypeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "VehicleBodyTypes",
                keyColumn: "VehicleBodyTypeId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "VehicleBodyTypes",
                keyColumn: "VehicleBodyTypeId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "VehicleBodyTypes",
                keyColumn: "VehicleBodyTypeId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "VehicleBodyTypes",
                keyColumn: "VehicleBodyTypeId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "VehicleBodyTypes",
                keyColumn: "VehicleBodyTypeId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "VehicleBodyTypes",
                keyColumn: "VehicleBodyTypeId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "VehicleBodyTypes",
                keyColumn: "VehicleBodyTypeId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "VehicleBodyTypes",
                keyColumn: "VehicleBodyTypeId",
                keyValue: 13);

            migrationBuilder.DropColumn(
                name: "BodyTypeId",
                table: "VehicleModels");

            migrationBuilder.AddColumn<string>(
                name: "BodyTypeName",
                table: "VehicleModels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "GD19791",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2022, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 1, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "GD23372",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2021, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 2, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "GD38400",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2021, 10, 4, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 1, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "KR14805",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2022, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 1, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "KR14819",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2021, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 2, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "KR17430",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2021, 10, 4, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 1, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "KR19676",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2022, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 1, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "KR27495",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2021, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 2, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "KR37442",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2021, 10, 4, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 1, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "WW21759",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2021, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 2, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "WW51732",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2021, 10, 4, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 1, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "FleetVehicles",
                keyColumn: "FleetVehicleLicensePlate",
                keyValue: "WW81713",
                columns: new[] { "DateAdded", "MaintenanceDate" },
                values: new object[] { new DateTime(2022, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 1, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "VehicleModelId",
                keyValue: 1,
                column: "BodyTypeName",
                value: "hatchback");

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "VehicleModelId",
                keyValue: 2,
                column: "BodyTypeName",
                value: "hatchback");

            migrationBuilder.UpdateData(
                table: "VehicleModels",
                keyColumn: "VehicleModelId",
                keyValue: 3,
                column: "BodyTypeName",
                value: "sedan");
        }
    }
}
