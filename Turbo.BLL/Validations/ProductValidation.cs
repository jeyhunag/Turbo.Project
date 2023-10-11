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
        //public ProductValidation()
        //{
        //    RuleFor(d => d.MarkaName).NotNull().WithMessage("Bu sahə boş qala bilməz.");

        //    RuleFor(d => d.FuelName).NotNull().WithMessage("Bu sahə boş qala bilməz.");

        //    RuleFor(d => d.ModelName).NotNull().WithMessage("Bu sahə boş qala bilməz.");

        //    RuleFor(d => d.GearName).NotNull().WithMessage("Bu sahə boş qala bilməz.");

        //    RuleFor(d => d.GBoxnName).NotNull().WithMessage("Bu sahə boş qala bilməz.");

        //    RuleFor(d => d.BanName).NotNull().WithMessage("Bu sahə boş qala bilməz.");

        //    RuleFor(d => d.YearName).NotNull().WithMessage("Bu sahə boş qala bilməz.");

        //    RuleFor(d => d.ColorName).NotNull().WithMessage("Bu sahə boş qala bilməz.");

        //    RuleFor(d => d.EngineName).NotNull().WithMessage("Bu sahə boş qala bilməz.");

        //    RuleFor(d => d.Price).NotNull().WithMessage("Bu sahə boş qala bilməz.");

        //    RuleFor(d => d.EnginePower).NotNull().WithMessage("Bu sahə boş qala bilməz.");

        //    RuleFor(d => d.HowName).NotNull().WithMessage("Bu sahə boş qala bilməz.");

        //    RuleFor(d => d.VINCod).NotNull().WithMessage("Bu sahə boş qala bilməz.");

        //    RuleFor(d => d.Image).NotNull().WithMessage("Bu sahə boş qala bilməz.");

        //    RuleFor(d => d.CityName).NotNull().WithMessage("Bu sahə boş qala bilməz.");

        //    RuleFor(d => d.Phone).NotNull().WithMessage("Bu sahə boş qala bilməz.");

        //    RuleFor(d => d.Name).NotNull().WithMessage("Bu sahə boş qala bilməz.");
        //    RuleFor(d => d.Name).MinimumLength(3).WithMessage("Zəhmət olmasa minimum 3 hərf daxil edin.");
        //    RuleFor(d => d.Name).MaximumLength(16).WithMessage("Zəhmət olmasa maksimum 16 hərf daxil edin.");
        //}
    }
}
