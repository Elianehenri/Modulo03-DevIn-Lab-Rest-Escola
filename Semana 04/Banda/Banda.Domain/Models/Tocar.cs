using Banda.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banda.Domain.Models
{
    public class Tocar
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string NomeMusica { get; set; }
        public int SequenciaMusica { get; set; }

        public Tocar()
        {
        }

        public void Update(TocarDTO dto)
        {
            Descricao = dto.Descricao;
            NomeMusica = dto.NomeMusica;
            SequenciaMusica = dto.SequenciaMusica;
        }
    }
}
