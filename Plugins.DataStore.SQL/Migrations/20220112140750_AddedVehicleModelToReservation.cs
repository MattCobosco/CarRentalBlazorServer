using Microsoft.EntityFrameworkCore.Migrations;

namespace Plugins.DataStore.SQL.Migrations
{
    public partial class AddedVehicleModelToReservation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VehicleModelId",
                table: "Reservations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_VehicleModelId",
                table: "Reservations",
                column: "VehicleModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_VehicleModels_VehicleModelId",
                table: "Reservations",
                column: "VehicleModelId",
                principalTable: "VehicleModels",
                principalColumn: "VehicleModelId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_VehicleModels_VehicleModelId",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_VehicleModelId",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "VehicleModelId",
                table: "Reservations");
        }
    }
}
