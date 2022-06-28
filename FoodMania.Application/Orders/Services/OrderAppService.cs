using AutoMapper;
using FoodMania.Application.Orders.Interfaces;
using FoodMania.Application.Orders.Requests;
using FoodMania.Domain.Orders;
using FoodMania.Domain.Orders.Interfaces;

namespace FoodMania.Application.Orders.Services
{
    public class OrderAppService : IOrderAppService
    {
        readonly IOrderRepository _orderRepository;
        readonly IMapper _mapper;
        public OrderAppService(IOrderRepository orderRepository, IMapper mapper)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
        }

        public Task MakeOrder(MakeOrderRequest request)
        {
            var order = _mapper.Map<Order>(request);

            return Task.FromResult(order);
        }

        public async Task ProcessMakeOrder(Order order)
        {
            //MustValidProducts
            //MustMakeDoubleCheckAddress
            //MustValidClient

            await _orderRepository.InsertOrder(order);
        }
    }
}
