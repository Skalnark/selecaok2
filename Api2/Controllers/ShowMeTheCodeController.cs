using Microsoft.AspNetCore.Mvc;

namespace Api2.Controllers
{
    [Route("api")]
    [ApiController]
    public class ShowMeTheCodeController : ControllerBase
    {
        [HttpGet("/showmethecode")]
        public IActionResult Index()
        {
            return Ok(new {sourceCode = "https://github.com/Skalnark/selecaok2"});
        }
    }
}