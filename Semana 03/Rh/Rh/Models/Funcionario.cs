using Rh.DTOs;
using Rh.Enuns;

namespace Rh.Models
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public Permissoes Permissao { get; set; }
        public decimal Salario { get; set; }

        public Funcionario()
        {
        }

        public Funcionario(FuncionarioDto funcionario)
        {
            Id = funcionario.Id;
            Nome = funcionario.Nome;
            Senha = funcionario.Senha;
            Permissao = funcionario.Permissao;
            Salario = funcionario.Salario;
        }

        public void Update(FuncionarioDto funcionario)
        {
            Nome = funcionario.Nome;
            Senha = funcionario.Senha;
            Permissao = funcionario.Permissao;
            Salario = funcionario.Salario;
        }

        public void Update(Funcionario funcionario)
        {
            Nome = funcionario.Nome;
            Senha = funcionario.Senha;
            Permissao = funcionario.Permissao;
            Salario = funcionario.Salario;
        }

    }
}
