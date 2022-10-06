using AutoMapper;
using Banda.Domain.DTOs;
using Banda.Domain.Interfaces.Repositories;
using Banda.Domain.Interfaces.Services;
using Banda.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banda.Domain.Services
{
    public class TocarPostServices: ITocarPostService
    {
        private readonly ITocarRepositorio _tocarRepositorio;
        private readonly IMapper _mapper;

        public TocarPostServices(ITocarRepositorio tocarRepositorio, IMapper mapper)
        {
            _tocarRepositorio = tocarRepositorio;
            _mapper = mapper;
        }

        public void Inserir(TocarDTO dto)
        {
            var tocarDb = _tocarRepositorio.Listar().FirstOrDefault(t => t.NomeMusica == dto.NomeMusica);

            if (tocarDb != null)
                throw new Exception("Música já cadastrada no banco!");

            _tocarRepositorio.Inserir(_mapper.Map<Tocar>(dto));
        }
    }
}
