using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace uber.Models
{
    public class Corrida
    {
        public   Endereco Origem { get; set; }
        public   Endereco Destino { get; set; }
    

        public void VisualizarSolicitacaoDeCorrida()
        {
            if(Origem == null || Destino == null)
            {
                throw  new Exception ("Os campos de origem e destino devem ser preenchidos.");
            }
        }
    }
}
