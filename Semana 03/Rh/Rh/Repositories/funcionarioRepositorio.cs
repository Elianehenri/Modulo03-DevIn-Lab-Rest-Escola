using Rh.DTOs;
using Rh.Enuns;
using Rh.Interfaces.Repositorios;
using Rh.Models;

namespace Rh.Repositories
{
    public class FuncionarioRepositorio : IFuncionarioRepositorio
    {

       private static List<Funcionario> ListaFuncionarios { get; set; } = new List<Funcionario> {
            new Funcionario()
            {
                Id= 1,
                Nome = "Eliane",
                Permissao = Permissoes.Administrador,
                Salario = 12500m,
                Senha = "123"
            },

            new Funcionario()
            {
                Id= 2,
                Nome = "Agilson",
                Permissao = Permissoes.Gerente,
                Salario = 9500m,
                Senha = "123"
            },
            new Funcionario()
            {
                Id= 3,
                Nome = "Luana",
                Permissao = Permissoes.Funcionario,
                Salario = 6500m,
                Senha = "123"
            },
            new Funcionario()
            {
                Id= 4,
                Nome = "Julio",
                Permissao = Permissoes.Funcionario,
                Salario = 5500m,
                Senha = "123"
            },

        };
        public  void CadastrarFuncionario(Funcionario funcionario)
        {
            funcionario.Id = 5;
             ListaFuncionarios.Add(funcionario);
           
        }

        public  void Delete(Funcionario funcionario)
        {
            ListaFuncionarios.RemoveAll(f => f.Id == funcionario.Id);
        }

        public  void Editar(Funcionario funcionario)
        {
            var funcionarioEd = ListaFuncionarios.Find(f => f.Id == funcionario.Id);
            funcionarioEd.Update(funcionario);
        }

        public  bool ExisteFuncionario(Funcionario funcionario)
        {
            return ListaFuncionarios.Any(f => f.Nome == funcionario.Nome && f.Senha == funcionario.Senha);
        }

        public  Funcionario ObterPorId(int id)
        {
            var funcionario = ListaFuncionarios.Find(f => f.Id == id);
            //var funcionario = ListaFuncionarios.Where(f => f.Id == id).First();
            return funcionario;
        }

        public  Funcionario ObterPorUsuarioSenha(string nome, string senha)
        {
            return ListaFuncionarios.FirstOrDefault(f => f.Nome == nome && f.Senha == senha);
        }


        public IList<Funcionario> ObterTodos()
        {
            return ListaFuncionarios;
        }
    }
}
