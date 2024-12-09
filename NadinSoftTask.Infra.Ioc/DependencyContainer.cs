using Microsoft.Extensions.DependencyInjection;
using NadinSoftTask.Domain.Interfaces;
using NadinSoftTask.Infra.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NadinSoftTask.Application.Interfaces;
using NadinSoftTask.Application.Services;
using AutoMapper;
using NadinSoftTask.Application.Profiles;

namespace NadinSoftTask.Infra.Ioc
{
    public class DependencyContainer 
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IproductRepository, ProductRepository>();
            services.AddScoped<IProductServices, ProductService>();

            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfiles());
            });

            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}
