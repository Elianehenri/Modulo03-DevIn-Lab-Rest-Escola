using Escola.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Domain.DTO
{
    public class NotasMateriaDTO
    {
        public int Id { get; set; }
        public int BoletimId { get; set; }
        public int MateriaId { get; set; }

        public int Nota { get; set; }


        public NotasMateriaDTO()
        {
        }

        public NotasMateriaDTO(NotasMateriaDTO notasMateria)
        {
            Id = notasMateria.Id;
            BoletimId = notasMateria.BoletimId;
            MateriaId = notasMateria.MateriaId;
            Nota = notasMateria.Nota;
        }
    }
}
