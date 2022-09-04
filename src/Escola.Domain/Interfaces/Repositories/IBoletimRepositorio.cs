using Escola.Domain.Models;

namespace Escola.Domain.Interfaces.Repositories
{
    public interface IBoletimRepositorio
    {
        IList<Boletim> ObterPorIdAluno(Guid id);
        Boletim ObterPorId(int id);
        void Inserir(Boletim boletim);
        void Excluir(Boletim boletim, NotasMateria materia);
        void Atualizar(Boletim boletim);
        
    }
}
