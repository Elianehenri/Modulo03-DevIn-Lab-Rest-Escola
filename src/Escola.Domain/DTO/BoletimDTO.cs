using Escola.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Domain.DTO
{
   public class BoletimDTO
    {
       // public int Id { get; set; }
        public string Periodo { get; set; }
        public int Faltas { get; set; }
        public Guid AlunoId { get; set; }

        public BoletimDTO()
        {
        }

        public BoletimDTO(Boletim boletim)
        {
            //Id = boletim.Id;    
            Periodo = boletim.Periodo;
            Faltas = boletim.Faltas;
            AlunoId = boletim.AlunoId;
        }
    }
}
