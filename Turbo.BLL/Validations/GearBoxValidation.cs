using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turbo.DAL.Dto;

namespace Turbo.BLL.Validations
{
    public class GearBoxValidation : AbstractValidator<GearBoxCategoryDto>
    {
        public GearBoxValidation()
        {
            RuleFor(d => d.Name).NotNull().WithMessage("Bu sahə boş qala bilməz.");
            RuleFor(d => d.Name).MinimumLength(5).WithMessage("Zəhmət olmasa minimum 5 hərf daxil edin.");
            RuleFor(d => d.Name).MaximumLength(16).WithMessage("Zəhmət olmasa maksimum 16 hərf daxil edin.");
        }
    }
}
