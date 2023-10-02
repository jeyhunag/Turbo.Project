using Serilog.Events;
using Serilog;

namespace Turbo.WebAdmin.Helper.LogExtensions
{
    public static class ImportandLogExtend
    {
        public static IServiceCollection AddImpotandLogServices(this IServiceCollection services)
        {
            Log.Logger = new LoggerConfiguration()
               .MinimumLevel.Information()
               .WriteTo.File(path: "Log/debug.txt", rollingInterval: RollingInterval.Day)
               .WriteTo.File(path: "Log/info.txt", restrictedToMinimumLevel: LogEventLevel.Information, rollingInterval: RollingInterval.Day)
               .WriteTo.File(path: "Log/error.txt", restrictedToMinimumLevel: LogEventLevel.Error, rollingInterval: RollingInterval.Day)
               .WriteTo.Console(restrictedToMinimumLevel: LogEventLevel.Warning)
               .CreateLogger();

            return services;
        }
    }
}
