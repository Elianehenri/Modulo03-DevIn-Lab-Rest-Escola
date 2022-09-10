﻿using Escola.Api.Config;
using Escola.Domain.DTO;
using Escola.Domain.Interfaces.Services;
using Escola.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;



namespace Escola.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MateriasController : ControllerBase
    {
        private readonly IMateriaServico _materiaServico;
        private readonly IMemoryCache _cache;

        public MateriasController(IMateriaServico materiaServico, IMemoryCache cache)
        {
            _materiaServico = materiaServico;
            _cache = cache;
        }



        //api/materia
        [HttpGet] 
        public IActionResult ObterTodos(
            [FromQuery] string nome,
             int skip = 0,
             int take = 10)
        {
            IList<MateriaDTO> materias;
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
            if (!_cache.TryGetValue<MateriaDTO>($"materia:{materiaId}", out MateriaDTO materia))
            {
                materia = _materiaServico.ObterPorId(materiaId);
                _cache.Set<MateriaDTO>($"materia:{materiaId}",
                                        materia,
                                        TimeSpan.FromHours(5));
            }
            return Ok(materia);
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
            _cache.Remove($"materia:{materiaId}");

            return Ok();
        }

        [HttpDelete("{materiaId}")]
        public IActionResult Delete(
            [FromRoute] int materiaId)
        {
            _materiaServico.Excluir(materiaId);
            _cache.Remove($"materia:{materiaId}");
            return StatusCode(StatusCodes.Status204NoContent);
        }


    }
}
