using AutoMapper;
using FoodMania.Application.Orders.Interfaces;
using FoodMania.Application.Orders.Requests;
using FoodMania.Application.Orders.Responses;
using FoodMania.Domain.Orders;
using FoodMania.Domain.Orders.Interfaces;
using MassTransit;
using MongoDB.Bson;
using ApplicationException = FoodMania.Application.Core.Exceptions.ApplicationException;

namespace FoodMania.Application.Orders.Services
{
    public class OrderAppService : IOrderAppService
    {
        readonly IOrderRepository _orderRepository;
        readonly IMapper _mapper;
        readonly IPublishEndpoint _sendEndpointProvider;
        public OrderAppService(
            IOrderRepository orderRepository,
            IMapper mapper,
            IPublishEndpoint sendEndpointProvider)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
            _sendEndpointProvider = sendEndpointProvider;
        }

        public async Task<OrderResponse> GetOrder(string orderId)
        {
            if (!ObjectId.TryParse(orderId, out var objectOrderId))
                throw new ApplicationException("Order's unique identifier is invalid");

            var order = await _orderRepository.GetOrder(objectOrderId);

            return _mapper.Map<OrderResponse>(order);
        }

        public void MakeOrder(MakeOrderRequest request)
        {
            var order = _mapper.Map<Order>(request);

            _sendEndpointProvider.Publish(order);
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
