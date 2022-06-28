using MassTransit;
using Microsoft.Extensions.DependencyInjection;

namespace FoodMania.Infra.Extensions
{
    public static class MasstransitExtension
    {
        public static void AddMasstransitConfiguration(this IServiceCollection services)
        {
            services.AddMassTransit(x =>
            {
                x.UsingRabbitMq((context, cfg) =>
                    {
                        cfg.Host("localhost:15672", "/", h =>
                        {
                            h.Username("guest");
                            h.Password("guest");
                        });

                        cfg.ConfigureEndpoints(context);
                    }
                );
            });
        }
    }
}
