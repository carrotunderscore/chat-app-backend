using Microsoft.AspNetCore.Mvc;

namespace Chat_app.Controllers
{
	[Route("api/[controller]")]
    [ApiController]
    public class ChatController : ControllerBase 
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }
    }
}
