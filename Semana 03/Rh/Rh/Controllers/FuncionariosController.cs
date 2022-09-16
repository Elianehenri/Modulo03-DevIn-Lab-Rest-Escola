using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Extensions;
using Rh.DTOs;
using Rh.Enuns;
using Rh.Interfaces.Repositorios;
using Rh.Interfaces.Services;
using Rh.Models;
using Rh.Repositories;
using Rh.Services;
using System.Data;


namespace Rh.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FuncionariosController : ControllerBase
    {
        private readonly IFuncionarioServico _funcionarioServico;
        public FuncionariosController(IFuncionarioServico funcionarioServico)
        {
            _funcionarioServico = funcionarioServico;
        }


        [Authorize]
        [HttpGet("listar")]

        public ActionResult Listar()
        {
            if (User.IsInRole(Permissoes.Funcionario.GetDisplayName()))
            {
                return Ok(_funcionarioServico.ObterTodos().Select(f => new { f.Nome, f.Permissao }));
            }

            return Ok(_funcionarioServico.ObterTodos());
        }

        [Authorize(Roles = "Administrador")]
        [HttpPost("cadastrar-funcionario")]
        public IActionResult CadastrarFuncionarios(
            [FromBody] FuncionarioDto funcionario)
        {
            _funcionarioServico.CadastrarFuncionario(funcionario);
            return StatusCode(StatusCodes.Status201Created);
        }

        [Authorize(Roles = "Administrador, Gerente Geral")]
        [HttpDelete("excluir-funcionario/{id}")]
        public IActionResult ExcluirFuncionario(
        [FromRoute] int id)
        {
            var funcionario = _funcionarioServico.ObterPorId(id);
            if (funcionario.Permissao == Permissoes.Administrador || funcionario.Permissao == Permissoes.Gerente)
                return StatusCode(StatusCodes.Status401Unauthorized);

            _funcionarioServico.Remover(funcionario);
            return NoContent();
        }

        [Authorize(Roles = "Administrador, Gerente Geral")]
        [HttpDelete("excluir-gerente/{id}")]
        public IActionResult ExcluirGerente(
        [FromRoute] int id)
        {
            var funcionario = _funcionarioServico.ObterPorId(id);
            _funcionarioServico.Remover(funcionario);
            return NoContent();
        }

        [Authorize(Roles = "Gerente Geral")]
        [HttpPut("alterar-salario/{id}")]
        public IActionResult AlterarSalario(
        [FromRoute] int id,
        [FromBody] SalarioDto salario)
        {
            var funcionario = _funcionarioServico.ObterPorId(id);
            funcionario.Salario = salario.Salario;
            _funcionarioServico.Editar(funcionario);
            return Ok();
        }
    }
}
