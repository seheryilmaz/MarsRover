using MarsRover.Service;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace MarsRover.Ioc.Module
{
    public static class ServiceModule
    {
        public static void RegisterServiceModule(this IServiceCollection services)
        {
            services.AddScoped<IMarsRoverService, MarsRoverService>();
        }
    }
}
