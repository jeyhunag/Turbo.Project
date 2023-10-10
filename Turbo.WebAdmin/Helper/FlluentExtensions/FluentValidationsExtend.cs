using FluentValidation.AspNetCore;
using FluentValidation;
using Turbo.BLL.Validations;

namespace Turbo.WebAdmin.Helper.FlluentExtensions
{
    public static class FluentValidationsExtend
    {
        public static IServiceCollection AddFluentServices(this IServiceCollection services)
        {
            services.AddFluentValidationAutoValidation();
            services.AddFluentValidationClientsideAdapters();

            var validatorTypes = new[]
            {
                typeof(CityValidation),
               typeof(BanTypeValidation),
               typeof(ColorValidation),
               typeof(EngineCapacityValidation),
               typeof(FuelTypeValidation),
               typeof(GearBoxValidation),
               typeof(GearValidation),
               typeof(HowManyOwnerValidation),
               typeof(MarkaValidation),
               typeof(MarketAssembledValidation),
               typeof(ModelValidation),
               typeof(VehicleSupplyValidation),
                 typeof(YearValidation),
            };

            foreach (var type in validatorTypes)
            {
                services.AddValidatorsFromAssembly(type.Assembly);
            }

            return services;
        }

    }
}
