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
                name: "FK_ModelCategories_MarkaCategories_MarkaCategoryId",
                table: "ModelCategories");

            migrationBuilder.DropIndex(
                name: "IX_ModelCategories_MarkaCategoryId",
                table: "ModelCategories");

            migrationBuilder.DropColumn(
                name: "MarkaCategoryId",
                table: "ModelCategories");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MarkaCategoryId",
                table: "ModelCategories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ModelCategories_MarkaCategoryId",
                table: "ModelCategories",
                column: "MarkaCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_ModelCategories_MarkaCategories_MarkaCategoryId",
                table: "ModelCategories",
                column: "MarkaCategoryId",
                principalTable: "MarkaCategories",
                principalColumn: "Id");
        }
    }
}
