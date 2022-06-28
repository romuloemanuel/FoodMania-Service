
using FoodMania.Application.Orders.Requests;
using FoodMania.Domain.Orders;

namespace FoodMania.Application.Orders.Interfaces
{
    public interface IOrderAppService
    {
        Task MakeOrder(MakeOrderRequest request);
        Task ProcessMakeOrder(Order order);
    }
}
