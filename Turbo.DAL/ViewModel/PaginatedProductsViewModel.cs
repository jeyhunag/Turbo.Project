using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turbo.DAL.Data;
using Turbo.DAL.Dto;

namespace Turbo.DAL.ViewModel
{
    public class PaginatedProductsViewModel
    {
        public List<ProductDto> Products { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public FilterViewModel Filter { get; set; }
    }

}
