using Escola.Domain.Interfaces.Repositories;
using Escola.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Infra.DataBase.Repositories
{
    public class MateriaRepositorio : BaseRepositorio<Materia, int>, IMateriaRepositorio
    {
         
        public MateriaRepositorio(EscolaDBContexto contexto) :base (contexto)
        {
            
        }

      

        public List<Materia> ObterPorNome(string nome)
        {
            return _contexto.Materias.Where(x => x.Nome == nome).ToList();
        }

        public int ObterTotal()
        {
            return _contexto.Materias.Count();
        }
    }
}
