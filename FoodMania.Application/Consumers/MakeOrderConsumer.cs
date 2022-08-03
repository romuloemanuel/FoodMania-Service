using FoodMania.Application.Orders.Interfaces;
using FoodMania.Domain.Orders;
using MassTransit;

namespace FoodMania.Application.Consumers
{
    public class MakeOrderConsumer : IConsumer<Order>
    {
        readonly IOrderAppService _orderService;
        public MakeOrderConsumer(IOrderAppService orderService)
        {
            _orderService = orderService;
        }

        public async Task Consume(ConsumeContext<Order> context) => await _orderService.ProcessMakeOrder(context.Message);
    }
}
