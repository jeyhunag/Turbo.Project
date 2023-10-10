using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Turbo.DAL.DbContext;
using Turbo.DAL.ViewModel;

namespace Turbo.WEBUI.ViewComponents
{
    public class ProductCardViewComponent : ViewComponent
    {
        private readonly AppDbContext db;
        public ProductCardViewComponent(AppDbContext db)
        {
            this.db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync(FilterViewModel filter)
        {

            var modell = db.Products.
                   Where(p => filter.MarKaId <= 0 || p.MarkaCategoryId == filter.MarKaId)
                  .Where(p => filter.ModelId <= 0 || p.ModelCategoryId == filter.ModelId)
                  //.Where(p => filter.VehicleSupplyId <= 0 || p.VehicleSupplyCategoryId == filter.VehicleSupplyId)
                  .Where(p => filter.BanTypeId <= 0 || p.BanTypeCategoryId == filter.BanTypeId)
                  .Where(p => filter.NumberOfId <= 0 || p.NumberOfSeatsCategoryId == filter.NumberOfId)
                  .Where(p => filter.CityId <= 0 || p.CityCategoryId == filter.CityId)
                  .Where(p => filter.ColorId <= 0 || p.ColorCategoryId == filter.ColorId)
                  .Where(p => filter.EngineCapasityId <= 0 || p.EngineCapacityCategoryId == filter.EngineCapasityId)
                  .Where(p => filter.FuelTypeId <= 0 || p.FuelTypeCategoryId == filter.FuelTypeId)
                  .Where(p => filter.GearBoxId <= 0 || p.GearBoxCategoryId == filter.GearBoxId)
                  .Where(p => filter.GearId <= 0 || p.GearCategoryId == filter.GearId)
                  .Where(p => filter.MarkedId <= 0 || p.MarketAssembledCategoryId == filter.MarkedId)
                  .Where(p => filter.YearId <= 0 || p.YearCategoryId == filter.YearId)
                  .Where(p => filter.HowManyOwnerId <= 0 || p.HowManyOwnerCategoryId == filter.HowManyOwnerId)
                  .Where(p => !filter.IsCredit || p.IsCredit == filter.IsCredit)
                  .Where(p => !filter.IsBarter || p.IsBarter == filter.IsBarter)
                   .Where(p => !filter.IsHis || p.IsHis == filter.IsHis)
                  .Where(p => !filter.IsColor || p.IsColor == filter.IsColor)
                  .Where(p => !filter.IsAccident || p.IsAccident == filter.IsAccident)
                  .Where(p => filter.minEngine <= 0 || p.EnginePower <= filter.minEngine)
                  .Where(p => filter.maxEngine <= 0 || p.EnginePower <= filter.maxEngine)
                   .Where(p => filter.minPrice <= 0 || p.Price <= filter.minPrice)
                  .Where(p => filter.maxPrice <= 0 || p.Price <= filter.maxPrice)
                  .Where(p => filter.minYear <= 0 || p.YearCategoryId <= filter.minYear)
                  .Where(p => filter.maxYear <= 0 || p.YearCategoryId <= filter.maxYear)
                  .Where(p => filter.minEngineCapacity <= 0 || p.EngineCapacityCategoryId <= filter.minEngineCapacity)
                  .Where(p => filter.maxEngineCapacity <= 0 || p.EngineCapacityCategoryId <= filter.maxEngineCapacity)
                  .Where(p => filter.minMarch <= 0 || p.March <= filter.maxMarch)
                  .Where(p => filter.maxMarch <= 0 || p.March <= filter.maxMarch)
                  .Where(p => string.IsNullOrEmpty(filter.Valyuta) || p.Valyuta == filter.Valyuta)
                  .Include(p => p.MarkaCategory)
                  .Include(p => p.ModelCategory)
                  .Include(p => p.YearCategory).
                  Include(p => p.EngineCapacityCategory).Include(p => p.CityCategory).ToList();
            
            return View(modell);

        }
    }
}
