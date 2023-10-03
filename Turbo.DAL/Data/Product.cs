using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turbo.DAL.Data
{
    public class Product:BaseEntity
    {

        public int Phone { get; set; }
        public string Img { get; set; }

        public string March { get; set; }

        public string New { get; set; }
        public string TheSituation { get; set; }
        public string Description { get; set; }
        public string ExtrasProduct { get; set; }
        public char NumberOfSeats { get; set; }
        public int AdNumber { get; set; }
        public string PINPassword { get; set; }
        public float Price { get; set; }
    }
}
