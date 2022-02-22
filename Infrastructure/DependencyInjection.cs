using Domain.Interfaces;
using Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        //W tej klasie rejestracja serwisów z projektu Infrastructers
        public static IServiceCollection AddInfrastructers(this IServiceCollection services)
        {

            //addScoped - pojwdeńcze na każde żadanie http
            services.AddScoped<IPostRepository, PostRepository>();

            return services;
        }
       
    }
}
