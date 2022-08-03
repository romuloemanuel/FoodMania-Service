using FoodMania.Domain.Orders;
using FoodMania.Domain.Orders.Interfaces;
using MongoDB.Bson;
using MongoDB.Driver;

namespace FoodMania.Infra.Data
{
    public class OrderRepository : IOrderRepository
    {
        private readonly IMongoCollection<Order> _orderCollection;

        public OrderRepository()
        {
            MongoClient client = new MongoClient("mongodb://mongoadmin:admin@localhost:27018/");
            _orderCollection = client.GetDatabase("FoodMania").GetCollection<Order>("Orders");
        }

        public async Task InsertOrder(Order order)
        {
            await _orderCollection.InsertOneAsync(order);
        }

        public async Task<Order> GetOrder(ObjectId orderId)
        {
            var order = await _orderCollection.FindAsync(x => x.Id == orderId);

            return order.FirstOrDefault();
        }
    }
}
