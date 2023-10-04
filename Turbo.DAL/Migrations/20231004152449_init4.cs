using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Turbo.DAL.Migrations
{
    /// <inheritdoc />
    public partial class init4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Phone = table.Column<int>(type: "int", nullable: true),
                    March = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<float>(type: "real", nullable: true),
                    EnginePower = table.Column<int>(type: "int", nullable: true),
                    Situation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfSeats = table.Column<string>(type: "nvarchar(1)", nullable: true),
                    VINCod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreditBarter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    New = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PINPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdvertisementNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BanTypeCategoryId = table.Column<int>(type: "int", nullable: false),
                    CityCategoryId = table.Column<int>(type: "int", nullable: false),
                    ColorCategoryId = table.Column<int>(type: "int", nullable: false),
                    EngineCapacityCategoryId = table.Column<int>(type: "int", nullable: false),
                    FuelTypeCategoryId = table.Column<int>(type: "int", nullable: false),
                    GearBoxCategoryId = table.Column<int>(type: "int", nullable: false),
                    GearCategoryId = table.Column<int>(type: "int", nullable: false),
                    HowManyOwnerCategoryId = table.Column<int>(type: "int", nullable: false),
                    MarkaCategoryId = table.Column<int>(type: "int", nullable: false),
                    MarketAssembledCategoryId = table.Column<int>(type: "int", nullable: false),
                    ModelCategoryId = table.Column<int>(type: "int", nullable: false),
                    VehicleSupplyCategoryId = table.Column<int>(type: "int", nullable: false),
                    YearCategoryId = table.Column<int>(type: "int", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_BanTypeCategories_BanTypeCategoryId",
                        column: x => x.BanTypeCategoryId,
                        principalTable: "BanTypeCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_CityCategories_CityCategoryId",
                        column: x => x.CityCategoryId,
                        principalTable: "CityCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_ColorCategories_ColorCategoryId",
                        column: x => x.ColorCategoryId,
                        principalTable: "ColorCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_EngineCapacities_EngineCapacityCategoryId",
                        column: x => x.EngineCapacityCategoryId,
                        principalTable: "EngineCapacities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_FuelTypeCategories_FuelTypeCategoryId",
                        column: x => x.FuelTypeCategoryId,
                        principalTable: "FuelTypeCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_GearBoxCategories_GearBoxCategoryId",
                        column: x => x.GearBoxCategoryId,
                        principalTable: "GearBoxCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_GearCategories_GearCategoryId",
                        column: x => x.GearCategoryId,
                        principalTable: "GearCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_HowManies_HowManyOwnerCategoryId",
                        column: x => x.HowManyOwnerCategoryId,
                        principalTable: "HowManies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_MarkaCategories_MarkaCategoryId",
                        column: x => x.MarkaCategoryId,
                        principalTable: "MarkaCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_MarketAssembleds_MarketAssembledCategoryId",
                        column: x => x.MarketAssembledCategoryId,
                        principalTable: "MarketAssembleds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_ModelCategories_ModelCategoryId",
                        column: x => x.ModelCategoryId,
                        principalTable: "ModelCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_VehicleSupplyCategories_VehicleSupplyCategoryId",
                        column: x => x.VehicleSupplyCategoryId,
                        principalTable: "VehicleSupplyCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_YearCategories_YearCategoryId",
                        column: x => x.YearCategoryId,
                        principalTable: "YearCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_BanTypeCategoryId",
                table: "Products",
                column: "BanTypeCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CityCategoryId",
                table: "Products",
                column: "CityCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ColorCategoryId",
                table: "Products",
                column: "ColorCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_EngineCapacityCategoryId",
                table: "Products",
                column: "EngineCapacityCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_FuelTypeCategoryId",
                table: "Products",
                column: "FuelTypeCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_GearBoxCategoryId",
                table: "Products",
                column: "GearBoxCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_GearCategoryId",
                table: "Products",
                column: "GearCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_HowManyOwnerCategoryId",
                table: "Products",
                column: "HowManyOwnerCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_MarkaCategoryId",
                table: "Products",
                column: "MarkaCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_MarketAssembledCategoryId",
                table: "Products",
                column: "MarketAssembledCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ModelCategoryId",
                table: "Products",
                column: "ModelCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_VehicleSupplyCategoryId",
                table: "Products",
                column: "VehicleSupplyCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_YearCategoryId",
                table: "Products",
                column: "YearCategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
