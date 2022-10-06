using Banda.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banda.Domain.Interfaces.Services
{
    public interface ITocarPostService
    {
        void Inserir(TocarDTO dto);
    }
}
