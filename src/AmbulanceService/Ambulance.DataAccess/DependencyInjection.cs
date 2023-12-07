using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ambulance.Application
{
    public static class DependecyInjection
    {
        public static IServiceCollection AddAplication(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddStackExchangeRedisCache(options =>
            {
                options.InstanceName = "Redis";
                options.Configuration = "127.0.0.1:6379";
            });

            return services;
        }
    }
}
