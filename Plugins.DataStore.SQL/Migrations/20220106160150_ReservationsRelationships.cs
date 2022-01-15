using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Plugins.DataStore.SQL.Migrations
{
    public partial class ReservationsRelationships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BranchName",
                table: "Reservations");

            migrationBuilder.RenameColumn(
                name: "EmployeeName",
                table: "Reservations",
                newName: "StartBranchId");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Reservations",
                newName: "EndBranchId");

            migrationBuilder.AlterColumn<string>(
                name: "FleetVehicleLicensePlate",
                table: "Reservations",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "ReservationGuid", "EndBranchId", "EndDateTime", "FleetVehicleLicensePlate", "Price", "StartBranchId", "StartDateTime" },
                values: new object[] { new Guid("f8537232-49be-4ea3-89b9-893971d2603a"), 1, new DateTime(2022, 1, 8, 17, 1, 50, 495, DateTimeKind.Local).AddTicks(7592), "GD19791", 69, 2, new DateTime(2022, 1, 6, 17, 1, 50, 495, DateTimeKind.Local).AddTicks(7302) });

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_EndBranchId",
                table: "Reservations",
                column: "EndBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_FleetVehicleLicensePlate",
                table: "Reservations",
                column: "FleetVehicleLicensePlate");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_StartBranchId",
                table: "Reservations",
                column: "StartBranchId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Branches_EndBranchId",
                table: "Reservations",
                column: "EndBranchId",
                principalTable: "Branches",
                principalColumn: "BranchId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Branches_StartBranchId",
                table: "Reservations",
                column: "StartBranchId",
                principalTable: "Branches",
                principalColumn: "BranchId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_FleetVehicles_FleetVehicleLicensePlate",
                table: "Reservations",
                column: "FleetVehicleLicensePlate",
                principalTable: "FleetVehicles",
                principalColumn: "FleetVehicleLicensePlate",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Branches_EndBranchId",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Branches_StartBranchId",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_FleetVehicles_FleetVehicleLicensePlate",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_EndBranchId",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_FleetVehicleLicensePlate",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_StartBranchId",
                table: "Reservations");

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationGuid",
                keyValue: new Guid("f8537232-49be-4ea3-89b9-893971d2603a"));

            migrationBuilder.RenameColumn(
                name: "StartBranchId",
                table: "Reservations",
                newName: "EmployeeName");

            migrationBuilder.RenameColumn(
                name: "EndBranchId",
                table: "Reservations",
                newName: "CustomerId");

            migrationBuilder.AlterColumn<string>(
                name: "FleetVehicleLicensePlate",
                table: "Reservations",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "BranchName",
                table: "Reservations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
