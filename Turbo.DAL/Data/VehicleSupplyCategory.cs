using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turbo.DAL.Data
{
    public class VehicleSupplyCategory:BaseEntity
    {
        public string Name { get; set; }
        public bool IsChecked { get; set; }
        public virtual ICollection<Product>? Products { get; set; }
    }
}
