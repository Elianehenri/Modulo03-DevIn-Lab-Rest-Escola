using Escola.Domain.DTO;
using Escola.Domain.Interfaces.Services;
using Escola.Domain.Models;
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
        [HttpGet] 
        public IActionResult ObterTodos(
            [FromQuery] string nome,
             int skip = 0,
             int take = 10)
        {
            var paginacao = new Paginacao(take, skip);
            var totalRegistros = _materiaServico.ObterTotal();

            Response.Headers.Add("x-Paginacao-TotalRegistros", totalRegistros.ToString());
            if (!string.IsNullOrEmpty(nome))
                return Ok(_materiaServico.ObterPorNome(nome));
            return Ok(_materiaServico.ObterTodos(paginacao));
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

        [HttpPut("{materiaId}")]
        public IActionResult Put(
            [FromRoute] int materiaId, 
            [FromBody] MateriaDTO materia)
        {
            materia.Id = materiaId;
            _materiaServico.Atualizar(materia);
            return Ok();
        }

        [HttpDelete("{materiaId}")]
        public IActionResult Delete(
            [FromRoute] int materiaId)
        {
            _materiaServico.Excluir(materiaId);
            return StatusCode(StatusCodes.Status204NoContent);
        }


    }
}
