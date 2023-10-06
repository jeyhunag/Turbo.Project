using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turbo.DAL.Data;
using Turbo.DAL.DbContext;
using Turbo.DAL.Dto;
using Turbo.DAL.Repostory.Interface;

namespace Turbo.DAL.Repostory
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<List<Product>> GetByCategoryIdAsync(int id)
        {
            IQueryable<Product> product = _dbContext.Products.Where(p => p.BanTypeCategoryId == id &&
            p.CityCategoryId == id && p.ColorCategoryId == id && p.EngineCapacityCategoryId == id
            && p.FuelTypeCategoryId == id && p.GearBoxCategoryId == id && p.GearCategoryId == id
             && p.HowManyOwnerCategoryId == id && p.MarkaCategoryId == id && p.MarketAssembledCategoryId == id
             && p.ModelCategoryId == id && p.VehicleSupplyCategoryId == id && p.YearCategoryId == id
             && p.NumberOfSeatsCategoryId == id);

            return await product.ToListAsync();

        }

        public async Task<ProductDto> GetDetailByIdAsync(int id)
        {

            var productDto = await (from m in _dbContext.Products
                                    join gc in _dbContext.BanTypeCategories on m.BanTypeCategoryId equals gc.Id
                                    join c in _dbContext.CityCategories on m.CityCategoryId equals c.Id
                                    join l in _dbContext.ColorCategories on m.ColorCategoryId equals l.Id
                                    join a in _dbContext.EngineCapacities on m.EngineCapacityCategoryId equals a.Id
                                    join b in _dbContext.FuelTypeCategories on m.FuelTypeCategoryId equals b.Id
                                    join q in _dbContext.GearBoxCategories on m.GearBoxCategoryId equals q.Id
                                    join z in _dbContext.GearCategories on m.GearCategoryId equals z.Id
                                    join x in _dbContext.HowManies on m.HowManyOwnerCategoryId equals x.Id
                                    join r in _dbContext.MarkaCategories on m.MarkaCategoryId equals r.Id
                                    join n in _dbContext.MarketAssembleds on m.MarketAssembledCategoryId equals n.Id
                                    join k in _dbContext.ModelCategories on m.ModelCategoryId equals k.Id
                                    join o in _dbContext.VehicleSupplyCategories on m.VehicleSupplyCategoryId equals o.Id
                                    join p in _dbContext.YearCategories on m.YearCategoryId equals p.Id
                                    join s in _dbContext.NumberOfSeatsCategories on m.NumberOfSeatsCategoryId equals s.Id
                                    where m.Id == id
                                    select new ProductDto
                                    {
                                        Id = m.Id,
                                        Name = m.Name,
                                        ProductImages = m.ProductImages,
                                        Phone = m.Phone,
                                        March = m.March,
                                        Price = m.Price,
                                        EnginePower = m.EnginePower,
                                        Description = m.Description,
                                        Valyuta = m.Valyuta,
                                        VINCod = m.VINCod,
                                        Email = m.Email,
                                        New = m.New,
                                        PINPassword = m.PINPassword,
                                        AdvertisementNumber = m.AdvertisementNumber,
                                        BanName = gc.Name,
                                        CityName = c.Name,
                                        ColorName = l.Name,
                                        EngineName = a.Name,
                                        FuelName = b.Name,
                                        GBoxnName = q.Name,
                                        GearName = z.Name,
                                        HowName = x.Name,
                                        MarkaName = r.Name,
                                        MarketName = n.Name,
                                        ModelName = k.Name,
                                        VehicleName = o.Name,
                                        YearName = p.Name,
                                        NumberOfSeatsName = s.Name,

                                    }).FirstOrDefaultAsync();

            return productDto;
        }

    }
}
