﻿using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turbo.BLL.Exceptions;
using Turbo.BLL.Services.Interfaces;
using Turbo.DAL.Data;
using Turbo.DAL.Dto;
using Turbo.DAL.Repostory;
using Turbo.DAL.Repostory.Interface;

namespace Turbo.BLL.Services
{
    public class ProductService : GenericService<ProductDto, Product>, IProductService
    {
        private readonly IMemoryCache _cache;
        private readonly ILogger<ProductService> _logger;


        private readonly IProductRepository productRepository;
        private readonly IGenericRepository<BanTypeCategory> banTypeRepository;
        private readonly IGenericRepository<CityCategory> cityRepository;
        private readonly IGenericRepository<ColorCategory> colorRepository;
        private readonly IGenericRepository<EngineCapacityCategory> engineCapacityRepository;
        private readonly IGenericRepository<GearBoxCategory> gearBoxRepository;
        private readonly IGenericRepository<GearCategory> gearRepository;
        private readonly IGenericRepository<HowManyOwnerCategory> howManyOwnerRepository;
        private readonly IGenericRepository<MarkaCategory> markaRepository;
        private readonly IGenericRepository<MarketAssembledCategory> marketAssembledRepository;
        private readonly IGenericRepository<ModelCategory> modelRepository;
        private readonly IGenericRepository<VehicleSupplyCategory> vehicleSupplyRepository;
        private readonly IGenericRepository<YearCategory> yearRepository;
        private readonly IGenericRepository<FuelTypeCategory> fuelTypeRepository;
        private readonly IGenericRepository<NumberOfSeatsCategory> numberOfSeatsRepository;

        public ProductService(IMemoryCache cache, IGenericRepository<Product> genericRepository, IMapper mapper, ILogger<GenericService<ProductDto, Product>> logger,
            IProductRepository _productRepository,
            IGenericRepository<BanTypeCategory> _BanTypeRepository,
            IGenericRepository<CityCategory> _CityRepository,
            IGenericRepository<ColorCategory> _ColorRepository,
            IGenericRepository<EngineCapacityCategory> _EngineCapacityRepository,
            IGenericRepository<GearBoxCategory> _GearBoxRepository,
            IGenericRepository<GearCategory> _GearRepository,
            IGenericRepository<HowManyOwnerCategory> _HowManyOwnerRepository,
            IGenericRepository<MarkaCategory> _MarkaRepository,
            IGenericRepository<MarketAssembledCategory> _MarketAssembledRepository,
            IGenericRepository<ModelCategory> _ModelRepository,
            IGenericRepository<VehicleSupplyCategory> _VehicleSupplyRepository,
            IGenericRepository<YearCategory> _YearRepository,
            IGenericRepository<FuelTypeCategory> fuelTypeRepository,
            IGenericRepository<NumberOfSeatsCategory> _numberOfSeatsRepository) : base(genericRepository, mapper, logger)
        {
            this.fuelTypeRepository = fuelTypeRepository;
            this.numberOfSeatsRepository = _numberOfSeatsRepository;
            this.productRepository = _productRepository;
            this.banTypeRepository = _BanTypeRepository;
            this.cityRepository = _CityRepository;
            this.colorRepository = _ColorRepository;
            this.engineCapacityRepository = _EngineCapacityRepository;
            this.gearBoxRepository = _GearBoxRepository;
            this.gearRepository = _GearRepository;
            this.howManyOwnerRepository = _HowManyOwnerRepository;
            this.markaRepository = _MarkaRepository;
            this.marketAssembledRepository = _MarketAssembledRepository;
            this.modelRepository = _ModelRepository;
            this.vehicleSupplyRepository = _VehicleSupplyRepository;
            this.yearRepository = _YearRepository;
            this._cache = cache;
        }



        public async Task<List<BanTypeCategoryDto>> GetBanTypeCategoriesAsync()
        {
            try
            {
                var Categories = await banTypeRepository.GetListAsync();
                var categoryDtos = _mapper.Map<List<BanTypeCategoryDto>>(Categories);
                return categoryDtos;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Xəta baş verdi: Message: {ex.Message} | StackTrace: {ex.StackTrace}");
                throw new BllGetException("Ban növü kateqoriyalarını almağa çalışarkən xəta yarandı.");
            }
        }

