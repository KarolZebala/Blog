using Application.Interfaces;
using Application.Mappings;
using Application.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public static class DependencyInjection
    {
        //W tej klasie rejestracja serwisów z warstwy aplikacji 
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            //AddSingleton zapenia że zostaje tworzona tylko raz na poczatku
            //Ta linijka byłaby aktualna przy jednej klasie w folerze mapping( tej zakomentownej)
            //services.AddSingleton(AutoMapperConfig.Initialize());
            //zamiast tego roimy
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddScoped<IPostService, PostService>();

            


            return services;
        }
    }
}
