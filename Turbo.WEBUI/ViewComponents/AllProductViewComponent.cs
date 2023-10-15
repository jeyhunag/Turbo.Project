using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Turbo.DAL.Data;
using Turbo.DAL.DbContext;
using Turbo.DAL.ViewModel;
using Turbo.WEBUI.Models;

namespace Turbo.WEBUI.ViewComponents
{
    public class AllProductViewComponent: ViewComponent
    {
        private readonly AppDbContext db;
        public AllProductViewComponent(AppDbContext db)
        {
            this.db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync(FilterViewModel filter, int pageIndex = 1, int pagSize = 5, bool istype = false, string type = "")
        {

            var products = db.Products
                          .Where(p => (type == "Vip" && p.IsVip == istype) || (type == "Premium" && p.IsPremium == istype) || string.IsNullOrEmpty(type))
                          .Include(p => p.MarkaCategory)
                          .Include(p => p.ModelCategory)
                          .Include(p => p.YearCategory)
                          .Include(p => p.EngineCapacityCategory)
                          .Include(p => p.CityCategory)
                          .ToList();
            if (type=="Vip") {
                ViewBag.Vip = "Vip"; 
            }
            var product= new PagedViewModel<Product>(products, pageIndex, pagSize);
            return View(product);
        }
    }
}
