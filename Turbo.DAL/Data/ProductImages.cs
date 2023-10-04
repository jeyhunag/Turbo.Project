using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turbo.DAL.Data
{
    public class ProductImages:BaseEntity
    {
        public string ImagePath { get; set; }
        public int ProductId { get; set; }
        public Product? Product { get; set; }
    }
}
