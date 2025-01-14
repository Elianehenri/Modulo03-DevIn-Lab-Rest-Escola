﻿using Escola.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Domain.Models
{
    public class Boletim
    {
        public int Id { get; set; }
        public Guid AlunoId { get; set; }
        public string Periodo { get; set; }
        public int Faltas { get; set; }
        public virtual Aluno Aluno { get; set; }
        public IList<NotasMateria> Notas { get; set; }

        public Boletim()
        {
        }

        public Boletim(BoletimDTO boletim)
        {
            Periodo = boletim.Periodo;
            Faltas = boletim.Faltas;
            AlunoId = boletim.AlunoId;
        }
        public void Update(BoletimDTO boletim)
        {
            Periodo = boletim.Periodo;
            Faltas = boletim.Faltas;
            AlunoId = boletim.AlunoId;
        }

    }
}
