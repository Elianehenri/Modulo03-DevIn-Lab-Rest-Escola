using Escola.Domain.DTO;
using Escola.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Domain.Interfaces.Services
{
    public interface IMateriaServico
    {
        IList<MateriaDTO> ObterTodos(Paginacao paginacao);
        MateriaDTO ObterPorId(int id);
        List<MateriaDTO> ObterPorNome(string nome);
        void Inserir(MateriaDTO materia);
        void Excluir(int id);
        void Atualizar(MateriaDTO materia);
        int ObterTotal();
    }
}
