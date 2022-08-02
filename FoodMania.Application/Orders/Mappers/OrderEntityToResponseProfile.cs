
using AutoMapper;
using FoodMania.Application.Core.Responses;
using FoodMania.Application.Orders.Responses;
using FoodMania.Domain.Orders;

namespace FoodMania.Application.Orders.Mappers
{
    public class OrderEntityToResponseProfile : Profile
    {
        public OrderEntityToResponseProfile()
        {
            CreateMap<Order, OrderResponse>();

            CreateMap<Product, OrderProductResponse>();

            CreateMap<Address, AddressResponse>();
        }
    }
}
