using FoodMania.Application.Orders.Interfaces;
using FoodMania.Application.Orders.Requests;
using Microsoft.AspNetCore.Mvc;

namespace FoodMania.Services.Api.Controllers
{
    [ApiController]
    [Route("order")]
    public class OrderController : ControllerBase
    {
        readonly IOrderService _orderService;
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet("get-orders")]
        public async Task<IActionResult> Get()
        {
            return Ok("teste");
        }

        [HttpPost("get-orders")]
        public async Task<IActionResult> Order([FromBody] MakeOrderRequest request)
        {
            return Ok("teste");
        }
    }
}