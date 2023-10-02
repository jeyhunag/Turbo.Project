using Microsoft.AspNetCore.Identity;
using Turbo.DAL.Data;
using Turbo.DAL.DbContext;

namespace Turbo.WEBUI.Helper.IdentityExtensions
{
    //public static IServiceCollection AddIdentityServices(this IServiceCollection services)
    //{
    //    services.AddIdentity<AppUser, AppRole>(opts =>
    //    {

    //        opts.User.RequireUniqueEmail = true;
    //        opts.User.AllowedUserNameCharacters = "abcçdefgğhıijklmnoöpqrsştuüvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._";

    //        opts.Password.RequiredLength = 4;
    //        opts.Password.RequireNonAlphanumeric = false;
    //        opts.Password.RequireLowercase = false;
    //        opts.Password.RequireUppercase = false;
    //        opts.Password.RequireDigit = false;

    //    }).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();


    //    return services;
    //}
}
