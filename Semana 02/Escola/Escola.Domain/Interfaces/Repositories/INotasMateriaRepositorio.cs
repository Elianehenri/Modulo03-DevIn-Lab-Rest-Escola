using Escola.Domain.DTO;
using Escola.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Domain.Interfaces.Repositories
{
    public interface INotasMateriaRepositorio
    {
       
        public List<NotasMateria> ObterPorBoletim(int boletimId);
        public NotasMateria ObterPorId(int id);
        public void Inserir(NotasMateria notasMateria);
        public void Excluir( NotasMateria notasMateria);
        public void Atualizar( NotasMateria notasMateria);
        public bool NotasExiste( int id );  
    }
}
