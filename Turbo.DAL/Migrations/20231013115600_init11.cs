using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Turbo.DAL.Migrations
{
    /// <inheritdoc />
    public partial class init11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ModelCategories_MarkaCategories_MarkaId",
                table: "ModelCategories");

            migrationBuilder.RenameColumn(
                name: "MarkaId",
                table: "ModelCategories",
                newName: "MarkaCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_ModelCategories_MarkaId",
                table: "ModelCategories",
                newName: "IX_ModelCategories_MarkaCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_ModelCategories_MarkaCategories_MarkaCategoryId",
                table: "ModelCategories",
                column: "MarkaCategoryId",
                principalTable: "MarkaCategories",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ModelCategories_MarkaCategories_MarkaCategoryId",
                table: "ModelCategories");

            migrationBuilder.RenameColumn(
                name: "MarkaCategoryId",
                table: "ModelCategories",
                newName: "MarkaId");

            migrationBuilder.RenameIndex(
                name: "IX_ModelCategories_MarkaCategoryId",
                table: "ModelCategories",
                newName: "IX_ModelCategories_MarkaId");

            migrationBuilder.AddForeignKey(
                name: "FK_ModelCategories_MarkaCategories_MarkaId",
                table: "ModelCategories",
                column: "MarkaId",
                principalTable: "MarkaCategories",
                principalColumn: "Id");
        }
    }
}
