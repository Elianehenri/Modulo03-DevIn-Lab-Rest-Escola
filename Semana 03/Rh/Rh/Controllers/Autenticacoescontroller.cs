using Microsoft.AspNetCore.Mvc;
using Rh.DTOs;
using Rh.Interfaces.Services;
using Rh.Services;

namespace Rh.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Autenticacoescontroller: ControllerBase
    {
        private readonly IFuncionarioServico _funcionarioServico;

        public Autenticacoescontroller(IFuncionarioServico funcionarioServico)
        {
            _funcionarioServico = funcionarioServico;
        }


        [HttpPost]
        [Route("login")]
        public IActionResult Login(
        [FromBody] FuncionarioLoginDto funcionariodto
    )
        {
            var funcionario = _funcionarioServico.ObterPorUsuarioSenha(funcionariodto);
            if (funcionario == null)
                return StatusCode(StatusCodes.Status401Unauthorized);

            var token = TokenService.GenerateToken(funcionario);

            return Ok(token);
        }



    }
}
