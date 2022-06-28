
namespace FoodMania.Domain.Orders.Interfaces
{
    public interface IOrderRepository
    {
        public Task InsertOrder(Order order);
    }
}
