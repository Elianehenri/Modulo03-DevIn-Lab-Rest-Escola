using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Rh.Enuns
{
    public enum Permissoes
    {
        [Display(Name = "Funcionário")]
        Funcionario = 1,
        [Display(Name = "Gerente")]
        Gerente = 2,
        [Display(Name = "Administrador")]
        Administrador = 3
    }
}
