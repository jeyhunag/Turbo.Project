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

            var modell = db.Products.Include(p => p.MarkaCategory).
                Include(p => p.ModelCategory).Include(p => p.YearCategory).
                Include(p => p.EngineCapacityCategory).Include(p => p.CityCategory).ToList();



            if (filter.MarKaId > 0)
            {
                modell = modell.Where(p=>p.MarkaCategoryId==filter.MarKaId).ToList();
            }

            if (filter.ModelId > 0)
            {
                modell = modell.Where(p => p.ModelCategoryId == filter.ModelId).ToList();
            }

            if (filter.BanTypeId > 0)
            {
                modell = modell.Where(p => p.BanTypeCategoryId == filter.BanTypeId).ToList();
            }

            if (filter.NumberOfId > 0)
            {
                modell = modell.Where(p => p.NumberOfSeatsCategoryId == filter.NumberOfId).ToList();
            }

            if (filter.CityId > 0)
            {
                modell = modell.Where(p => p.CityCategoryId == filter.CityId).ToList();
            }

            if (filter.ColorId > 0)
            {
                modell = modell.Where(p => p.ColorCategoryId == filter.ColorId).ToList();
            }

            if (filter.EngineCapasityId > 0)
            {
                modell = modell.Where(p => p.EngineCapacityCategoryId == filter.EngineCapasityId).ToList();
            }

            if (filter.FuelTypeId > 0)
            {
                modell = modell.Where(p => p.FuelTypeCategoryId == filter.FuelTypeId).ToList();
            }

            if (filter.GearBoxId > 0)
            {
                modell = modell.Where(p => p.GearBoxCategoryId == filter.GearBoxId).ToList();
            }

            if (filter.GearId > 0)
            {
                modell = modell.Where(p => p.GearCategoryId == filter.GearId).ToList();
            }

            if (filter.MarkedId > 0)
            {
                modell = modell.Where(p => p.MarketAssembledCategoryId == filter.MarkedId).ToList();
            }

            if (filter.YearId > 0)
            {
                modell = modell.Where(p => p.YearCategoryId == filter.YearId).ToList();
            }

            if (filter.HowManyOwnerId > 0)
            {
                modell = modell.Where(p => p.HowManyOwnerCategoryId == filter.HowManyOwnerId).ToList();
            }

            if (filter.IsCredit == true)
            {
                modell = modell.Where(p => p.IsCredit == filter.IsCredit).ToList();
            }

            if (filter.IsBarter == true)
            {
                modell = modell.Where(p => p.IsBarter == filter.IsBarter).ToList();
            }

            if (filter.minEngine > 0)
            {
                modell = modell.Where(p => p.EnginePower <= filter.minEngine).ToList();

            }

            if (filter.maxEngine > 0)
            {
                modell = modell.Where(p => p.EnginePower <= filter.maxEngine).ToList();
            }

            return View(modell);

        }
    }
}
