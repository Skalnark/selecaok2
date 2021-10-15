using Microsoft.AspNetCore.Mvc;

namespace Api2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaxaController : ControllerBase
    {

        [HttpGet("calcularJuros")]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}