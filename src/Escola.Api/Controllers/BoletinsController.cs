using Escola.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using Escola.Domain.DTO;


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
            try
            { 
            return Ok(_boletimServico.ObterPorIdAluno(idAluno));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPost]

        public IActionResult Inserir(
            [FromBody] BoletimDTO boletim)
        {
            _boletimServico.Inserir(boletim);
            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(
            [FromRoute] int id, 
            [FromBody] BoletimDTO boletim)
        {
            try
            {

                _boletimServico.Atualizar(boletim, id);
                return StatusCode(StatusCodes.Status201Created);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Excluir(
        [FromRoute] int id)
        {
            _boletimServico.Excluir(id);
            return StatusCode(StatusCodes.Status204NoContent);
        }

    }
}
