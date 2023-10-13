using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turbo.DAL.Dto;

namespace Turbo.BLL.Validations
{
    public class ProductValidation : AbstractValidator<ProductDto>
    {
        public ProductValidation()
        {


            RuleFor(d => d.Price).NotNull().WithMessage("Bu sahə boş qala bilməz.").NotEmpty().WithMessage("Bu sahə boş qala bilməz."); 

            RuleFor(d => d.March).NotNull().WithMessage("Bu sahə boş qala bilməz.").NotEmpty().WithMessage("Bu sahə boş qala bilməz.");

            RuleFor(d => d.EnginePower).NotNull().WithMessage("Bu sahə boş qala bilməz.").NotEmpty().WithMessage("Bu sahə boş qala bilməz.");


            RuleFor(d => d.VINCod).NotNull().WithMessage("Bu sahə boş qala bilməz.").NotEmpty().WithMessage("Bu sahə boş qala bilməz.");

            RuleFor(d => d.Image).NotNull().WithMessage("Bu sahə boş qala bilməz.").NotEmpty().WithMessage("Bu sahə boş qala bilməz.");

            RuleFor(d => d.Phone).NotNull().WithMessage("Bu sahə boş qala bilməz.").NotEmpty().WithMessage("Bu sahə boş qala bilməz.");

            RuleFor(d => d.Name).NotNull().WithMessage("Bu sahə boş qala bilməz.").NotEmpty().WithMessage("Bu sahə boş qala bilməz.");
            RuleFor(d => d.Name).MinimumLength(3).WithMessage("Zəhmət olmasa minimum 3 hərf daxil edin.");
            RuleFor(d => d.Name).MaximumLength(16).WithMessage("Zəhmət olmasa maksimum 16 hərf daxil edin.");
        }
    }
}
