using Microsoft.AspNetCore.Mvc;

namespace FoodMania.Services.Api.Controllers
{
    [ApiController]
    [Route("Order")]
    public class OrderController : ControllerBase
    {


        public OrderController(ILogger<OrderController> logger)
        {
            //_logger = logger;
        }

        public async Task<IActionResult> Get()
        {
            return Ok();
        }
    }
}