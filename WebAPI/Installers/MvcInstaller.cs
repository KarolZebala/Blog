using Application;
using Application.Interfaces;
using Application.Mappings;
using Application.Services;
using Domain.Interfaces;
using Infrastructure;
using Infrastructure.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Installers
{
    //w klasach dziedziczących po IInstalers implementujemy wstrzykiwanie zależności 
    // tutaj rejestracja z projektów application i Infrastructers
    public class MvcInstaller : IInstallers
    {

        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {

            //Rejestracja serwisów z warstwy aplikacji w odzielnej klasie w projekcie Application 
            services.AddApplication();
            //Rejestracja serwisów z warstwy Infrastructers w odzielnej klasie w projekcie Infrastructers 
            services.AddInfrastructers();


            services.AddControllers();
        }
    }
}
