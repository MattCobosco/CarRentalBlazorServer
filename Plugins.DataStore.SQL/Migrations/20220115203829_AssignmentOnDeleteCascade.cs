using Microsoft.EntityFrameworkCore.Migrations;

namespace Plugins.DataStore.SQL.Migrations
{
    public partial class AssignmentOnDeleteCascade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assignments_Reservations_ReservationGuid",
                table: "Assignments");

            migrationBuilder.AddForeignKey(
                name: "FK_Assignments_Reservations_ReservationGuid",
                table: "Assignments",
                column: "ReservationGuid",
                principalTable: "Reservations",
                principalColumn: "ReservationGuid",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assignments_Reservations_ReservationGuid",
                table: "Assignments");

            migrationBuilder.AddForeignKey(
                name: "FK_Assignments_Reservations_ReservationGuid",
                table: "Assignments",
                column: "ReservationGuid",
                principalTable: "Reservations",
                principalColumn: "ReservationGuid",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
