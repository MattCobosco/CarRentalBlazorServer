using Microsoft.EntityFrameworkCore.Migrations;

namespace Plugins.DataStore.SQL.Migrations
{
    public partial class FixedAssignmentReservationRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Assignments_EndAssignmentGuid",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Assignments_StartAssignmentGuid",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_EndAssignmentGuid",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_StartAssignmentGuid",
                table: "Reservations");

            migrationBuilder.AlterColumn<string>(
                name: "StartAssignmentGuid",
                table: "Reservations",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EndAssignmentGuid",
                table: "Reservations",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReservationGuid",
                table: "Assignments",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Assignments_ReservationGuid",
                table: "Assignments",
                column: "ReservationGuid");

            migrationBuilder.AddForeignKey(
                name: "FK_Assignments_Reservations_ReservationGuid",
                table: "Assignments",
                column: "ReservationGuid",
                principalTable: "Reservations",
                principalColumn: "ReservationGuid",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assignments_Reservations_ReservationGuid",
                table: "Assignments");

            migrationBuilder.DropIndex(
                name: "IX_Assignments_ReservationGuid",
                table: "Assignments");

            migrationBuilder.DropColumn(
                name: "ReservationGuid",
                table: "Assignments");

            migrationBuilder.AlterColumn<string>(
                name: "StartAssignmentGuid",
                table: "Reservations",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EndAssignmentGuid",
                table: "Reservations",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_EndAssignmentGuid",
                table: "Reservations",
                column: "EndAssignmentGuid",
                unique: true,
                filter: "[EndAssignmentGuid] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_StartAssignmentGuid",
                table: "Reservations",
                column: "StartAssignmentGuid",
                unique: true,
                filter: "[StartAssignmentGuid] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Assignments_EndAssignmentGuid",
                table: "Reservations",
                column: "EndAssignmentGuid",
                principalTable: "Assignments",
                principalColumn: "AssignmentGuid",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Assignments_StartAssignmentGuid",
                table: "Reservations",
                column: "StartAssignmentGuid",
                principalTable: "Assignments",
                principalColumn: "AssignmentGuid",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
