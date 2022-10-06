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
        private readonly ITocarPostService _tocarPost;

        public BandaTocarController(ITocarService tocarService, ITocarPostService tocarPost)
        {
            _tocarService = tocarService;
            _tocarPost = tocarPost;
        }

        [HttpGet]
        [Route("listar")]

        public IActionResult Listar()
        {
            return Ok(_tocarService.Listar());
        }

        [HttpPost]
        [Route("inserir")]
        public IActionResult Criar(
            [FromBody] TocarDTO dto)
        {
            _tocarPost.Inserir(dto);
            return Created("api/tocar", dto);
            
        }

        [HttpPut("{id}")]
        public IActionResult Alterar(
       [FromRoute] int id,
       [FromBody] TocarDTO dto
   )
        {
            dto.Id = id;
            _tocarService.Alterar(dto);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Deletar(
        [FromRoute] int id
    )
        {
            _tocarService.Excluir(id);
            return NoContent();
        }
    }
}
