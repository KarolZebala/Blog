using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Installers
{
    //W tym interfejsie będzie wstrzykiwanie zależności które normalnie są w klasie Startup, ale jak będzie tego za dużo 
    //to szybko może przestać być czytelne dlatego używamy tego interfejst=u
    
    public interface IInstallers
    {
        
        void InstallServices(IServiceCollection services, IConfiguration configuration);
    }
}
