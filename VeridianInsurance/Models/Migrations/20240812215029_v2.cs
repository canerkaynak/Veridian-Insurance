using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VeridianInsurance.Data.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Healths_Policies_PolicyNo",
                table: "Healths");

            migrationBuilder.DropForeignKey(
                name: "FK_NaturalDisasters_Policies_PolicyNo",
                table: "NaturalDisasters");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Policies_PolicyNo",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_Policies_Customers_CustomerID",
                table: "Policies");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleInsuranceValues_VehicleInformation_VehicleID",
                table: "VehicleInsuranceValues");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Policies_PolicyNo",
                table: "Vehicles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VehicleInformation",
                table: "VehicleInformation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Policies",
                table: "Policies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Payments",
                table: "Payments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NaturalDisasters",
                table: "NaturalDisasters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customers",
                table: "Customers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vehicles",
                table: "Vehicles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VehicleInsuranceValues",
                table: "VehicleInsuranceValues");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Healths",
                table: "Healths");

            migrationBuilder.RenameTable(
                name: "VehicleInformation",
                newName: "vehicleInformation");

            migrationBuilder.RenameTable(
                name: "Policies",
                newName: "policies");

            migrationBuilder.RenameTable(
                name: "Payments",
                newName: "payments");

            migrationBuilder.RenameTable(
                name: "NaturalDisasters",
                newName: "naturalDisasters");

            migrationBuilder.RenameTable(
                name: "Customers",
                newName: "customers");

            migrationBuilder.RenameTable(
                name: "Vehicles",
                newName: "vehicle");

            migrationBuilder.RenameTable(
                name: "VehicleInsuranceValues",
                newName: "vehicleInsuranceValue");

            migrationBuilder.RenameTable(
                name: "Healths",
                newName: "health");

            migrationBuilder.RenameIndex(
                name: "IX_Policies_CustomerID",
                table: "policies",
                newName: "IX_policies_CustomerID");

            migrationBuilder.RenameIndex(
                name: "IX_Payments_PolicyNo",
                table: "payments",
                newName: "IX_payments_PolicyNo");

            migrationBuilder.RenameIndex(
                name: "IX_NaturalDisasters_PolicyNo",
                table: "naturalDisasters",
                newName: "IX_naturalDisasters_PolicyNo");

            migrationBuilder.RenameIndex(
                name: "IX_Vehicles_PolicyNo",
                table: "vehicle",
                newName: "IX_vehicle_PolicyNo");

            migrationBuilder.RenameIndex(
                name: "IX_VehicleInsuranceValues_VehicleID",
                table: "vehicleInsuranceValue",
                newName: "IX_vehicleInsuranceValue_VehicleID");

            migrationBuilder.RenameIndex(
                name: "IX_Healths_PolicyNo",
                table: "health",
                newName: "IX_health_PolicyNo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_vehicleInformation",
                table: "vehicleInformation",
                column: "VehicleID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_policies",
                table: "policies",
                column: "PolicyNo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_payments",
                table: "payments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_naturalDisasters",
                table: "naturalDisasters",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_customers",
                table: "customers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_vehicle",
                table: "vehicle",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_vehicleInsuranceValue",
                table: "vehicleInsuranceValue",
                column: "ValueID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_health",
                table: "health",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_health_policies_PolicyNo",
                table: "health",
                column: "PolicyNo",
                principalTable: "policies",
                principalColumn: "PolicyNo",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_naturalDisasters_policies_PolicyNo",
                table: "naturalDisasters",
                column: "PolicyNo",
                principalTable: "policies",
                principalColumn: "PolicyNo",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_payments_policies_PolicyNo",
                table: "payments",
                column: "PolicyNo",
                principalTable: "policies",
                principalColumn: "PolicyNo",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_policies_customers_CustomerID",
                table: "policies",
                column: "CustomerID",
                principalTable: "customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_vehicle_policies_PolicyNo",
                table: "vehicle",
                column: "PolicyNo",
                principalTable: "policies",
                principalColumn: "PolicyNo",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_vehicleInsuranceValue_vehicleInformation_VehicleID",
                table: "vehicleInsuranceValue",
                column: "VehicleID",
                principalTable: "vehicleInformation",
                principalColumn: "VehicleID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_health_policies_PolicyNo",
                table: "health");

            migrationBuilder.DropForeignKey(
                name: "FK_naturalDisasters_policies_PolicyNo",
                table: "naturalDisasters");

            migrationBuilder.DropForeignKey(
                name: "FK_payments_policies_PolicyNo",
                table: "payments");

            migrationBuilder.DropForeignKey(
                name: "FK_policies_customers_CustomerID",
                table: "policies");

            migrationBuilder.DropForeignKey(
                name: "FK_vehicle_policies_PolicyNo",
                table: "vehicle");

            migrationBuilder.DropForeignKey(
                name: "FK_vehicleInsuranceValue_vehicleInformation_VehicleID",
                table: "vehicleInsuranceValue");

            migrationBuilder.DropPrimaryKey(
                name: "PK_vehicleInformation",
                table: "vehicleInformation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_policies",
                table: "policies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_payments",
                table: "payments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_naturalDisasters",
                table: "naturalDisasters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_customers",
                table: "customers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_vehicleInsuranceValue",
                table: "vehicleInsuranceValue");

            migrationBuilder.DropPrimaryKey(
                name: "PK_vehicle",
                table: "vehicle");

            migrationBuilder.DropPrimaryKey(
                name: "PK_health",
                table: "health");

            migrationBuilder.RenameTable(
                name: "vehicleInformation",
                newName: "VehicleInformation");

            migrationBuilder.RenameTable(
                name: "policies",
                newName: "Policies");

            migrationBuilder.RenameTable(
                name: "payments",
                newName: "Payments");

            migrationBuilder.RenameTable(
                name: "naturalDisasters",
                newName: "NaturalDisasters");

            migrationBuilder.RenameTable(
                name: "customers",
                newName: "Customers");

            migrationBuilder.RenameTable(
                name: "vehicleInsuranceValue",
                newName: "VehicleInsuranceValues");

            migrationBuilder.RenameTable(
                name: "vehicle",
                newName: "Vehicles");

            migrationBuilder.RenameTable(
                name: "health",
                newName: "Healths");

            migrationBuilder.RenameIndex(
                name: "IX_policies_CustomerID",
                table: "Policies",
                newName: "IX_Policies_CustomerID");

            migrationBuilder.RenameIndex(
                name: "IX_payments_PolicyNo",
                table: "Payments",
                newName: "IX_Payments_PolicyNo");

            migrationBuilder.RenameIndex(
                name: "IX_naturalDisasters_PolicyNo",
                table: "NaturalDisasters",
                newName: "IX_NaturalDisasters_PolicyNo");

            migrationBuilder.RenameIndex(
                name: "IX_vehicleInsuranceValue_VehicleID",
                table: "VehicleInsuranceValues",
                newName: "IX_VehicleInsuranceValues_VehicleID");

            migrationBuilder.RenameIndex(
                name: "IX_vehicle_PolicyNo",
                table: "Vehicles",
                newName: "IX_Vehicles_PolicyNo");

            migrationBuilder.RenameIndex(
                name: "IX_health_PolicyNo",
                table: "Healths",
                newName: "IX_Healths_PolicyNo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VehicleInformation",
                table: "VehicleInformation",
                column: "VehicleID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Policies",
                table: "Policies",
                column: "PolicyNo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Payments",
                table: "Payments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NaturalDisasters",
                table: "NaturalDisasters",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customers",
                table: "Customers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VehicleInsuranceValues",
                table: "VehicleInsuranceValues",
                column: "ValueID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vehicles",
                table: "Vehicles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Healths",
                table: "Healths",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Healths_Policies_PolicyNo",
                table: "Healths",
                column: "PolicyNo",
                principalTable: "Policies",
                principalColumn: "PolicyNo",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NaturalDisasters_Policies_PolicyNo",
                table: "NaturalDisasters",
                column: "PolicyNo",
                principalTable: "Policies",
                principalColumn: "PolicyNo",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Policies_PolicyNo",
                table: "Payments",
                column: "PolicyNo",
                principalTable: "Policies",
                principalColumn: "PolicyNo",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Policies_Customers_CustomerID",
                table: "Policies",
                column: "CustomerID",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleInsuranceValues_VehicleInformation_VehicleID",
                table: "VehicleInsuranceValues",
                column: "VehicleID",
                principalTable: "VehicleInformation",
                principalColumn: "VehicleID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Policies_PolicyNo",
                table: "Vehicles",
                column: "PolicyNo",
                principalTable: "Policies",
                principalColumn: "PolicyNo",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
