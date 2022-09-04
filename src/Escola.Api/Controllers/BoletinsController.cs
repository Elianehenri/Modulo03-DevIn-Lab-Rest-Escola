using Escola.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using Escola.Domain.DTO;
using Escola.Domain.Services;
using Escola.Domain.Models;

namespace Escola.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BoletinsController : ControllerBase
    {
        private readonly IBoletimServico _boletimServico;

        public BoletinsController(IBoletimServico boletimServico)
        {
            _boletimServico = boletimServico;
        }

        [HttpGet("{id}")]
        public IActionResult ObterPorId(
            [FromRoute] int id)
        {
            
            try
            {
                return Ok(_boletimServico.ObterPorId(id));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

        }

        [HttpGet("~/api/alunos/{idAluno}/boletins")]//~anular controller base
        public IActionResult ObterPorIdAluno(
            [FromRoute] Guid idAluno)
        {
            return Ok(_boletimServico.ObterPorIdAluno(idAluno));
        }

    }
}
