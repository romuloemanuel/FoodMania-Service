using FoodMania.Domain.Orders.Interfaces;
using FoodMania.Infra.Data;
using Microsoft.Extensions.DependencyInjection;

namespace FoodMania.Infra.IoC.Modules
{
    public static class RepositoryDepdendencyModule
    {
        public static void ConfigureRepositoryDependency(this IServiceCollection services)
        {
            services.AddScoped<IOrderRepository, OrderRepository>();
        }
    }
}
