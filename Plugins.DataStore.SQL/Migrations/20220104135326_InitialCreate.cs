using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Plugins.DataStore.SQL.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    BranchId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches", x => x.BranchId);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    ReservationGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StartDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    BranchName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeName = table.Column<int>(type: "int", nullable: false),
                    FleetVehicleLicensePlate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.ReservationGuid);
                });

            migrationBuilder.CreateTable(
                name: "Transfers",
                columns: table => new
                {
                    TransferId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FromBranch = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ToBranch = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    FleetVehicleLicensePlate = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transfers", x => x.TransferId);
                });

            migrationBuilder.CreateTable(
                name: "VehicleBodyTypes",
                columns: table => new
                {
                    VehicleBodyTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleBodyTypes", x => x.VehicleBodyTypeId);
                });

            migrationBuilder.CreateTable(
                name: "VehicleModels",
                columns: table => new
                {
                    VehicleModelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Make = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModelYear = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BodyTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Segment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EngineType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Horsepower = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AutomaticGearbox = table.Column<bool>(type: "bit", nullable: false),
                    Doors = table.Column<int>(type: "int", nullable: false),
                    Seats = table.Column<int>(type: "int", nullable: false),
                    BaseDailyPrice = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleModels", x => x.VehicleModelId);
                });

            migrationBuilder.CreateTable(
                name: "FleetVehicles",
                columns: table => new
                {
                    FleetVehicleLicensePlate = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Odometer = table.Column<int>(type: "int", nullable: false),
                    Vin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaintenanceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MaintenanceOdometer = table.Column<int>(type: "int", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModelVehicleId = table.Column<int>(type: "int", nullable: false),
                    CurrentBranchId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FleetVehicles", x => x.FleetVehicleLicensePlate);
                    table.ForeignKey(
                        name: "FK_FleetVehicles_VehicleModels_ModelVehicleId",
                        column: x => x.ModelVehicleId,
                        principalTable: "VehicleModels",
                        principalColumn: "VehicleModelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "VehicleModels",
                columns: new[] { "VehicleModelId", "AutomaticGearbox", "BaseDailyPrice", "BodyTypeName", "Doors", "EngineType", "Horsepower", "Make", "Model", "ModelYear", "Seats", "Segment" },
                values: new object[] { 1, false, 95, "hatchback", 3, "petrol", "72", "Toyota", "Aygo", "2018", 4, "A" });

            migrationBuilder.InsertData(
                table: "VehicleModels",
                columns: new[] { "VehicleModelId", "AutomaticGearbox", "BaseDailyPrice", "BodyTypeName", "Doors", "EngineType", "Horsepower", "Make", "Model", "ModelYear", "Seats", "Segment" },
                values: new object[] { 2, true, 112, "hatchback", 5, "hybrid", "116", "Toyota", "Yaris", "2020", 5, "B" });

            migrationBuilder.InsertData(
                table: "VehicleModels",
                columns: new[] { "VehicleModelId", "AutomaticGearbox", "BaseDailyPrice", "BodyTypeName", "Doors", "EngineType", "Horsepower", "Make", "Model", "ModelYear", "Seats", "Segment" },
                values: new object[] { 3, true, 149, "sedan", 5, "hybrid", "184", "Toyota", "Corolla", "2018", 5, "C" });

            migrationBuilder.InsertData(
                table: "FleetVehicles",
                columns: new[] { "FleetVehicleLicensePlate", "CurrentBranchId", "DateAdded", "MaintenanceDate", "MaintenanceOdometer", "ModelVehicleId", "Odometer", "Vin" },
                values: new object[,]
                {
                    { "GD19791", 1, new DateTime(2022, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), 15000, 1, 345, "7A8NPS1E0XBJD3395" },
                    { "WW81713", 2, new DateTime(2022, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), 15000, 1, 345, "99A5M70K4EB5H2412" },
                    { "KR14805", 3, new DateTime(2022, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), 15000, 1, 345, "PR8T6WML9KN3V3570" },
                    { "KR19676", 4, new DateTime(2022, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), 15000, 1, 345, "1NENUTEL5FABF3880" },
                    { "GD23372", 1, new DateTime(2021, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 2, 4, 0, 0, 0, 0, DateTimeKind.Local), 30000, 2, 29200, "8AWT9NYH431RU0111" },
                    { "WW21759", 2, new DateTime(2021, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 2, 4, 0, 0, 0, 0, DateTimeKind.Local), 30000, 2, 29200, "YK1AA77X0TCNZ4856" },
                    { "KR14819", 3, new DateTime(2021, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 2, 4, 0, 0, 0, 0, DateTimeKind.Local), 30000, 2, 29200, "U5YX3MFX0CA4Y2611" },
                    { "KR27495", 4, new DateTime(2021, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 2, 4, 0, 0, 0, 0, DateTimeKind.Local), 30000, 2, 29200, "2HMM5P9Z8F9JW7622" },
                    { "GD38400", 1, new DateTime(2021, 10, 4, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 1, 18, 0, 0, 0, 0, DateTimeKind.Local), 15000, 3, 5000, "VF68LSKN8ZTBW4537" },
                    { "WW51732", 2, new DateTime(2021, 10, 4, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 1, 18, 0, 0, 0, 0, DateTimeKind.Local), 15000, 3, 5000, "ZGARLKYE2NJM55700" },
                    { "KR17430", 3, new DateTime(2021, 10, 4, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 1, 18, 0, 0, 0, 0, DateTimeKind.Local), 15000, 3, 5000, "SFDBSG9D24BNT5233" },
                    { "KR37442", 4, new DateTime(2021, 10, 4, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 1, 25, 0, 0, 0, 0, DateTimeKind.Local), 15000, 3, 5000, "5N13BMGT1NLC85021" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_FleetVehicles_ModelVehicleId",
                table: "FleetVehicles",
                column: "ModelVehicleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Branches");

            migrationBuilder.DropTable(
                name: "FleetVehicles");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Transfers");

            migrationBuilder.DropTable(
                name: "VehicleBodyTypes");

            migrationBuilder.DropTable(
                name: "VehicleModels");
        }
    }
}
