
using FoodMania.Infra.IoC.Modules;
using Microsoft.Extensions.DependencyInjection;

namespace FoodMania.Infra.IoC
{
    public static class DependencyInjectionConfiguration
    {
        public static void ConfigureDependencyInjection(this IServiceCollection services)
        {
            services.ConfigureServicesDependency();
            services.ConfigureAppServicesDependency();
            services.ConfigureAutoMapperDependency();
            services.ConfigureRepositoryDependency();
        }
    }
}
