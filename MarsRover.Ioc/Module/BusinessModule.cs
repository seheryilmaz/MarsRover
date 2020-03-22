
using MarsRover.Business;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Ioc.Module
{
    public static class BusinessModule
    {
        public static void RegisterBusinessModule(this IServiceCollection services)
        {
            services.AddScoped<IMarsRoverBusiness, MarsRoverBusiness>();
        }
    }

}
