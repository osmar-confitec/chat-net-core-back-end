using App.AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Config
{
    public static class AutoMapperConfig
    {

        public static void AddAutoMapperConfiguration(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddAutoMapper(typeof(DomainToResponseMappingProfile),
                                   typeof(RequestToDomainMappingProfile),
                                   typeof(DomainToDtoMappingProfile)
                                   //
                                   );
        }
    }
}
