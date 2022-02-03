using App.Interfaces;
using App.Services;
using CrossCutting;
using Data.Repository;
using Data.Uow;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SlnDom.Domain.Interfaces;
using SlnDom.Domain.Repository;
using SlnDom.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Ioc
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services,
                                                      IConfiguration configuration,
                                                      IHostEnvironment hostEnvironment
                                                      )
        {


            services.AddScoped<LNotifications>();


            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ICustomerServices, CustomerServices>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<ICustomerApplication, CustomerApplication>();
            services.AddScoped<IUserRepository, UserRepository>();

            services.AddScoped<IUserApplication, UserApplication>();

            services.AddScoped<IUserServices, UserServices>();

            //

            //






        }

    }
}
