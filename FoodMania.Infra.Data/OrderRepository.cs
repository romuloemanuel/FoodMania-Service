using FoodMania.Domain.Orders;
using FoodMania.Domain.Orders.Interfaces;
using MongoDB.Driver;

namespace FoodMania.Infra.Data
{
    public class OrderRepository : IOrderRepository
    {
        private readonly IMongoCollection<Order> _orderCollection;

        public OrderRepository()
        {
            MongoClient client = new MongoClient("mongodb://admin:*****@localhost:27018/?authMechanism=DEFAULT");
            _orderCollection = client.GetDatabase("FoodMania").GetCollection<Order>("Orders");
        }

        public async Task InsertOrder(Order order) => await _orderCollection.InsertOneAsync(order);
    }
}
