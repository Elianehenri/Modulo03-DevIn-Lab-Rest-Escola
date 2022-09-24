using Banda.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banda.Domain.Interfaces.Repositories
{
    public interface ITocarRepositorio
    {
        IList<Tocar> Listar();
        void Inserir(Tocar tocar);
        void Alterar(Tocar tocar);
        void Excluir(Tocar tocar);

    }
}
