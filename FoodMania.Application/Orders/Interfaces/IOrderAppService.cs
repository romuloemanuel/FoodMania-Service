
using FoodMania.Application.Orders.Requests;
using FoodMania.Application.Orders.Responses;
using FoodMania.Domain.Orders;

namespace FoodMania.Application.Orders.Interfaces
{
    public interface IOrderAppService
    {
        Task<OrderResponse> GetOrder(string orderId);
        void MakeOrder(MakeOrderRequest request);
        Task ProcessMakeOrder(Order order);
    }
}
