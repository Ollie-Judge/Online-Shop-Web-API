using Microsoft.AspNetCore.Mvc;

namespace Online_Shop_Web_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloWorldController : ControllerBase
    { 

        [HttpGet("")]
        public string Get()
        {
            return "Hello World";
        }
    }
}