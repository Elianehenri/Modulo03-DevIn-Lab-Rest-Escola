using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banda.Domain.DTOs
{
    public class TocarDTO
    {
        public string Descrição { get; set; }
        public string NomeMusica { get; set; }
        public int SequenciaMusica { get; set; }

        public TocarDTO()
        {
        }
    }
}
