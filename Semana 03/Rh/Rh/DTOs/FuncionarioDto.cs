using Rh.Enuns;
using Rh.Models;

namespace Rh.DTOs
{
    public class FuncionarioDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public Permissoes Permissao { get; set; }
        public decimal Salario { get; set; }

        public FuncionarioDto()
        {
        }

        public FuncionarioDto(Funcionario funcionario)
        {
            Id = funcionario.Id;
            Nome = funcionario.Nome;
            Senha = funcionario.Senha;
            Permissao = funcionario.Permissao;
            Salario = funcionario.Salario;
        }
    }
}
