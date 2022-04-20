using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using MiniEcommerce.DataAccess.Context;
using MiniEcommerce.DataAccess.Repositories.Abstract;
using MiniEcommerce.DataAccess.Repositories.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniEcommerce.DataAccess
{
    public static class ServiceRegister
    {
        public static IServiceCollection AddDataAccessRegister(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<EfDbContext>(x =>
            {
                x.UseNpgsql(configuration.GetConnectionString("MiniEcommerceContext"));
            });
            services.TryAddScoped<DbContext, EfDbContext>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();

            return services;
        }
    }
}
