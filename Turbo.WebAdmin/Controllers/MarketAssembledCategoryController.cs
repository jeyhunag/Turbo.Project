using Microsoft.AspNetCore.Mvc;
using Turbo.BLL.Services.Interfaces;
using Turbo.DAL.Data;
using Turbo.DAL.Dto;

namespace Turbo.WebAdmin.Controllers
{
    public class MarketAssembledCategoryController : Controller
    {
        private readonly IGenericService<MarketAssembledCategoryDto, MarketAssembledCategory> _service;


        public MarketAssembledCategoryController(IGenericService<MarketAssembledCategoryDto, MarketAssembledCategory> service)
        {
            _service = service;
        }



        public async Task<IActionResult> Index()
        {
            var categories = await _service.GetListAsync();
            return View(categories);
        }


        public async Task<IActionResult> Create()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create(MarketAssembledCategoryDto itemDto)
        {
            if (ModelState.IsValid)
            {
                var category = await _service.AddAsync(itemDto);
                if (category != null)
                {
                    return RedirectToAction("Index");
                }
            }
            return View(itemDto);
        }

        public async Task<IActionResult> Update(int id)
        {
            var categories = await _service.GetByIdAsync(id);
            return View(categories);
        }


        [HttpPost]
        public IActionResult Update(MarketAssembledCategoryDto itemDto)
        {
            if (ModelState.IsValid)
            {
                var categories = _service.Update(itemDto);
                if (categories != null)
                {
                    return RedirectToAction("Index");
                }
            }

            return View(itemDto);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var category = await _service.GetByIdAsync(id);
            return View(category);
        }


        [HttpPost]
        public IActionResult Delete(MarketAssembledCategoryDto itemDto)
        {
            _service.Delete(itemDto.Id);
            return RedirectToAction("Index");
        }
    }
}
