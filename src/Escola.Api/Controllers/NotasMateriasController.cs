using Escola.Domain.DTO;
using Escola.Domain.Interfaces.Services;
using Escola.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace Escola.Api.Controllers
{
    [Controller]
    [Route("api/[controller]")]
    public class NotasMateriasController : ControllerBase
    {
        private readonly INotasMateriaServico _notasMateriaServico;

        public NotasMateriasController(INotasMateriaServico notasMateriaServico)
        {
            _notasMateriaServico = notasMateriaServico;
        }


        [HttpGet("{id}")]
        public IActionResult ObterPorId(
            [FromRoute] int id)
        {
            try
            {
                return Ok(_notasMateriaServico.ObterPorId(id));
            }
            catch
            {

                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpGet("~/api/alunos/{idAluno}/boletins/{idBoletim}/NotasMateria")]//~anular controller base
        public IActionResult ObterPorBoletim(
            [FromRoute] int boletimId)
        {
            try
            {
                return Ok(_notasMateriaServico.ObterPorBoletim(boletimId));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

        }
        [HttpPost]
        public IActionResult InserirNotas(
          [FromBody] NotasMateriaDTO notasMateria)
        {
            _notasMateriaServico.InserirNotas(notasMateria);
            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpPut("{notasMateriaId}")]//"{notasMateriaId}"
        public IActionResult AtualizarNotas(
            [FromRoute] int notasMateriaId,
            [FromBody] NotasMateriaDTO notasMateria)
        {
            notasMateria.Id = notasMateriaId;
            _notasMateriaServico.AtualizarNotas( notasMateria);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult ExcluirNotas(
            [FromRoute] int id)
        {
            _notasMateriaServico.ExcluirNotas(id);
                return StatusCode(StatusCodes.Status200OK);
        }


    }
}

