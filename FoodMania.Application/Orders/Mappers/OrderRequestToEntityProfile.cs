
using AutoMapper;
using FoodMania.Application.Core.Request;
using FoodMania.Application.Orders.Requests;
using FoodMania.Domain.Orders;

namespace FoodMania.Application.Orders.Mappers
{
    public class OrderRequestToEntityProfile : Profile
    {
        public OrderRequestToEntityProfile()
        {
            CreateMap<MakeOrderRequest, Order>();

            CreateMap<OrderProductRequest, Product>();

            CreateMap<AddressRequest, Address>();
        }
    }
}
