
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
            CreateMap<MakeOrderRequest, Order>()
                .ForMember(dst => dst.Id, map => map.MapFrom(scr => Guid.NewGuid()));

            CreateMap<OrderProductRequest, Product>();

            CreateMap<AddressRequest, Address>();
        }
    }
}
