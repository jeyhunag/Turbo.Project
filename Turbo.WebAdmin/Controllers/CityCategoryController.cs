using Microsoft.AspNetCore.Mvc;
using Turbo.BLL.Services.Interfaces;
using Turbo.DAL.Data;
using Turbo.DAL.Dto;

namespace Turbo.WebAdmin.Controllers
{
    public class CityCategoryController : Controller
    {
        private readonly IGenericService<CityCategoryDto, CityCategory> _service;


        public CityCategoryController(IGenericService<CityCategoryDto, CityCategory> service)
        {
            _service = service;
        }



        public async Task<IActionResult> Index()
        {
            var cityCategories = await _service.GetListAsync();
            return View(cityCategories);
        }


        public async Task<IActionResult> Create()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create(CityCategoryDto itemDto)
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
            var cityCategories = await _service.GetByIdAsync(id);
            return View(cityCategories);
        }


        [HttpPost]
        public IActionResult Update(CityCategoryDto itemDto)
        {
            if (ModelState.IsValid)
            {
                var cityCategories = _service.Update(itemDto);
                if (cityCategories != null)
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
        public IActionResult Delete(CityCategoryDto itemDto)
        {
            _service.Delete(itemDto.Id);
            return RedirectToAction("Index");
        }
    }
}
