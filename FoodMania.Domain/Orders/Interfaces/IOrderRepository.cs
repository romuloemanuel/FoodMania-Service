
using MongoDB.Bson;

namespace FoodMania.Domain.Orders.Interfaces
{
    public interface IOrderRepository
    {
        public Task InsertOrder(Order order);
        public Task<Order> GetOrder(ObjectId orderId);
    }
}
