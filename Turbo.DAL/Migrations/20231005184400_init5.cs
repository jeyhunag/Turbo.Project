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
            migrationBuilder.DropColumn(
                name: "CreditBarter",
                table: "Products");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreditBarter",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
