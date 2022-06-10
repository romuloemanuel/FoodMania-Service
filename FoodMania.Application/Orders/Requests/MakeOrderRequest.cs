
using FoodMania.Application.Core.Request;

namespace FoodMania.Application.Orders.Requests
{
    public class MakeOrderRequest
    {
        public string ClientId { get; set; }
        public List<ProductOrderRequest> Products { get; set; }
        public AddressRequest AddressDelivery { get; set; }
    }
}
