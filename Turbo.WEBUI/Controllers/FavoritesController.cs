using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Turbo.DAL.DbContext;
using Turbo.DAL.ViewModel;

namespace Turbo.WEBUI.Controllers
{
    public class FavoritesController : Controller
    {
        private readonly AppDbContext _context;

        public FavoritesController(AppDbContext context) 
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var favoriteProducts = Request.Cookies["FavoriteProducts"];
            List<int> productIds;

            if (string.IsNullOrEmpty(favoriteProducts))
            {
                productIds = new List<int>();
            }
            else
            {
                productIds = JsonConvert.DeserializeObject<List<int>>(favoriteProducts);
            }

            var favoriteItems = _context.Products.Where(p => productIds.Contains(p.Id)).ToList();
            ViewBag.FavoriteItems = favoriteItems;
            return View(favoriteItems);
        }

        [HttpPost]
        public IActionResult AddToFavorites(int productId)
        {
            var favoriteProducts = Request.Cookies["FavoriteProducts"];
            List<int> productIds;

            if (string.IsNullOrEmpty(favoriteProducts))
            {
                productIds = new List<int>();
            }
            else
            {
                productIds = JsonConvert.DeserializeObject<List<int>>(favoriteProducts);
            }

            if (!productIds.Contains(productId))
            {
                productIds.Add(productId);
            }

            var options = new CookieOptions
            {
                Expires = DateTime.Now.AddDays(30)
            };
            Response.Cookies.Append("FavoriteProducts", JsonConvert.SerializeObject(productIds), options);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult RemoveFromFavorites(int productId)
        {
            var favoriteProducts = Request.Cookies["FavoriteProducts"];
            if (string.IsNullOrEmpty(favoriteProducts))
            {
                return RedirectToAction("Index");
            }

            var productIds = JsonConvert.DeserializeObject<List<int>>(favoriteProducts);
            productIds.Remove(productId);

            var options = new CookieOptions
            {
                Expires = DateTime.Now.AddDays(30)
            };
            Response.Cookies.Append("FavoriteProducts", JsonConvert.SerializeObject(productIds), options);

            return RedirectToAction("Index");
        }
    }
}
