using Api1.Services;
using Microsoft.AspNetCore.Mvc;

namespace Api1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaxaController : ControllerBase
    {
        private readonly ITaxaService _taxaService;

        public TaxaController(ITaxaService taxaService)
        {
            _taxaService = taxaService;
        }

        [HttpGet]

        [HttpGet("taxaJuros")]
        public IActionResult Get()
        {
            return Ok(_taxaService.GetTaxaJuros());
        }
    }
}