        public async Task<List<CityCategoryDto>> GetCityCategoriesAsync()
        {

            try
            {
                var Categories = await cityRepository.GetListAsync();
                var categoryDtos = _mapper.Map<List<CityCategoryDto>>(Categories);
                return categoryDtos;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Xəta baş verdi: Message: {ex.Message} | StackTrace: {ex.StackTrace}");
                throw new BllGetException("Şəhər kateqoriyalarını almağa çalışarkən xəta yarandı.");
            }
        }

        public async Task<List<ColorCategoryDto>> GetColorCategoriesAsync()
        {
            try
            {
                var Categories = await colorRepository.GetListAsync();
                var categoryDtos = _mapper.Map<List<ColorCategoryDto>>(Categories);
                return categoryDtos;

            }
            catch (Exception ex)
            {
                _logger.LogError($"Xəta baş verdi: Message: {ex.Message} | StackTrace: {ex.StackTrace}");
                throw new BllGetException("Rəng kateqoriyalarını almağa çalışarkən xəta yarandı.");
            }
        }

        public async Task<ProductDto> GetDetailByIdAsync(int id)
        {
            var cacheKey = $"Product_{id}";
            if (!_cache.TryGetValue(cacheKey, out ProductDto productDto))
            {
                var product = await productRepository.GetDetailByIdAsync(id);
                productDto = _mapper.Map<ProductDto>(product);

                var cacheEntryOptions = new MemoryCacheEntryOptions
                {
                    AbsoluteExpirationRelativeToNow = TimeSpan.FromHours(12),
                    Priority = CacheItemPriority.Normal
                };

                _cache.Set(cacheKey, productDto, cacheEntryOptions);
            }

            return productDto;
        }


        public async Task<List<EngineCapacityCategoryDto>> GetEngineCapacityCategoriesAsync()
        {

            try
            {
                var Categories = await engineCapacityRepository.GetListAsync();
                var categoryDtos = _mapper.Map<List<EngineCapacityCategoryDto>>(Categories);
                return categoryDtos;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Xəta baş verdi: Message: {ex.Message} | StackTrace: {ex.StackTrace}");
                throw new BllGetException("Mühərrik hecimi kateqoriyalarını almağa çalışarkən xəta yarandı.");
            }
        }

        public async Task<List<FuelTypeCategoryDto>> GetFuelTypeCategoriesAsync()
        {
            try
            {
                var Categories = await fuelTypeRepository.GetListAsync();
                var categoryDtos = _mapper.Map<List<FuelTypeCategoryDto>>(Categories);
                return categoryDtos;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Xəta baş verdi: Message: {ex.Message} | StackTrace: {ex.StackTrace}");
                throw new BllGetException("Yanacaq növü kateqoriyalarını almağa çalışarkən xəta yarandı.");
            }
        }

        public async Task<List<GearBoxCategoryDto>> GetGearBoxCategoriesAsync()
        {       
            try
            {
                var Categories = await gearBoxRepository.GetListAsync();
                var categoryDtos = _mapper.Map<List<GearBoxCategoryDto>>(Categories);
                return categoryDtos;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Xəta baş verdi: Message: {ex.Message} | StackTrace: {ex.StackTrace}");
                throw new BllGetException("Sürət qutusu kateqoriyalarını almağa çalışarkən xəta yarandı.");
            }
        }

        public async Task<List<GearCategoryDto>> GetGearCategoriesAsync()
        {
            try
            {
                var Categories = await gearRepository.GetListAsync();
                var categoryDtos = _mapper.Map<List<GearCategoryDto>>(Categories);
                return categoryDtos;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Xəta baş verdi: Message: {ex.Message} | StackTrace: {ex.StackTrace}");
                throw new BllGetException("Sürət kateqoriyalarını almağa çalışarkən xəta yarandı.");
            }
        }

        public async Task<List<HowManyOwnerCategoryDto>> GetHowManyOwnerCategoriesAsync()
        {
            try
            {
                var Categories = await howManyOwnerRepository.GetListAsync();
                var categoryDtos = _mapper.Map<List<HowManyOwnerCategoryDto>>(Categories);
                return categoryDtos;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Xəta baş verdi: Message: {ex.Message} | StackTrace: {ex.StackTrace}");
                throw new BllGetException("Neçənci sahibisiniz kateqoriyalarını almağa çalışarkən xəta yarandı.");
            }
        }

        public async Task<List<MarkaCategoryDto>> GetMarkaCategoriesAsync()
        {
            try
            {
                var Categories = await markaRepository.GetListAsync();
                var categoryDtos = _mapper.Map<List<MarkaCategoryDto>>(Categories);
                return categoryDtos;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Xəta baş verdi: Message: {ex.Message} | StackTrace: {ex.StackTrace}");
                throw new BllGetException("Marka kateqoriyalarını almağa çalışarkən xəta yarandı.");
            }
        }

