using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turbo.DAL.Data
{
    public class NumberOfSeatsCategory : BaseEntity
    {
        public string Name { get; set; }
        public bool IsNumberOfSeats { get; set; }
        public virtual ICollection<Product>? Products { get; set; }
    }
}
