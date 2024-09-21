using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VeridianInsurance.Data.Migrations
{
    /// <inheritdoc />
    public partial class vc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_vehicleInsuranceValue_vehicleInformation_VehicleID",
                table: "vehicleInsuranceValue");

            migrationBuilder.RenameColumn(
                name: "Year",
                table: "vehicleInsuranceValue",
                newName: "year");

            migrationBuilder.RenameColumn(
                name: "VehicleID",
                table: "vehicleInsuranceValue",
                newName: "vehicleId");

            migrationBuilder.RenameColumn(
                name: "Value",
                table: "vehicleInsuranceValue",
                newName: "value");

            migrationBuilder.RenameColumn(
                name: "ValueID",
                table: "vehicleInsuranceValue",
                newName: "valuId");

            migrationBuilder.RenameIndex(
                name: "IX_vehicleInsuranceValue_VehicleID",
                table: "vehicleInsuranceValue",
                newName: "IX_vehicleInsuranceValue_vehicleId");

            migrationBuilder.AlterColumn<string>(
                name: "status",
                table: "policies",
                type: "char(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char");

            migrationBuilder.AlterColumn<string>(
                name: "area",
                table: "naturalDisasters",
                type: "char(64)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char");

            migrationBuilder.AlterColumn<string>(
                name: "isSmoke",
                table: "health",
                type: "char(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char");

            migrationBuilder.AlterColumn<string>(
                name: "isHadOperation",
                table: "health",
                type: "char(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char");

            migrationBuilder.AddForeignKey(
                name: "FK_vehicleInsuranceValue_vehicleInformation_vehicleId",
                table: "vehicleInsuranceValue",
                column: "vehicleId",
                principalTable: "vehicleInformation",
                principalColumn: "vehicleId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_vehicleInsuranceValue_vehicleInformation_vehicleId",
                table: "vehicleInsuranceValue");

            migrationBuilder.RenameColumn(
                name: "year",
                table: "vehicleInsuranceValue",
                newName: "Year");

            migrationBuilder.RenameColumn(
                name: "vehicleId",
                table: "vehicleInsuranceValue",
                newName: "VehicleID");

            migrationBuilder.RenameColumn(
                name: "value",
                table: "vehicleInsuranceValue",
                newName: "Value");

            migrationBuilder.RenameColumn(
                name: "valuId",
                table: "vehicleInsuranceValue",
                newName: "ValueID");

            migrationBuilder.RenameIndex(
                name: "IX_vehicleInsuranceValue_vehicleId",
                table: "vehicleInsuranceValue",
                newName: "IX_vehicleInsuranceValue_VehicleID");

            migrationBuilder.AlterColumn<string>(
                name: "status",
                table: "policies",
                type: "char",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(1)");

            migrationBuilder.AlterColumn<string>(
                name: "area",
                table: "naturalDisasters",
                type: "char",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(64)");

            migrationBuilder.AlterColumn<string>(
                name: "isSmoke",
                table: "health",
                type: "char",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(1)");

            migrationBuilder.AlterColumn<string>(
                name: "isHadOperation",
                table: "health",
                type: "char",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(1)");

            migrationBuilder.AddForeignKey(
                name: "FK_vehicleInsuranceValue_vehicleInformation_VehicleID",
                table: "vehicleInsuranceValue",
                column: "VehicleID",
                principalTable: "vehicleInformation",
                principalColumn: "vehicleId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
