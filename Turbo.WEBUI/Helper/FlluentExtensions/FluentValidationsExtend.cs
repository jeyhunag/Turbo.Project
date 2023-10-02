﻿using FluentValidation.AspNetCore;
using FluentValidation;

namespace Turbo.WEBUI.Helper.FlluentExtensions
{
    public static class FluentValidationsExtend
    {
        public static IServiceCollection AddFluentServices(this IServiceCollection services)
        {
            services.AddFluentValidationAutoValidation();
            services.AddFluentValidationClientsideAdapters();
            //services.AddValidatorsFromAssembly(typeof(CountryCategoryValidation).Assembly);
            //services.AddValidatorsFromAssembly(typeof(GenresCategoryValidator).Assembly);
            //services.AddValidatorsFromAssembly(typeof(LanguageCategoryValidation).Assembly);
            //services.AddValidatorsFromAssembly(typeof(AboutValidation).Assembly);
            //services.AddValidatorsFromAssembly(typeof(MovieValidation).Assembly);

            return services;
        }
    }
}
