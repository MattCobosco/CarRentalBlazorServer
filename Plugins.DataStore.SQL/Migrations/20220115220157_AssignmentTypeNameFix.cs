using Microsoft.EntityFrameworkCore.Migrations;

namespace Plugins.DataStore.SQL.Migrations
{
    public partial class AssignmentTypeNameFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AssignmentTypes",
                keyColumn: "AssignmentTypeId",
                keyValue: 1,
                column: "Type",
                value: "Reservation Start");

            migrationBuilder.UpdateData(
                table: "AssignmentTypes",
                keyColumn: "AssignmentTypeId",
                keyValue: 2,
                column: "Type",
                value: "Reservation End");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AssignmentTypes",
                keyColumn: "AssignmentTypeId",
                keyValue: 1,
                column: "Type",
                value: "ReservationStart");

            migrationBuilder.UpdateData(
                table: "AssignmentTypes",
                keyColumn: "AssignmentTypeId",
                keyValue: 2,
                column: "Type",
                value: "ReservationEnd");
        }
    }
}
