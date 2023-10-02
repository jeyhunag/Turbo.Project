using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turbo.DAL.Dto
{
    public class ProductDto: BaseDto
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public int Phone { get; set; }
        public string City { get; set; }
        public string BanType { get; set; }
        public string Color { get; set; }
        public string Engine { get; set; }
        public string March { get; set; }
        public string GearBox { get; set; }
        public string Gear { get; set; }
        public string New { get; set; }
        public string TheSituation { get; set; }
        public string MarketAssembled { get; set; }
        public string Description { get; set; }
        public string ExtrasProduct { get; set; }
        public char NumberOfSeats { get; set; }
        public int AdNumber { get; set; }
        public string PINPassword { get; set; }
        public float Price { get; set; }
    }
}
