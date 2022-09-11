using Escola.Domain.Interfaces.Repositories;
using Escola.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Infra.DataBase.Repositories
{
    public class NotasMateriaRepositorio :BaseRepositorio<NotasMateria, int>, INotasMateriaRepositorio
    {
       

        public NotasMateriaRepositorio(EscolaDBContexto contexto) : base(contexto)  
        {
            
        }
 
       
        public List<NotasMateria> ObterPorBoletim(int boletimId)
        {
            return _contexto.NotasMaterias.Where(n => n.BoletimId == boletimId).ToList();
        }

        public bool NotasExiste(int id)
        {
            return _contexto.NotasMaterias.Any(ne => ne.Id == id);
        }
    }
}
