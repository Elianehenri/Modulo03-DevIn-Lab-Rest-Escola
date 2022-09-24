using Banda.Domain.DTOs;
using Banda.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;

namespace Banda.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BandaTocarController : ControllerBase
    {

        private  readonly ITocarService _tocarService;

        public BandaTocarController(ITocarService tocarService)
        {
            _tocarService = tocarService;
        }

        [HttpPost]
        public IActionResult Criar(
            [FromBody]TocarDTO tocar)
        {
            _tocarService.Inserir(tocar);
             return Ok(tocar);
            //return StatusCode(StatusCodes.Status201Created);
        }
    }
}
