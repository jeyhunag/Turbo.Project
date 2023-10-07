using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Turbo.DAL.Migrations
{
    /// <inheritdoc />
    public partial class init5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_VehicleSupplyCategories_VehicleSupplyCategoryId",
                table: "Products");

            migrationBuilder.AlterColumn<int>(
                name: "VehicleSupplyCategoryId",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_VehicleSupplyCategories_VehicleSupplyCategoryId",
                table: "Products",
                column: "VehicleSupplyCategoryId",
                principalTable: "VehicleSupplyCategories",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_VehicleSupplyCategories_VehicleSupplyCategoryId",
                table: "Products");

            migrationBuilder.AlterColumn<int>(
                name: "VehicleSupplyCategoryId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_VehicleSupplyCategories_VehicleSupplyCategoryId",
                table: "Products",
                column: "VehicleSupplyCategoryId",
                principalTable: "VehicleSupplyCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
