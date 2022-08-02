using FoodMania.Application.Orders.Interfaces;
using FoodMania.Application.Orders.Requests;
using Microsoft.AspNetCore.Mvc;

namespace FoodMania.Services.Api.Controllers
{
    [ApiController]
    [Route("api/v1/order")]
    [Produces("application/json")]
    public class OrderController : ControllerBase
    {
        readonly IOrderAppService _orderService;
        public OrderController(IOrderAppService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost("make-order")]
        public async Task<IActionResult> Order([FromBody] MakeOrderRequest request)
        {
            await _orderService.MakeOrder(request);
            return Ok();
        }
    }
}