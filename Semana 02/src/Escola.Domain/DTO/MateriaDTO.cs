using Escola.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Domain.DTO
{
    public class MateriaDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public MateriaDTO()
        {

        }
        public MateriaDTO(Materia materia)
        {
            Id = materia.Id;
            Nome = materia.Nome;
        }

        public MateriaDTO(MateriaV2DTO materia)//map //deve ser excluido,poruqe foi feito o mapper
        {
            Id = materia.Id;
            Nome = materia.Disciplina;

        }
    }
}
