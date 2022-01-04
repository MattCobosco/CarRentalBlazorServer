using Microsoft.EntityFrameworkCore.Migrations;

namespace Plugins.DataStore.SQL.Migrations
{
    public partial class FleetVehicleBranchRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Address", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Szklary 138 80-835 Gdańsk", null, "Gdańsk" },
                    { 2, "Rozłogi 1 01-323 Warszawa", null, "Warszawa" },
                    { 3, "Olszanicka 174 30-241 Kraków", null, "Kraków - Airport" },
                    { 4, "Conrada 63 31-357 Kraków", null, "Kraków - City" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_FleetVehicles_CurrentBranchId",
                table: "FleetVehicles",
                column: "CurrentBranchId");

            migrationBuilder.AddForeignKey(
                name: "FK_FleetVehicles_Branches_CurrentBranchId",
                table: "FleetVehicles",
                column: "CurrentBranchId",
                principalTable: "Branches",
                principalColumn: "BranchId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FleetVehicles_Branches_CurrentBranchId",
                table: "FleetVehicles");

            migrationBuilder.DropIndex(
                name: "IX_FleetVehicles_CurrentBranchId",
                table: "FleetVehicles");

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 4);
        }
    }
}
