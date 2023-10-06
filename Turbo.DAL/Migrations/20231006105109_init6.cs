using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Turbo.DAL.Migrations
{
    /// <inheritdoc />
    public partial class init6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VehicleSituation",
                table: "Products");

            migrationBuilder.AddColumn<bool>(
                name: "IsAccident",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsColor",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsHis",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAccident",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "IsColor",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "IsHis",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "VehicleSituation",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
