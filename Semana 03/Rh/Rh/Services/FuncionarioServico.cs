using Rh.DTOs;
using Rh.Interfaces.Repositorios;
using Rh.Interfaces.Services;
using Rh.Models;

namespace Rh.Services
{
    public class FuncionarioServico : IFuncionarioServico
    {

        private readonly IFuncionarioRepositorio _funcionarioRepositorio;

        public FuncionarioServico(IFuncionarioRepositorio funcionarioRepositorio)
        {
            _funcionarioRepositorio = funcionarioRepositorio;
        }

        public void CadastrarFuncionario(FuncionarioDto funcionario)
        {
            if (_funcionarioRepositorio.ExisteFuncionario(new Funcionario(funcionario)))
            {
                throw new Exception("Funcionario já Cadastrado!");

                _funcionarioRepositorio.CadastrarFuncionario(new Funcionario(funcionario));
            }
        }

        public void Editar(FuncionarioDto funcionario)
        {
            _funcionarioRepositorio.Editar(new Funcionario(funcionario));
        }

        public FuncionarioDto ObterPorId(int id)
        {
            return new FuncionarioDto(_funcionarioRepositorio.ObterPorId(id));
        }

        public FuncionarioDto ObterPorId(string id)
        {
            throw new NotImplementedException();
        }

        public Funcionario ObterPorUsuarioSenha(FuncionarioLoginDto funcionario)
        {
            return _funcionarioRepositorio.ObterPorUsuarioSenha(funcionario.Nome, funcionario.Senha);
        }

        public IList<FuncionarioDto> ObterTodos()
        {
            return _funcionarioRepositorio.ObterTodos().Select(f => new FuncionarioDto(f)).ToList();
        }

        public void Remover(FuncionarioDto funcionario)
        {
            _funcionarioRepositorio.Delete(new Funcionario(funcionario));
        }

        
    }
}
