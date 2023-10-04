using Turbo.BLL.Services;
using Turbo.BLL.Services.Interfaces;

namespace Turbo.WEBUI.Helper.ServicesExtensions
{
    public static class ServiceExtend
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }
            services.AddScoped(typeof(IGenericService<,>), typeof(GenericService<,>));
            services.AddScoped<IProductService, ProductService>();
            return services;

        }
    }
}
