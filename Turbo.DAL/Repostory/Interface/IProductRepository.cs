using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turbo.DAL.Data;
using Turbo.DAL.Dto;

namespace Turbo.DAL.Repostory.Interface
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        public Task<List<Product>> GetByCategoryIdAsync(int id);
        public Task<ProductDto> GetDetailByIdAsync(int id);
        Task<List<Product>> GetProductByCategoryIdAsync(int id);
    }
}
