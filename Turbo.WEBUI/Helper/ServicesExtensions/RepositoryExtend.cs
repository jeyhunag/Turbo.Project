using Turbo.DAL.Repostory;
using Turbo.DAL.Repostory.Interface;

namespace Turbo.WEBUI.Helper.ServicesExtensions
{
    public static class RepositoryExtend
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            return services;

        }
    }
}
