using Microsoft.AspNetCore.Mvc;

namespace TrikingLibrary.Api.Controllers
{
    [ApiController]
    [Route("api/home")]
    public class HomeController : ControllerBase
    {
        public IActionResult Index()
        {
            return Ok("Hello world");
        }
    }
}
