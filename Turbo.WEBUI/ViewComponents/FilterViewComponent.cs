﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Turbo.BLL.Services.Interfaces;
using Turbo.DAL.DbContext;
using Turbo.DAL.ViewModel;

namespace Turbo.WEBUI.ViewComponents
{
    public class FilterViewComponent : ViewComponent
    {
        private readonly AppDbContext db;
        private readonly IProductService _productService;

        public FilterViewComponent(AppDbContext db, IProductService productService)
        {
            this.db = db;
            _productService = productService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var vm =  new FilterViewModel();
            vm.MarkaCategories = await db.MarkaCategories.ToListAsync();
            vm.Models = await db.ModelCategories.ToListAsync();
            vm.BanTypes = await db.BanTypeCategories.ToListAsync();
            vm.NumberOfSeats = await db.NumberOfSeatsCategories.ToListAsync();
            vm.CityCategories = await db.CityCategories.ToListAsync();
            vm.Colors = await db.ColorCategories.ToListAsync();
            vm.EngineCapacities = await db.EngineCapacities.ToListAsync();
            vm.FuelTypes = await db.FuelTypeCategories.ToListAsync();
            vm.GearBoxes = await db.GearBoxCategories.ToListAsync();
            vm.Gears = await db.GearCategories.ToListAsync();
            vm.MarkaCategories = await db.MarkaCategories.ToListAsync();
            vm.Years = await db.YearCategories.ToListAsync();
            vm.HowManyOwners = await db.HowManies.ToListAsync();
            vm.MarketAssembleds = await db.MarketAssembleds.ToListAsync();
            //vm.VehicleSupply = await db.VehicleSupplyCategories.ToListAsync();

            int todayProductCount = await _productService.GetTodayProductCountAsync();
            ViewBag.TodayProductCount = todayProductCount;
            return View(vm);
        }
    }
}
