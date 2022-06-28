using AutoMapper;
using FoodMania.Application.Orders.Mappers;
using Microsoft.Extensions.DependencyInjection;

namespace FoodMania.Infra.IoC.Modules
{
    public static class AutoMapperDependencyModule
    {
        public static void ConfigureAutoMapperDependency(this IServiceCollection services)
        {
            var mapper = CreateMapping();

            services.AddSingleton(mapper);
        }

        private static IMapper CreateMapping()
        {
            var mapper = new MapperConfiguration(m =>
            {
                m.AddProfile(new OrderRequestToEntityProfile());
            });

            return mapper.CreateMapper();
        }
    }
}
