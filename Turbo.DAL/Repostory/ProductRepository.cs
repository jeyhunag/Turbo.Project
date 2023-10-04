using System;
using System.Collections.Generic;
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
            //IQueryable<Product> movie = _dbContext.Movies.Where(p => p.CountryCategoryId == id &&
            //p.LanguageCategoryId == id && p.GenresCategoryId == id && p.TrendId == id);

            return movie.ToList();

        }

        public Task<ProductDto> GetDetailByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Product>> GetProductByCategoryIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
