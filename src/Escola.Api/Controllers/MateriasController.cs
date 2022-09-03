using Escola.Domain.DTO;
using Escola.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Escola.Api.Controllers
{
    [Controller]
    [Route("api/[controller]")]
    public class MateriasController : ControllerBase
    {
        private readonly IMateriaServico _materiaServico;
        public MateriasController(IMateriaServico materiaServico)
        {
            _materiaServico = materiaServico;
        }

        //api/materia
        [HttpGet] //nao consegui pesquisar por nome
        public IActionResult ObterTodos(
            [FromQuery] string nome)
        {
            if (!string.IsNullOrEmpty(nome))
                return Ok(_materiaServico.ObterPorNome(nome));
            return Ok(_materiaServico.ObterTodos());
        }

        [HttpGet("{materiaId}")]
        public IActionResult ObterPorId([FromRoute] int materiaId)
        {

            return Ok(_materiaServico.ObterPorId(materiaId));
        }

        [HttpPost]
        public IActionResult Inserir(
            [FromBody] MateriaDTO materia)
        {
            _materiaServico.Inserir(materia);
            return StatusCode(StatusCodes.Status201Created);
        }

    }
}
