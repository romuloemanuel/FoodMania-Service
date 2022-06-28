using FoodMania.Application.Orders.Interfaces;
using FoodMania.Application.Orders.Requests;
using Microsoft.AspNetCore.Mvc;

namespace FoodMania.Services.Api.Controllers
{
    [ApiController]
    //[ApiVersion("1", Deprecated = true)]
    [Route("api/v{version:apiVersion}/order")]
    [ApiVersion("2.0")]
    //[Produces("application/json")]
    public class Order2Controller : ControllerBase
    {
        readonly IOrderAppService _orderService;
        public Order2Controller(IOrderAppService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet("seach-order")]
        public IActionResult Order()
        {
            return Ok("ok");
        }
    }
}