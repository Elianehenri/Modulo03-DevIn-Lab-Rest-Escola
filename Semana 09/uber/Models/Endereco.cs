using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace uber.Models
{
    public class Endereco
    {
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public int Numero { get; set; }

        public Endereco()
        {
          
        }
        public Endereco(string rua, string bairro, int numero)
        {
             Rua = rua;
             Bairro = bairro;
             Numero = numero;
        }
    }
}
