﻿using Escola.Domain.DTO;
using Escola.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Domain.Interfaces.Repositories
{
    public interface INotasMateriaRepositorio
    {
        public List<NotasMateria> ObterPorBoletim(int boletimId);
        public NotasMateria ObterPorId(int id);
        public void InserirNotas(NotasMateria notasMateria);
        public void ExcluirNotas(int id, NotasMateria notasMateria);
        public void AtualizarNotas(int id, NotasMateria notas);
    }
}