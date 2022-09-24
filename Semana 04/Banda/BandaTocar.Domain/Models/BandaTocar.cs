﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BandaTocar.Domain.Models
{
    public class BandaTocar
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string NomeMusica { get; set; }
        public int SequenciaMusica { get; set; }

        public BandaTocar()
        {
        }
    }
}