using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using Turbo.DAL.Data;
using Turbo.DAL.DbContext;
using Turbo.DAL.ViewModel;

namespace Turbo.WEBUI.ViewComponents
{
    public class AllProductViewComponent : ViewComponent
    {
        private readonly AppDbContext db;
        public AllProductViewComponent(AppDbContext db)
        {
            this.db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = db.Products
           .Include(p => p.YearCategory).
           Include(p => p.EngineCapacityCategory)
           .Include(p => p.CityCategory)
         .ToList();


            return View(model);
        }


    }
}
