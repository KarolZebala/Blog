using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Installers
{
    
    public static class InstallerExtensions 
    {
        //Metoda wyszukuje w projekcie wsystkie klasy z instalatorami i utworzenie ich instancji i wywołanie metody 
        //InstallServices z odpowiednim argumentem
        public static void InstallServicesInAsembly(this IServiceCollection services, IConfiguration configuration)
        {
            var installers = typeof(Startup).Assembly.ExportedTypes.Where(x =>
                 typeof(IInstallers).IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract).Select(Activator.CreateInstance).Cast<IInstallers>().ToList();

            installers.ForEach(installer => installer.InstallServices(services, configuration));

        }
    }
}
