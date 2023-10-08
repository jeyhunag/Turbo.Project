using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Turbo.DAL.Migrations
{
    /// <inheritdoc />
    public partial class init7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MarkaId",
                table: "ModelCategories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ModelCategories_MarkaId",
                table: "ModelCategories",
                column: "MarkaId");

            migrationBuilder.AddForeignKey(
                name: "FK_ModelCategories_MarkaCategories_MarkaId",
                table: "ModelCategories",
                column: "MarkaId",
                principalTable: "MarkaCategories",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ModelCategories_MarkaCategories_MarkaId",
                table: "ModelCategories");

            migrationBuilder.DropIndex(
                name: "IX_ModelCategories_MarkaId",
                table: "ModelCategories");

            migrationBuilder.DropColumn(
                name: "MarkaId",
                table: "ModelCategories");
        }
    }
}
