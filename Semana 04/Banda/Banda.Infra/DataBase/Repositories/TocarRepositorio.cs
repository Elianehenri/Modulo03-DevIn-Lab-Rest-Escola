using Banda.Domain.Interfaces.Repositories;
using Banda.Domain.Models;
using Banda.Infra.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banda.Infra.Repositories
{
    public class TocarRepositorio : BaseRepositorio<Tocar, int>, ITocarRepositorio   
    {
        public TocarRepositorio(BandaDBContexto contexto) : base(contexto)
        {

        }

    }
}
