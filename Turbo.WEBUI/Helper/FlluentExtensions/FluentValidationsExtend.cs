using FluentValidation.AspNetCore;
using FluentValidation;
using Turbo.BLL.Validations;

namespace Turbo.WEBUI.Helper.FlluentExtensions
{
    public static class FluentValidationsExtend
    {
        public static IServiceCollection AddFluentServices(this IServiceCollection services)
        {
            services.AddFluentValidationAutoValidation();
            services.AddFluentValidationClientsideAdapters();

            var validatorTypes = new[]
            {
                 typeof(ProductValidation),
            };

            foreach (var type in validatorTypes)
            {
                services.AddValidatorsFromAssembly(type.Assembly);
            }

            return services;
        }
    }
}
