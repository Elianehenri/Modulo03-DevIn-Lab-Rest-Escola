using Banda.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banda.Domain.Interfaces.Services
{
    public interface ITocarService
    {
        IList<TocarDTO> Listar();
        void Inserir(TocarDTO dto);
        void Alterar(TocarDTO dto);
        void Excluir(int id);
    }
}
