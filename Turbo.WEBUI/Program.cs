using Microsoft.EntityFrameworkCore;
using System;
using Turbo.BLL.Mapping;
using Turbo.BLL.Services.Interfaces;
using Turbo.BLL.Services;
using Turbo.DAL.DbContext;
using Turbo.WEBUI.Helper.FlluentExtensions;
using Turbo.WEBUI.Helper.LogExtensions;
using Turbo.WEBUI.Helper.ServicesExtensions;
using Serilog;
using Turbo.WEBUI.Helper.IdentityExtensions;
using Turbo.WEBUI.Provider;

namespace Turbo.WEBUI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
           
            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnectionString"));
                options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            });

            builder.Host.UseSerilog();

            //Boolean 
            builder.Services.AddControllersWithViews(cfg =>
            {
                cfg.ModelBinderProviders.Insert(0, new BooleanBinderProvider());
            });

            builder.Services.AddMemoryCache();

            //Fluent Validations Extension
            builder.Services.AddFluentServices();

            //Identity AppRole,AppUser Security 
            // builder.Services.AddIdentityServices();


            //Importand Logger Extensions
            builder.Services.AddImpotandLogServices();

            //Mapping
            builder.Services.AddAutoMapper(typeof(CustomMapping));

            //Generic Services Extensions
            builder.Services.AddServices();

            //Generic Repostory Extensions
            builder.Services.AddRepositories();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}