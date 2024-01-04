using MediatR;
using Microsoft.Extensions.DependencyInjection;
using OnlineShop.Application.Contracts.Service;
using OnlineShop.Application.Service;
using System.Reflection;

namespace OnlineShop.Application
{
    public static class ApplicationServicesRegistration
    {
        public static void ConfigureApplicationServices(this IServiceCollection services)
        {
          
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());

            services.AddMemoryCache();

            services.AddTransient<ISaveImage, SaveImage>();



        }
    }
}
