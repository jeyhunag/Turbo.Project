using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Turbo.DAL.Data;

namespace Turbo.DAL.ViewModel
{
    public class FilterViewModel
    {
        public IEnumerable<MarkaCategory> MarkaCategories { get; set; }
        public IEnumerable<ModelCategory> Models { get; set; }
        public IEnumerable<BanTypeCategory> BanTypes { get; set; }
        public IEnumerable<NumberOfSeatsCategory> NumberOfSeats { get; set; }
        public IEnumerable<CityCategory> CityCategories { get; set; }
        public IEnumerable<ColorCategory> Colors { get; set; }
        public IEnumerable<EngineCapacityCategory> EngineCapacities { get; set; }
        public IEnumerable<FuelTypeCategory> FuelTypes { get; set; }
        public IEnumerable<GearBoxCategory> GearBoxes { get; set; }
        public IEnumerable<GearCategory> Gears { get; set; }
        public IEnumerable<MarketAssembledCategory> MarketAssembleds { get; set; }
        public IEnumerable<YearCategory> Years { get; set; }
        public IEnumerable<HowManyOwnerCategory> HowManyOwners { get; set; }
        //public IEnumerable<VehicleSupplyCategory>? VehicleSupply { get; set; }

        public int MarKaId { get; set; }
         public int ModelId { get; set; }
         public int BanTypeId { get; set; }
         public int NumberOfId { get; set; }
         public int CityId { get; set; }
         public int ColorId { get; set; }
         public int EngineCapasityId { get; set; }
         public int FuelTypeId { get; set; }
         public int GearBoxId { get; set; }
         public int GearId { get; set; }
         public int MarkedId { get; set; }
         public int YearId { get; set; }
         public int HowManyOwnerId { get; set; }
         //public int? VehicleSupplyId { get; set; }


        public bool IsCredit { get; set; }
        public bool IsBarter { get; set; }
        public bool IsChecked { get; set; }
        public bool IsMarch { get; set; }
        public bool IsHis { get; set; }
        public bool IsColor { get; set; }
        public bool IsAccident { get; set; }
        public bool IsVip { get; set; }
        public bool IsPremium { get; set; }
        public string? Valyuta { get; set; }

        public int? EnginePower { get; set; }
        public int minEngine { get; set; }
        public int maxEngine { get; set; }
        public string? March { get; set; }

        public string Type { get; set; }
        public float? Price { get; set; }
        public float minPrice { get; set; }
        public float maxPrice { get; set; }
        public int minYear { get; set; }
        public int maxYear { get; set; }
        public int minEngineCapacity { get; set; }
        public int maxEngineCapacity { get; set; }
        public int minMarch { get; set; }
        public int maxMarch { get; set; }


        //Pagination
        public int CurrentPage { get; set; } = 1;
        public int PageSize { get; set; } = 5;

    }
}
