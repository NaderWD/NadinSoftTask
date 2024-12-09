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

namespace NadinSoftTask.Infra.Ioc
{
    public class DependencyContainer 
    {
        public static void RegisterServices(IServiceCollection service)
        {
            service.AddScoped<IproductRepository, ProductRepository>();
            service.AddScoped<IProductServices, ProductService>();
        }
    }
}
