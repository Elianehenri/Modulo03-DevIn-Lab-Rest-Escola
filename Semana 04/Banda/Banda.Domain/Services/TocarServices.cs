using AutoMapper;
using Banda.Domain.DTOs;
using Banda.Domain.Interfaces.Repositories;
using Banda.Domain.Interfaces.Services;
using Banda.Domain.Models;

namespace Banda.Domain.Services
{
    public class TocarServices : ITocarService
    {
        private readonly ITocarRepositorio _tocarRepositorio;
        private readonly IMapper _mapper;

        public TocarServices(ITocarRepositorio tocarRepositorio, IMapper mapper)
        {
            _tocarRepositorio = tocarRepositorio;
            _mapper = mapper;
        }

        public void Alterar(TocarDTO dto)
        {
            var tocarDb = _tocarRepositorio.Listar().FirstOrDefault(t => t.Id == dto.Id);
            if (tocarDb == null)
               
            {
                throw new Exception("Musica não encontrada.");
            }
            tocarDb.Update(dto);
            _tocarRepositorio.Alterar(tocarDb);
        }

        public void Excluir(int id)
        {
            var tocarDb = _tocarRepositorio.Listar().FirstOrDefault(t => t.Id == id);
            if (tocarDb == null)

            {
                throw new Exception("Musica não encontrada.");
               
            }
            _tocarRepositorio.Excluir(tocarDb);

        }

       

        public IList<TocarDTO> Listar()
        {

            return _tocarRepositorio.Listar()
                .Select(t => _mapper.Map<TocarDTO>(t))
                .ToList();
        }
    }
}
