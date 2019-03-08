using Microsoft.AspNetCore.Mvc;

namespace WebAppDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MainController : ControllerBase
    {
        // GET api/main
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Hello from " + ConfigurationProvider.EnvName;
        }
    }
}