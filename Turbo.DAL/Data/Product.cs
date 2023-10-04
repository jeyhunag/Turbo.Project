using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turbo.DAL.Data
{
    public class Product:BaseEntity
    {
        public int? Phone { get; set; }
        public List<string>? Img { get; set; }
        public string? March { get; set; }
        public float? Price { get; set; }
        public int? EnginePower { get; set; }
        public string? Situation { get; set; }
        public string? Description { get; set; }
        public char? NumberOfSeats { get; set; }
        public string? VINCod { get; set; }
        public string? CreditBarter { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? New { get; set; }
        public string? PINPassword { get; set; }
        public string? AdvertisementNumber { get; set; }

        public int BanTypeCategoryId { get; set; }
        public BanTypeCategory? BanTypeCategory { get; set; }
        public int CityCategoryId { get; set; }
        public CityCategory? CityCategory { get; set; }
        public int ColorCategoryId { get; set; }
        public ColorCategory? ColorCategory { get; set; }
        public int EngineCapacityCategoryId { get; set; }
        public EngineCapacityCategory? EngineCapacityCategory { get; set; }
        public int FuelTypeCategoryId { get; set; }
        public FuelTypeCategory? FuelTypeCategory { get; set; }
        public int GearBoxCategoryId { get; set; }
        public GearBoxCategory? GearBoxCategory { get; set; }
        public int GearCategoryId { get; set; }
        public GearCategory? GearCategory { get; set; }
        public int HowManyOwnerCategoryId { get; set; }
        public HowManyOwnerCategory? HowManyOwnerCategory { get; set; }
        public int MarkaCategoryId { get; set; }
        public MarkaCategory? MarkaCategory { get; set; }
        public int MarketAssembledCategoryId { get; set; }
        public MarketAssembledCategory? MarketAssembledCategory { get; set; }
        public int ModelCategoryId { get; set; }
        public ModelCategory? ModelCategory { get; set; }
        public int VehicleSupplyCategoryId { get; set; }
        public VehicleSupplyCategory? VehicleSupplyCategory { get; set; }
        public int YearCategoryId { get; set; }
        public YearCategory? YearCategory { get; set; }

    }
}
