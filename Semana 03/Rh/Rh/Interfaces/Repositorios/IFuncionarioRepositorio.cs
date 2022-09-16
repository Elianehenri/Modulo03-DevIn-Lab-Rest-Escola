using Rh.DTOs;
using Rh.Models;

namespace Rh.Interfaces.Repositorios
{
    public interface IFuncionarioRepositorio
    {
        IList<Funcionario> ObterTodos();
        Funcionario ObterPorId(int id);
        Funcionario ObterPorUsuarioSenha(string nome, string senha);
        void CadastrarFuncionario(Funcionario funcionario);
        void Editar(Funcionario funcionario);
        void Delete(Funcionario funcionario);
        bool ExisteFuncionario(Funcionario funcionario);

    }
}
