﻿using AutoMapper;
using Escola.Domain.DTO;
using Escola.Domain.Interfaces.Services;
using Escola.Domain.Models;
using Microsoft.AspNetCore.Mvc;


namespace Escola.Api.Controllers.V2
{

    [ApiController]
    [ApiVersion("2")]
    [Route("api/v{version:apiVersion}/alunos")]
    public class AlunosV2Controller : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IAlunoServico _alunoServico;

        public AlunosV2Controller(IAlunoServico alunoServico, IMapper mapper)
        {
            _mapper = mapper;
            _alunoServico = alunoServico;
        }


        [HttpGet]
        public IActionResult ObterTodos(int skip = 0, int take = 5)
        {
            var paginacao = new Paginacao(take, skip);

            var totalRegistros = _alunoServico.ObterTotal();

            Response.Headers.Add("X-Paginacao-TotalResgistros", totalRegistros.ToString());

            return Ok();//_alunoServico.ObterTodos(paginacao).Select(x => new AlunoV2DTO(x))
        }
        //[HttpGet]
        //public IActionResult ObterTodos(int skip = 0, int take = 5)
        //{
        //    var paginacao = new Paginacao(take, skip);

        //    var totalRegistros = _alunoServico.ObterTotal();

        //    Response.Headers.Add("X-Paginacao-TotalResgistros", totalRegistros.ToString());

        //    return Ok(_alunoServico.ObterTodos(paginacao).Select(x => new AlunoV2DTO(x)));
        //}

        [HttpGet("{id}")]
        public IActionResult ObterPorId(Guid id)
        {
            try
            {
                return Ok(_mapper.Map<AlunoV2DTO>(_alunoServico.ObterPorId(id)));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPost]
        public IActionResult Inserir(AlunoV2DTO aluno)
        {
            _alunoServico.Inserir(_mapper.Map<AlunoDTO>(aluno));

            return StatusCode(StatusCodes.Status201Created);
        }


        [HttpPut("{id}")]
        public IActionResult Atualizar(Guid id, 
            [FromBody] AlunoV2DTO aluno)
        {
            try
            {
                aluno.Id = id;
               //_alunoServico.Atualizar(new AlunoDTO(aluno));
                return Ok();
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(Guid id)
        {
            try
            {
                _alunoServico.Excluir(id);
                return StatusCode(StatusCodes.Status204NoContent);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }

}
