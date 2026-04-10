using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NewsController : ControllerBase
    {

        [HttpGet]
        public string Get()
        {
            return "Hello World!";
        }
    }
}
