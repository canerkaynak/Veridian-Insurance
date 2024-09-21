using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VeridianInsurance.Data.Migrations
{
    /// <inheritdoc />
    public partial class vb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "TypeCode",
                table: "vehicleInformation",
                newName: "typeCode");

            migrationBuilder.RenameColumn(
                name: "Model",
                table: "vehicleInformation",
                newName: "model");

            migrationBuilder.RenameColumn(
                name: "BrandCode",
                table: "vehicleInformation",
                newName: "brandCode");

            migrationBuilder.RenameColumn(
                name: "Brand",
                table: "vehicleInformation",
                newName: "brand");

            migrationBuilder.RenameColumn(
                name: "VehicleID",
                table: "vehicleInformation",
                newName: "vehicleId");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "policies",
                newName: "status");

            migrationBuilder.RenameColumn(
                name: "PriceOfThePolicy",
                table: "policies",
                newName: "priceOfThePolicy");

            migrationBuilder.RenameColumn(
                name: "DateOfIssue",
                table: "policies",
                newName: "dateOfIssue");

            migrationBuilder.RenameColumn(
                name: "CustomerID",
                table: "policies",
                newName: "customerId");

            migrationBuilder.RenameColumn(
                name: "BranchCode",
                table: "policies",
                newName: "branchCode");

            migrationBuilder.RenameColumn(
                name: "ApprovedBy",
                table: "policies",
                newName: "approvedBy");

            migrationBuilder.RenameColumn(
                name: "PolicyNo",
                table: "policies",
                newName: "policyNo");

            migrationBuilder.RenameIndex(
                name: "IX_policies_CustomerID",
                table: "policies",
                newName: "IX_policies_customerId");

            migrationBuilder.RenameColumn(
                name: "PolicyNo",
                table: "payments",
                newName: "policyNo");

            migrationBuilder.RenameColumn(
                name: "PaymentDate",
                table: "payments",
                newName: "paymentDate");

            migrationBuilder.RenameColumn(
                name: "PayedAmount",
                table: "payments",
                newName: "payedAmount");

            migrationBuilder.RenameColumn(
                name: "CardHolder",
                table: "payments",
                newName: "cardHolder");

            migrationBuilder.RenameIndex(
                name: "IX_payments_PolicyNo",
                table: "payments",
                newName: "IX_payments_policyNo");

            migrationBuilder.RenameColumn(
                name: "Uavt",
                table: "naturalDisasters",
                newName: "uavt");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "naturalDisasters",
                newName: "type");

            migrationBuilder.RenameColumn(
                name: "PolicyNo",
                table: "naturalDisasters",
                newName: "policyNo");

            migrationBuilder.RenameColumn(
                name: "Floor",
                table: "naturalDisasters",
                newName: "floor");

            migrationBuilder.RenameColumn(
                name: "BuildingAge",
                table: "naturalDisasters",
                newName: "buildingAge");

            migrationBuilder.RenameColumn(
                name: "Area",
                table: "naturalDisasters",
                newName: "area");

            migrationBuilder.RenameIndex(
                name: "IX_naturalDisasters_PolicyNo",
                table: "naturalDisasters",
                newName: "IX_naturalDisasters_policyNo");

            migrationBuilder.RenameColumn(
                name: "PolicyNo",
                table: "health",
                newName: "policyNo");

            migrationBuilder.RenameColumn(
                name: "IsSmoke",
                table: "health",
                newName: "isSmoke");

            migrationBuilder.RenameColumn(
                name: "IsHadOperation",
                table: "health",
                newName: "isHadOperation");

            migrationBuilder.RenameIndex(
                name: "IX_health_PolicyNo",
                table: "health",
                newName: "IX_health_policyNo");

            migrationBuilder.AlterColumn<string>(
                name: "typeCode",
                table: "vehicleInformation",
                type: "varchar(3)",
                maxLength: 3,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "model",
                table: "vehicleInformation",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "brandCode",
                table: "vehicleInformation",
                type: "varchar(3)",
                maxLength: 3,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "brand",
                table: "vehicleInformation",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "status",
                table: "policies",
                type: "char(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1)");

            migrationBuilder.AlterColumn<decimal>(
                name: "priceOfThePolicy",
                table: "policies",
                type: "money",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "dateOfIssue",
                table: "policies",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "branchCode",
                table: "policies",
                type: "varchar(3)",
                fixedLength: true,
                maxLength: 3,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "approvedBy",
                table: "policies",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "paymentDate",
                table: "payments",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<decimal>(
                name: "payedAmount",
                table: "payments",
                type: "money",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "cardHolder",
                table: "payments",
                type: "varchar",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "uavt",
                table: "naturalDisasters",
                type: "varchar(10)",
                fixedLength: true,
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "type",
                table: "naturalDisasters",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "area",
                table: "naturalDisasters",
                type: "char(64)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "isSmoke",
                table: "health",
                type: "char(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1)");

            migrationBuilder.AlterColumn<string>(
                name: "isHadOperation",
                table: "health",
                type: "char(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1)");

            migrationBuilder.AddForeignKey(
                name: "FK_health_policies_policyNo",
                table: "health",
                column: "policyNo",
                principalTable: "policies",
                principalColumn: "policyNo",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_naturalDisasters_policies_policyNo",
                table: "naturalDisasters",
                column: "policyNo",
                principalTable: "policies",
                principalColumn: "policyNo",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_payments_policies_policyNo",
                table: "payments",
                column: "policyNo",
                principalTable: "policies",
                principalColumn: "policyNo",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_policies_customers_customerId",
                table: "policies",
                column: "customerId",
                principalTable: "customers",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_health_policies_policyNo",
                table: "health");

            migrationBuilder.DropForeignKey(
                name: "FK_naturalDisasters_policies_policyNo",
                table: "naturalDisasters");

            migrationBuilder.DropForeignKey(
                name: "FK_payments_policies_policyNo",
                table: "payments");

            migrationBuilder.DropForeignKey(
                name: "FK_policies_customers_customerId",
                table: "policies");

            migrationBuilder.RenameColumn(
                name: "typeCode",
                table: "vehicleInformation",
                newName: "TypeCode");

            migrationBuilder.RenameColumn(
                name: "model",
                table: "vehicleInformation",
                newName: "Model");

            migrationBuilder.RenameColumn(
                name: "brandCode",
                table: "vehicleInformation",
                newName: "BrandCode");

            migrationBuilder.RenameColumn(
                name: "brand",
                table: "vehicleInformation",
                newName: "Brand");

            migrationBuilder.RenameColumn(
                name: "vehicleId",
                table: "vehicleInformation",
                newName: "VehicleID");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "policies",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "priceOfThePolicy",
                table: "policies",
                newName: "PriceOfThePolicy");

            migrationBuilder.RenameColumn(
                name: "dateOfIssue",
                table: "policies",
                newName: "DateOfIssue");

            migrationBuilder.RenameColumn(
                name: "customerId",
                table: "policies",
                newName: "CustomerID");

            migrationBuilder.RenameColumn(
                name: "branchCode",
                table: "policies",
                newName: "BranchCode");

            migrationBuilder.RenameColumn(
                name: "approvedBy",
                table: "policies",
                newName: "ApprovedBy");

            migrationBuilder.RenameColumn(
                name: "policyNo",
                table: "policies",
                newName: "PolicyNo");

            migrationBuilder.RenameIndex(
                name: "IX_policies_customerId",
                table: "policies",
                newName: "IX_policies_CustomerID");

            migrationBuilder.RenameColumn(
                name: "policyNo",
                table: "payments",
                newName: "PolicyNo");

            migrationBuilder.RenameColumn(
                name: "paymentDate",
                table: "payments",
                newName: "PaymentDate");

            migrationBuilder.RenameColumn(
                name: "payedAmount",
                table: "payments",
                newName: "PayedAmount");

            migrationBuilder.RenameColumn(
                name: "cardHolder",
                table: "payments",
                newName: "CardHolder");

            migrationBuilder.RenameIndex(
                name: "IX_payments_policyNo",
                table: "payments",
                newName: "IX_payments_PolicyNo");

            migrationBuilder.RenameColumn(
                name: "uavt",
                table: "naturalDisasters",
                newName: "Uavt");

            migrationBuilder.RenameColumn(
                name: "type",
                table: "naturalDisasters",
                newName: "Type");

            migrationBuilder.RenameColumn(
                name: "policyNo",
                table: "naturalDisasters",
                newName: "PolicyNo");

            migrationBuilder.RenameColumn(
                name: "floor",
                table: "naturalDisasters",
                newName: "Floor");

            migrationBuilder.RenameColumn(
                name: "buildingAge",
                table: "naturalDisasters",
                newName: "BuildingAge");

            migrationBuilder.RenameColumn(
                name: "area",
                table: "naturalDisasters",
                newName: "Area");

            migrationBuilder.RenameIndex(
                name: "IX_naturalDisasters_policyNo",
                table: "naturalDisasters",
                newName: "IX_naturalDisasters_PolicyNo");

            migrationBuilder.RenameColumn(
                name: "policyNo",
                table: "health",
                newName: "PolicyNo");

            migrationBuilder.RenameColumn(
                name: "isSmoke",
                table: "health",
                newName: "IsSmoke");

            migrationBuilder.RenameColumn(
                name: "isHadOperation",
                table: "health",
                newName: "IsHadOperation");

            migrationBuilder.RenameIndex(
                name: "IX_health_policyNo",
                table: "health",
                newName: "IX_health_PolicyNo");

            migrationBuilder.AlterColumn<string>(
                name: "TypeCode",
                table: "vehicleInformation",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(3)",
                oldMaxLength: 3);

            migrationBuilder.AlterColumn<string>(
                name: "Model",
                table: "vehicleInformation",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "BrandCode",
                table: "vehicleInformation",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(3)",
                oldMaxLength: 3);

            migrationBuilder.AlterColumn<string>(
                name: "Brand",
                table: "vehicleInformation",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "policies",
                type: "nvarchar(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(1)");

            migrationBuilder.AlterColumn<int>(
                name: "PriceOfThePolicy",
                table: "policies",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfIssue",
                table: "policies",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.AlterColumn<string>(
                name: "BranchCode",
                table: "policies",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(3)",
                oldFixedLength: true,
                oldMaxLength: 3);

            migrationBuilder.AlterColumn<string>(
                name: "ApprovedBy",
                table: "policies",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                table: "payments",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.AlterColumn<int>(
                name: "PayedAmount",
                table: "payments",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money");

            migrationBuilder.AlterColumn<string>(
                name: "CardHolder",
                table: "payments",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar");

            migrationBuilder.AlterColumn<string>(
                name: "Uavt",
                table: "naturalDisasters",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(10)",
                oldFixedLength: true,
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "naturalDisasters",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<int>(
                name: "Area",
                table: "naturalDisasters",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(64)");

            migrationBuilder.AlterColumn<string>(
                name: "IsSmoke",
                table: "health",
                type: "nvarchar(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(1)");

            migrationBuilder.AlterColumn<string>(
                name: "IsHadOperation",
                table: "health",
                type: "nvarchar(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(1)");

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
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
