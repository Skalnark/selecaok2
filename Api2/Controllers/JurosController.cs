using System.Threading.Tasks;
using Api2.Services;
using Microsoft.AspNetCore.Mvc;

namespace Api2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JurosController : ControllerBase
    {
        private readonly IJurosService _jurosService;

        public JurosController(IJurosService jurosService)
        {
            _jurosService = jurosService;
        }

        [HttpGet("calcularJuros")]
        public IActionResult Get([FromQuery] double valorInicial, [FromQuery] int meses)
        {
            var result = _jurosService.CalcularJuros(valorInicial, meses);
            return Ok(result);
        }

        [HttpGet("source")]
        public IActionResult Get()
        {
            return Ok("Hello World");
        }
    }
}