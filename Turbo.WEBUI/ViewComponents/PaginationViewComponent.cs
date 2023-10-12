using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Turbo.DAL.DbContext;
using Turbo.DAL.ViewModel;

namespace Turbo.WEBUI.ViewComponents
{
   
    public class PaginationViewComponent : ViewComponent
    {
        private readonly AppDbContext db;
        public PaginationViewComponent(AppDbContext db)
        {
            this.db = db;
        }

        public IViewComponentResult Invoke(FilterViewModel filter,int currentPage, int totalPages)
        {
            var query = db.Products.Where(p => (filter.Type == "Vip" && p.IsVip) || (filter.Type == "Premium" && p.IsPremium) || string.IsNullOrEmpty(filter.Type))
                  .Include(p => p.MarkaCategory)
                  .Include(p => p.ModelCategory)
                  .Include(p => p.YearCategory).
                  Include(p => p.EngineCapacityCategory).Include(p => p.CityCategory).ToList();
            var modell = query.Skip((filter.CurrentPage - 1) * filter.PageSize)
                          .Take(filter.PageSize).ToList();
            return View(modell);
        }
    }

}
