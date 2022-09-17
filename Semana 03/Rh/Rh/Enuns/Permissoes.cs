using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Rh.Enuns
{
    public enum Permissoes
    {
        [XmlEnumAttribute("F")]
        [Display(Name = "Funcionário")]
        Funcionario = 1,
        [XmlEnumAttribute("G")]
        [Display(Name = "Gerente Geral")]
        Gerente = 2,
        [XmlEnumAttribute("A")]
        [Display(Name = "Administrador")]
        Administrador = 3
    }

   
}

