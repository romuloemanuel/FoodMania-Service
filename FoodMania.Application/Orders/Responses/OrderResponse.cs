
using FoodMania.Application.Core.Responses;

namespace FoodMania.Application.Orders.Responses
{
    public class OrderResponse
    {
        public string ClientId { get; set; }
        public List<OrderProductResponse> OrderProducts { get; set; }
        public AddressResponse DeliveryAddress { get; set; }
    }
}
