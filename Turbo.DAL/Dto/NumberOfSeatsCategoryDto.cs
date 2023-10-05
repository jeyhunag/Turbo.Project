using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turbo.DAL.Dto
{
    public class NumberOfSeatsCategoryDto:BaseDto
    {
        public string Name { get; set; }
        public bool IsNumberOfSeats { get; set; }
    }
}
