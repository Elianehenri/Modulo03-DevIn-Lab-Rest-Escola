using Banda.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banda.Domain.Services
{
    public class TecnicoSomCommand : ICommand
    {
        private readonly TestesCommand _teste;

        public TecnicoSomCommand(TestesCommand teste)
        {
            _teste = teste;
        }

        public string Execute()
        {
            string retornoIniciar = _teste.Iniciar();
            string retornoFinalizar = _teste.Finalizar();

            return $"TecnicoSomCommand - {retornoIniciar} - {retornoFinalizar}";

        }
    }
}
