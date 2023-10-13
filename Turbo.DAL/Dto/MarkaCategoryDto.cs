using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turbo.DAL.Dto
{
    public class MarkaCategoryDto : BaseDto
    {
        public string Name { get; set; }
        public int ModelCategoryId { get; set; }
        public string? ModelName { get; set; }
        public List<ModelCategoryDto>? ModelCategoryDtos { get; set; }

    }
}
