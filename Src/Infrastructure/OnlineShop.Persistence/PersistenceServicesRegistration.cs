using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OnlineShop.Application.Contracts.Persistence;
using OnlineShop.Persistence.Context;
using OnlineShop.Persistence.Repositories;

namespace OnlineShop.Persistence
{
    public static class PersistenceServicesRegistration
    {
        public static IServiceCollection ConfigurePersistenceServices(this IServiceCollection services,
            IConfiguration configuration)
        {

            services.AddDbContext<OnlineShopDbContext>(options =>
            {
                options.UseSqlServer(configuration
                    .GetConnectionString("SqlSever"));
            });

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IColorRepository, ColorRepository>();
            services.AddScoped<ISizeRepository, SizeRepository>();
            services.AddScoped<IAddOnRepository, AddOnRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IProductAddOnRepository, ProductAddOnRepository>();
            services.AddScoped<IProductSizeRepository, ProductSizeRepository>();
            services.AddScoped<IProductColorRepository, ProductColorRepository>();



            return services;
        }
    }
}
