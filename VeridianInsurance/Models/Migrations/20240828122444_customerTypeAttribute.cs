using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VeridianInsurance.Data.Migrations
{
    /// <inheritdoc />
    public partial class customerTypeAttribute : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<string>(
                name: "type",
                table: "customers",
                type: "char(1)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "type",
                table: "customers");

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
        }
    }
}
