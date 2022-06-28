
using FoodMania.Application.Core.Request;

namespace FoodMania.Application.Orders.Requests
{
    public class MakeOrderRequest
    {
        public string ClientId { get; set; }
        public List<OrderProductRequest> OrderProducts { get; set; }
        public AddressRequest DeliveryAddress { get; set; }
    }
}
