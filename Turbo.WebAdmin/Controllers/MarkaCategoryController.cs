using Microsoft.AspNetCore.Mvc;
using Turbo.BLL.Services.Interfaces;
using Turbo.DAL.Data;
using Turbo.DAL.Dto;

namespace Turbo.WebAdmin.Controllers
{
    public class MarkaCategoryController : Controller
    {
        private readonly IGenericService<MarkaCategoryDto, MarkaCategory> _service;


        public MarkaCategoryController(IGenericService<MarkaCategoryDto, MarkaCategory> service)
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
        public async Task<IActionResult> Create(MarkaCategoryDto itemDto)
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
        public IActionResult Update(MarkaCategoryDto itemDto)
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
        public IActionResult Delete(MarkaCategoryDto itemDto)
        {
            _service.Delete(itemDto.Id);
            return RedirectToAction("Index");
        }
    }
}
