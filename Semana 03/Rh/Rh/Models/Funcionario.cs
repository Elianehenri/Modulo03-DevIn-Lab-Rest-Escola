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


    }
}
