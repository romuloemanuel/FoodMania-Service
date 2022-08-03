using FoodMania.Application.Orders.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FoodMania.Services.Api.Controllers
{
    [ApiVersion("2.0")]
    [ApiController]
    [Route("api/v2/order")]
    [Produces("application/json")]
    public class Order2Controller : ControllerBase
    {
        readonly IOrderAppService _orderService;
        public Order2Controller(IOrderAppService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet("get-order/{orderId}")]
        public async Task<IActionResult> Order([FromQuery] string orderId)
        {
            var order = await _orderService.GetOrder(orderId);

            return Ok(order);
        }
    }
}