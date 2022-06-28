using FoodMania.Application.Orders.Interfaces;
using FoodMania.Application.Orders.Services;
using Microsoft.Extensions.DependencyInjection;

namespace FoodMania.Infra.IoC.Modules
{
    public static class ApplicationServicesDependencyModule
    {
        public static void ConfigureAppServicesDependency(this IServiceCollection services)
        {
            services.AddScoped<IOrderAppService, OrderAppService>();
        }
    }
}
