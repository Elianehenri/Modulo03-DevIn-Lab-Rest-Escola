﻿using Escola.Domain.DTO;
using Escola.Domain.Exceptions;
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
    public class NotasMateriaServico : INotasMateriaServico
    {
        private readonly INotasMateriaRepositorio _notasMateriaRepositorio;

        public NotasMateriaServico(INotasMateriaRepositorio notasMateriaRepositorio)
        {
            _notasMateriaRepositorio = notasMateriaRepositorio;
        }

        public void AtualizarNotas(int id, NotasMateriaDTO notasMateria)
        {
            throw new NotImplementedException();
        }

        public void ExcluirNotas(int id)
        {
            throw new NotImplementedException();
        }

        public void InserirNotas(NotasMateriaDTO notasMateria)
        {


            _notasMateriaRepositorio.InserirNotas(new NotasMateria(notasMateria));
        }

        

        public NotasMateriaDTO ObterPorId(int id)
        {
            if (_notasMateriaRepositorio.ObterPorId(id) != null)
            {
                return new NotasMateriaDTO(_notasMateriaRepositorio.ObterPorId(id));

            }
            else
            {
                throw new Exception("Nota não existe.");
            }
            
        }

        public IList<NotasMateriaDTO> ObterPorBoletim(int boletimId)
        {
            return _notasMateriaRepositorio.ObterPorBoletim(boletimId)
                    .Select(n => new NotasMateriaDTO(n)).ToList();
            
        }
    }
}