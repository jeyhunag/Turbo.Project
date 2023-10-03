using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turbo.DAL.Dto;

namespace Turbo.BLL.Validations
{
    public class YearValidation : AbstractValidator<YearCategoryDto>
    {
        public YearValidation()
        {
            RuleFor(d => d.Name).NotNull().WithMessage("Bu sahə boş qala bilməz.");
            RuleFor(d => d.Name).MinimumLength(4).WithMessage("Zəhmət olmasa minimum 4 hərf daxil edin.");
            RuleFor(d => d.Name).MaximumLength(4).WithMessage("Zəhmət olmasa maksimum 4 hərf daxil edin.");
        }
    }
}
