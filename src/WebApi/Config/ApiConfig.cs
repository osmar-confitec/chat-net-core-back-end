using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WebApi.Config
{
    public static class ApiConfig
    {
        public static IServiceCollection AddApiConfig(this IServiceCollection services)
        {

            services.AddApiVersioning(options =>
            {
                options.AssumeDefaultVersionWhenUnspecified = true;
                options.DefaultApiVersion = new ApiVersion(1, 0);
                options.ReportApiVersions = true;
            });

            services.AddVersionedApiExplorer(options =>
            {
                options.GroupNameFormat = "'v'VVV";
                options.SubstituteApiVersionInUrl = true;
            });

            services.Configure<ApiBehaviorOptions>(options =>
            {
                options.SuppressModelStateInvalidFilter = true;

            });

            services.AddControllersWithViews()

        .AddJsonOptions(options =>
        {
            options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
                   // options.JsonSerializerOptions.IgnoreNullValues = true;
               });
            ;

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

     


            services.AddSignalR(options => {

                options.EnableDetailedErrors = true;

            });

          

            return services;

        }
    }
}
