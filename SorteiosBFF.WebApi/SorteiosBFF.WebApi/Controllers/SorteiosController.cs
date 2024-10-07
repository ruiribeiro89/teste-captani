using Microsoft.AspNetCore.Mvc;
using SorteiosBFF.Application.Services;

namespace SorteiosBFF.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SorteiosController : ControllerBase
    {
        private readonly SorteioService _sorteioService;

        public SorteiosController(SorteioService sorteioService)
        {
            _sorteioService = sorteioService;
        }

        [HttpGet("dados-sorteios")]
        public async Task<IActionResult> GetSorteios()
        {
            var response = await _sorteioService.ObterDadosSorteiosAsync();
            return Ok(response);
        }
    }
}
