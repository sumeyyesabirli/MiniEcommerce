using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MiniEcommerce.Business
{
    public static class ServiceRegister
    {
        public static IServiceCollection AddBusinessRegister(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly()
                       .ExportedTypes
                       .Where(consumer => consumer.FullName != null && consumer.FullName.Contains("Handler") && consumer.IsClass)
                       .ToArray();
            services.AddMediatR(assembly);
            return services;
        }
    }
}
