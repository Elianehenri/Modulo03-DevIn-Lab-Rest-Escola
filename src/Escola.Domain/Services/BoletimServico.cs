using Escola.Domain.DTO;
using Escola.Domain.Interfaces.Repositories;
using Escola.Domain.Interfaces.Services;
using Escola.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Domain.Services
{
    public class BoletimServico : IBoletimServico
    {
        private readonly IBoletimRepositorio _boletimRepositorio;

        public BoletimServico(IBoletimRepositorio boletimRepositorio)
        {
            _boletimRepositorio = boletimRepositorio;
        }

        public void Atualizar(BoletimDTO boletim,int id)
        {
            var boletimDb = _boletimRepositorio.ObterPorId(id);
            if (boletimDb == null)
            {
                throw new Exception("Boletim nao existe.");

            }
            boletimDb.Update(boletim);
            _boletimRepositorio.Atualizar(boletimDb);
        }

        public void Excluir(int boletimId)
        {
            var boletimDb = _boletimRepositorio.ObterPorId(boletimId);
            if (boletimDb == null)
            {
                throw new Exception("Boletim nao existe.");
            }
           // var boletim = boletimDb.Notas.FirstOrDefault(b => b.Id == boletimId);
           // if (boletim == null)
            //{
               // throw new Exception("Materia nao encontrada.");
            //}
         
            _boletimRepositorio.Excluir(boletimDb);
            
        }
    
        public void Inserir(BoletimDTO boletim)
        {
            _boletimRepositorio.Inserir(new Boletim(boletim));
        }

        public BoletimDTO ObterPorId(int id)
        {
            return new BoletimDTO(_boletimRepositorio.ObterPorId(id));
        }

        public IList<BoletimDTO> ObterPorIdAluno(Guid id)
        {
            return _boletimRepositorio.ObterPorIdAluno(id)
                    .Select(b => new BoletimDTO(b)).ToList();
          
        }

    }
    
}
