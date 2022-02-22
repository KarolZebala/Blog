using Application.Interfaces;
using Application.Mappings;
using Application.Services;
using Domain.Interfaces;
using Infrastructure.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Installers;

namespace WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //addScoped - pojwde�cze na ka�de �adanie http
            // services.AddScoped<IPostRepository, PostRepository>();
            // services.AddScoped<IPostService, PostService>();

            //AddSingleton zapenia �e zostaje tworzona tylko raz na poczatku
            //services.AddSingleton(AutoMapperConfig.Initialize());

            //services.AddControllers();
            //services.AddSwaggerGen(c =>
            //{
            //   c.EnableAnnotations();
            //  c.SwaggerDoc("v1", new OpenApiInfo { Title = "WebAPI", Version = "v1" });
            //});
            //--------------------------------------------------------------------------------------
            //Powy�sze operacje zrobimy w odzielnych funkcjach
            services.InstallServicesInAsembly(Configuration);
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "WebAPI v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}