        public async Task<List<MarketAssembledCategoryDto>> GetMarketAssembledCategoriesAsync()
        {
            try
            {
                var Categories = await marketAssembledRepository.GetListAsync();
                var categoryDtos = _mapper.Map<List<MarketAssembledCategoryDto>>(Categories);
                return categoryDtos;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Xəta baş verdi: Message: {ex.Message} | StackTrace: {ex.StackTrace}");
                throw new BllGetException("Hansı bazar üçün kateqoriyalarını almağa çalışarkən xəta yarandı.");
            }
        }

        public async Task<List<ModelCategoryDto>> GetModelCategoriesAsync()
        {
            try
            {
                var Categories = await modelRepository.GetListAsync();
                var categoryDtos = _mapper.Map<List<ModelCategoryDto>>(Categories);
                return categoryDtos;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Xəta baş verdi: Message: {ex.Message} | StackTrace: {ex.StackTrace}");
                throw new BllGetException("Model kateqoriyalarını almağa çalışarkən xəta yarandı.");
            }
        }

        public async Task<List<ProductDto>> GetByCategoryIdAsync(int id)
        {
            try
            {
                var product = await productRepository.GetByCategoryIdAsync(id);
                var productDtos = _mapper.Map<List<ProductDto>>(product);

                return productDtos;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Xəta baş verdi: Message: {ex.Message} | StackTrace: {ex.StackTrace}");
                throw new BllGetException("Kateqoriyaları almağa çalışarkən xəta yarandı.");
            }
        }

        public async Task<List<VehicleSupplyCategoryDto>> GetVehicleSupplyCategoriesAsync()
        {
            try
            {
                var Categories = await vehicleSupplyRepository.GetListAsync();
                var categoryDtos = _mapper.Map<List<VehicleSupplyCategoryDto>>(Categories);
                return categoryDtos;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Xəta baş verdi: Message: {ex.Message} | StackTrace: {ex.StackTrace}");
                throw new BllGetException("vehicle supply kateqoriyaları almağa çalışarkən xəta yarandı.");
            }
        }

        public async Task<List<YearCategoryDto>> GeTYearCapacityCategoriesAsync()
        {
            try
            {
                var Categories = await yearRepository.GetListAsync();
                var categoryDtos = _mapper.Map<List<YearCategoryDto>>(Categories);
                return categoryDtos;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Xəta baş verdi: Message: {ex.Message} | StackTrace: {ex.StackTrace}");
                throw new BllGetException("il kateqoriyaları almağa çalışarkən xəta yarandı.");
            }
        }

        public async Task<List<NumberOfSeatsCategoryDto>> GeTNumberOfSeatsCategoriesAsync()
        {
            try
            {
                var Categories = await numberOfSeatsRepository.GetListAsync();
                var categoryDtos = _mapper.Map<List<NumberOfSeatsCategoryDto>>(Categories);
                return categoryDtos;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Xəta baş verdi: Message: {ex.Message} | StackTrace: {ex.StackTrace}");
                throw new BllGetException("Oturacaqların sayı kateqoriyaları almağa çalışarkən xəta yarandı.");
            }
        }

        public string GenerateUniqueAdvertisementNumber()
        {
            string number;
            bool numberExists;

            do
            {
                number = new Random().Next(10000, 100000).ToString();
                numberExists = productRepository.CheckIfAdvertisementNumberExists(number);
            } while (numberExists);

            return number;
        }
        public async Task IncreaseViewCountAsync(int productId)
        {
            var product = await productRepository.GetProductWithViewCountAsync(productId);
            if (product != null)
            {
                product.ViewCount++;
                await productRepository.UpdateProductAsync(product);
            }
        }
        public async Task MakeVipAsync(int productId)
        {
            var product = await productRepository.GetProductWithViewCountAsync(productId);
            if (product == null)
            {
                throw new Exception("Product not found.");
            }

            product.IsVip = true;
            await productRepository.UpdateProductAsync(product);
        }

        public async Task MakePremiumAsync(int productId)
        {
            var product = await productRepository.GetProductWithViewCountAsync(productId);
            if (product == null)
            {
                throw new Exception("Product not found.");
            }

            product.IsPremium = true;
            await productRepository.UpdateProductAsync(product);
        }

        public async Task<int> GetTodayProductCountAsync()
        {
            return await productRepository.GetProductCountByDateAsync(DateTime.Now);
        }

    }
}