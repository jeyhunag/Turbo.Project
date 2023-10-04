﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turbo.DAL.Data
{
    public class FuelTypeCategory:BaseEntity
    {
        public string Name { get; set; }
        public virtual ICollection<Product>? Products { get; set; }
    }
}