﻿using Escola.Domain.DTO;
using Escola.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Domain.Interfaces.Services
{
    public interface INotasMateriaServico
    {
        public IList<NotasMateriaDTO> ObterTodos();
        NotasMateriaDTO ObterPorId(int id);
        void InserirNotas(NotasMateriaDTO notasMateria);
        void ExcluirNotas(int id);
        void AtualizarNotas(int id, NotasMateriaDTO notasMateria);
    }
}
