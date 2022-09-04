using Escola.Domain.DTO;
using Escola.Domain.Interfaces.Repositories;
using Escola.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Domain.Interfaces.Services
{
    public interface IBoletimServico
    {
       
        BoletimDTO ObterPorId(int id);
        IList<BoletimDTO> ObterPorIdAluno(Guid id);
        void Inserir(BoletimDTO boletim);
        void Excluir(int id);
        void Atualizar(BoletimDTO boletim,int id);
    }
}
