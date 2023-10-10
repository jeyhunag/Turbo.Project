using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Turbo.DAL.DbContext;
using Turbo.DAL.ViewModel;

namespace Turbo.WEBUI.ViewComponents
{
    public class ProductCardDetailsViewComponent : ViewComponent
    {
        private readonly AppDbContext db;
        public ProductCardDetailsViewComponent(AppDbContext db)
        {
            this.db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync(string markaName, string modelName,int currentProductId)
        {
            var model = db.Products
             .Where(p => p.MarkaCategory.Name == markaName && p.ModelCategory.Name == modelName && p.Id != currentProductId)
               .Include(p => p.YearCategory).
               Include(p => p.EngineCapacityCategory)
               .Include(p => p.CityCategory)
             .ToList();


            return View(model);
        }


    }
}
