using FoodMania.Application.Orders.Interfaces.Consumers;
using MassTransit;
using Microsoft.Extensions.DependencyInjection;

namespace FoodMania.Infra.Extensions
{
    public static class MasstransitExtension
    {
        public static void AddMasstransitConfiguration(this IServiceCollection services)
        {
            services.AddMassTransit(bus =>
            {
                bus.AddConsumer<MakeOrderConsumer>()
                .Endpoint(x => x.Name = "make-order-queue");

                bus.UsingRabbitMq((context, cfg) =>
                {
                    cfg.Host("amqp://guest:guest@localhost:5672");

                    cfg.ConfigureEndpoints(context);
                });
            });
        }
    }
}
