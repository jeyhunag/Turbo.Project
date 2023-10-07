using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Turbo.DAL.DbContext;

namespace Turbo.WEBUI.ViewComponents
{
    public class ProductCardViewComponent : ViewComponent
    {
        private readonly AppDbContext db;
        public ProductCardViewComponent(AppDbContext db)
        {
            this.db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = db.Products.Include(p => p.MarkaCategory).
                Include(p => p.ModelCategory).Include(p => p.YearCategory).
                Include(p => p.EngineCapacityCategory).Include(p => p.CityCategory).ToList();
            return View(model);
        }
    }
}
