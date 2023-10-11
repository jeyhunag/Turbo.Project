using Microsoft.AspNetCore.Mvc;
using Turbo.BLL.Services.Interfaces;
using Turbo.DAL.Data;
using Turbo.DAL.Dto;
using Turbo.DAL.ViewModel;

namespace Turbo.WEBUI.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService _service;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly string _imgPath = @"img/";

        public ProductsController(IProductService service, IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
            _service = service;
        }


        public async Task<IActionResult> Index()
        {
            var movie = await _service.GetListAsync();
            return View(movie);
        }


        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ProductDto model = new()
            {
                BanTypeCategoryDtos = await _service.GetBanTypeCategoriesAsync(),
                CityCategoryDtos = await _service.GetCityCategoriesAsync(),
                ColorCategoryDtos = await _service.GetColorCategoriesAsync(),
                EngineCapacityCategoryDtos = await _service.GetEngineCapacityCategoriesAsync(),
                FuelTypeCategoryDtos = await _service.GetFuelTypeCategoriesAsync(),
                GearBoxCategoryDtos = await _service.GetGearBoxCategoriesAsync(),
                GearCategoryDtos = await _service.GetGearCategoriesAsync(),
                HowManyOwnerCategoryDtos = await _service.GetHowManyOwnerCategoriesAsync(),
                MarkaCategoryDtos = await _service.GetMarkaCategoriesAsync(),
                MarketAssembledCategoryDtos = await _service.GetMarketAssembledCategoriesAsync(),
                ModelCategoryDtos = await _service.GetModelCategoriesAsync(),
                YearCategoryDtos = await _service.GeTYearCapacityCategoriesAsync(),
                //VehicleSupplyCategoryDtos = await _service.GetVehicleSupplyCategoriesAsync(),
                NumberOfSeatsCategoryDtos = await _service.GeTNumberOfSeatsCategoriesAsync(),
            };
            return View(model);
        }



        [HttpPost]
        public async Task<IActionResult> Create(ProductDto product, List<IFormFile> imageFiles)
        {
            if (ModelState.IsValid)
            {
                List<ProductImages> imagesList = new List<ProductImages>();

                if (imageFiles != null && imageFiles.Count > 0)
                {
                    foreach (var imageFile in imageFiles)
                    {
                        var imagePath = _imgPath + imageFile.FileName;
                        var fullPath = Path.Combine(_webHostEnvironment.WebRootPath, imagePath);
                        using (var stream = new FileStream(fullPath, FileMode.Create))
                        {
                            await imageFile.CopyToAsync(stream);
                            imagesList.Add(new ProductImages { ImagePath = imagePath });
                            product.Image = imagePath;
                        }
                    }
                }

                product.PINPassword = ProductDto.GeneratePIN();

                product.AdvertisementNumber = _service.GenerateUniqueAdvertisementNumber();

                product.ProductImages = imagesList;

                await _service.AddAsync(product);
                return RedirectToAction("Index", "Home");
            }

            return View(product);
        }


        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _service.GetByIdAsync(id.Value);
            if (product == null)
            {
                return NotFound();
            }

            product.BanTypeCategoryDtos = await _service.GetBanTypeCategoriesAsync();
            product.CityCategoryDtos = await _service.GetCityCategoriesAsync();
            product.ColorCategoryDtos = await _service.GetColorCategoriesAsync();
            product.EngineCapacityCategoryDtos = await _service.GetEngineCapacityCategoriesAsync();
            product.FuelTypeCategoryDtos = await _service.GetFuelTypeCategoriesAsync();
            product.GearBoxCategoryDtos = await _service.GetGearBoxCategoriesAsync();
            product.GearCategoryDtos = await _service.GetGearCategoriesAsync();
            product.HowManyOwnerCategoryDtos = await _service.GetHowManyOwnerCategoriesAsync();
            product.MarkaCategoryDtos = await _service.GetMarkaCategoriesAsync();
            product.MarketAssembledCategoryDtos = await _service.GetMarketAssembledCategoriesAsync();
            product.ModelCategoryDtos = await _service.GetModelCategoriesAsync();
            product.YearCategoryDtos = await _service.GeTYearCapacityCategoriesAsync();
            //product.VehicleSupplyCategoryDtos = await _service.GetVehicleSupplyCategoriesAsync();
            product.NumberOfSeatsCategoryDtos = await _service.GeTNumberOfSeatsCategoriesAsync();
            return View(product);

        }


        [HttpPost]
        public async Task<IActionResult> Edit(int id, ProductDto product, List<IFormFile> imageFiles, string inputPIN)
        {
            if (id != product.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                List<ProductImages> imagesList = new List<ProductImages>();

                if (imageFiles != null && imageFiles.Count > 0)
                {
                    foreach (var imageFile in imageFiles)
                    {
                        var imagePath = _imgPath + imageFile.FileName;
                        var fullPath = Path.Combine(_webHostEnvironment.WebRootPath, imagePath);
                        using (var stream = new FileStream(fullPath, FileMode.Create))
                        {
                            await imageFile.CopyToAsync(stream);
                            imagesList.Add(new ProductImages { ImagePath = imagePath });
                            product.Image = imagePath;
                        }
                    }
                }


                product.ProductImages = imagesList;
                _service.Update(product);
                return RedirectToAction("Index", "Home");
            }

            return View(product);
        }


        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _service.GetDetailByIdAsync(id.Value);
            if (product == null)
            {
                return NotFound();
            }

            await _service.IncreaseViewCountAsync(id.Value);

            product.BanTypeCategoryDtos = await _service.GetBanTypeCategoriesAsync();
            product.CityCategoryDtos = await _service.GetCityCategoriesAsync();
            product.ColorCategoryDtos = await _service.GetColorCategoriesAsync();
            product.EngineCapacityCategoryDtos = await _service.GetEngineCapacityCategoriesAsync();
            product.FuelTypeCategoryDtos = await _service.GetFuelTypeCategoriesAsync();
            product.GearBoxCategoryDtos = await _service.GetGearBoxCategoriesAsync();
            product.GearCategoryDtos = await _service.GetGearCategoriesAsync();
            product.HowManyOwnerCategoryDtos = await _service.GetHowManyOwnerCategoriesAsync();
            product.MarkaCategoryDtos = await _service.GetMarkaCategoriesAsync();
            product.MarketAssembledCategoryDtos = await _service.GetMarketAssembledCategoriesAsync();
            product.ModelCategoryDtos = await _service.GetModelCategoriesAsync();
            product.YearCategoryDtos = await _service.GeTYearCapacityCategoriesAsync();
            //product.VehicleSupplyCategoryDtos = await _service.GetVehicleSupplyCategoriesAsync();
            product.NumberOfSeatsCategoryDtos = await _service.GeTNumberOfSeatsCategoriesAsync();


            return View(product);
        }


        public async Task<IActionResult> Delete(int id, string inputPIN)
        {
            var product = await _service.GetByIdAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            _service.Delete(id);
            return RedirectToAction("Index", "Home");
        }


        [HttpPost]
        public async Task<IActionResult> VerifyPIN(int id, string inputPIN)
        {
            var product = await _service.GetByIdAsync(id);

            if (product == null)
                return NotFound();

            if (product.PINPassword == inputPIN)
                return RedirectToAction("Edit", new { id = id });

            TempData["ErrorMsg"] = "Daxil edilən PIN şifrə doğru deyil.";
            return RedirectToAction("Details", new { id = id });
        }


        [HttpPost]
        public async Task<IActionResult> VerifyDeletePIN(int id, string inputPIN)
        {
            var product = await _service.GetByIdAsync(id);

            if (product == null)
                return NotFound();

            if (product.PINPassword == inputPIN)
            {
                _service.Delete(id);
                return RedirectToAction("Index", "Home");
            }

            TempData["ErrorMsg"] = "Daxil edilən PIN şifrə doğru deyil.";
            return RedirectToAction("Details", new { id = id });
        }


    }
}
