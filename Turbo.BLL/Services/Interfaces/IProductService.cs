using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turbo.DAL.Data;
using Turbo.DAL.Dto;

namespace Turbo.BLL.Services.Interfaces
{
    public interface IProductService : IGenericService<ProductDto, Product>
    {
        public Task<List<BanTypeCategoryDto>> GetBanTypeCategoriesAsync();
        public Task<List<CityCategoryDto>> GetCityCategoriesAsync();
        public Task<List<ColorCategoryDto>> GetColorCategoriesAsync();
        public Task<List<EngineCapacityCategoryDto>> GetEngineCapacityCategoriesAsync();
        public Task<List<FuelTypeCategoryDto>> GetFuelTypeCategoriesAsync();
        public Task<List<GearBoxCategoryDto>> GetGearBoxCategoriesAsync();
        public Task<List<GearCategoryDto>> GetGearCategoriesAsync();
        public Task<List<HowManyOwnerCategoryDto>> GetHowManyOwnerCategoriesAsync();
        public Task<List<MarkaCategoryDto>> GetMarkaCategoriesAsync();
        public Task<List<MarketAssembledCategoryDto>> GetMarketAssembledCategoriesAsync();
        public Task<List<ModelCategoryDto>> GetModelCategoriesAsync();
        public Task<List<VehicleSupplyCategoryDto>> GetVehicleSupplyCategoriesAsync();
        public Task<List<YearCategoryDto>> GeTYearCapacityCategoriesAsync();
        public Task<List<NumberOfSeatsCategoryDto>> GeTNumberOfSeatsCategoriesAsync();
        public Task<List<ProductDto>> GetByCategoryIdAsync(int id);
        public Task<ProductDto> GetDetailByIdAsync(int id);
        public string GenerateUniqueAdvertisementNumber();
        public Task IncreaseViewCountAsync(int productId);
        public Task MakeVipAsync(int productId);
        Task MakePremiumAsync(int productId);
        Task<int> GetTodayProductCountAsync();

    }
}
