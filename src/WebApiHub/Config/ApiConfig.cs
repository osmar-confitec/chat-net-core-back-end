using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiHub.Config
{
    public static class ApiConfig
    {
        public static IServiceCollection AddApiConfig(this IServiceCollection services)
        {
            services.AddCors(options => {
                options.AddPolicy("Development",
                 builder =>
                 {
                     builder
                     .WithOrigins("http://localhost:4200", "https://localhost:9091")
                     .AllowAnyMethod()
                     .AllowAnyHeader()
                     .AllowCredentials()
                     ;
                 });

            });
            
            services.AddSignalR(options=> {

                options.EnableDetailedErrors = true;
            });
            

            services.AddControllersWithViews();
            return services;

        }
    }
}
