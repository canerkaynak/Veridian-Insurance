using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VeridianInsurance.Data.Migrations
{
    /// <inheritdoc />
    public partial class v5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_vehicle_policies_PolicyNo",
                table: "vehicle");

            migrationBuilder.DropColumn(
                name: "Plate",
                table: "vehicle");

            migrationBuilder.RenameColumn(
                name: "PolicyNo",
                table: "vehicle",
                newName: "policyNo");

            migrationBuilder.RenameColumn(
                name: "PlateCityCode",
                table: "vehicle",
                newName: "plateCityCode");

            migrationBuilder.RenameColumn(
                name: "ModelYear",
                table: "vehicle",
                newName: "modelYear");

            migrationBuilder.RenameColumn(
                name: "Model",
                table: "vehicle",
                newName: "model");

            migrationBuilder.RenameColumn(
                name: "ChassisSerialNumber",
                table: "vehicle",
                newName: "chassisSerialNumber");

            migrationBuilder.RenameColumn(
                name: "Brand",
                table: "vehicle",
                newName: "brand");

            migrationBuilder.RenameIndex(
                name: "IX_vehicle_PolicyNo",
                table: "vehicle",
                newName: "IX_vehicle_policyNo");

            migrationBuilder.AlterColumn<DateTime>(
                name: "year",
                table: "vehicleInsuranceValue",
                type: "date",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<decimal>(
                name: "value",
                table: "vehicleInsuranceValue",
                type: "Decimal(19,4)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "plateCityCode",
                table: "vehicle",
                type: "varchar(2)",
                fixedLength: true,
                maxLength: 2,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "model",
                table: "vehicle",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "chassisSerialNumber",
                table: "vehicle",
                type: "varchar(17)",
                fixedLength: true,
                maxLength: 17,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "brand",
                table: "vehicle",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "plateCode",
                table: "vehicle",
                type: "varchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "status",
                table: "policies",
                type: "char(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char");

            migrationBuilder.AlterColumn<decimal>(
                name: "payedAmount",
                table: "payments",
                type: "Decimal(19,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money");

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
                name: "FK_vehicle_policies_policyNo",
                table: "vehicle",
                column: "policyNo",
                principalTable: "policies",
                principalColumn: "policyNo",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_vehicle_policies_policyNo",
                table: "vehicle");

            migrationBuilder.DropColumn(
                name: "plateCode",
                table: "vehicle");

            migrationBuilder.RenameColumn(
                name: "policyNo",
                table: "vehicle",
                newName: "PolicyNo");

            migrationBuilder.RenameColumn(
                name: "plateCityCode",
                table: "vehicle",
                newName: "PlateCityCode");

            migrationBuilder.RenameColumn(
                name: "modelYear",
                table: "vehicle",
                newName: "ModelYear");

            migrationBuilder.RenameColumn(
                name: "model",
                table: "vehicle",
                newName: "Model");

            migrationBuilder.RenameColumn(
                name: "chassisSerialNumber",
                table: "vehicle",
                newName: "ChassisSerialNumber");

            migrationBuilder.RenameColumn(
                name: "brand",
                table: "vehicle",
                newName: "Brand");

            migrationBuilder.RenameIndex(
                name: "IX_vehicle_policyNo",
                table: "vehicle",
                newName: "IX_vehicle_PolicyNo");

            migrationBuilder.AlterColumn<string>(
                name: "year",
                table: "vehicleInsuranceValue",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<int>(
                name: "value",
                table: "vehicleInsuranceValue",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "Decimal(19,4)");

            migrationBuilder.AlterColumn<string>(
                name: "PlateCityCode",
                table: "vehicle",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(2)",
                oldFixedLength: true,
                oldMaxLength: 2);

            migrationBuilder.AlterColumn<string>(
                name: "Model",
                table: "vehicle",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "ChassisSerialNumber",
                table: "vehicle",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(17)",
                oldFixedLength: true,
                oldMaxLength: 17);

            migrationBuilder.AlterColumn<string>(
                name: "Brand",
                table: "vehicle",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<string>(
                name: "Plate",
                table: "vehicle",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "status",
                table: "policies",
                type: "char",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(1)");

            migrationBuilder.AlterColumn<decimal>(
                name: "payedAmount",
                table: "payments",
                type: "money",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "Decimal(19,4)");

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
                name: "FK_vehicle_policies_PolicyNo",
                table: "vehicle",
                column: "PolicyNo",
                principalTable: "policies",
                principalColumn: "policyNo",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
