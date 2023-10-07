using Microsoft.AspNetCore.Mvc;
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
            var model = db.Products.ToList();
            return View(model);
        }
    }
}
