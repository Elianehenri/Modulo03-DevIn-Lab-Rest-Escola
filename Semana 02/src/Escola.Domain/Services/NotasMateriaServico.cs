using Escola.Domain.DTO;
using Escola.Domain.Exceptions;
using Escola.Domain.Interfaces.Repositories;
using Escola.Domain.Interfaces.Services;
using Escola.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Domain.Services
{
    public class NotasMateriaServico : INotasMateriaServico
    {
        private readonly INotasMateriaRepositorio _notasMateriaRepositorio;

        public NotasMateriaServico(INotasMateriaRepositorio notasMateriaRepositorio)
        {
            _notasMateriaRepositorio = notasMateriaRepositorio;
        }

        public void AtualizarNotas( NotasMateriaDTO notasMateria)
        {
            
           
                var notasMateriaDB = _notasMateriaRepositorio.ObterPorId(notasMateria.Id);
                notasMateriaDB.Update(notasMateria);//vem da classe notasMateria
                _notasMateriaRepositorio.Atualizar(notasMateriaDB);
            
        }

        public void ExcluirNotas(int id)
        {
            if (!_notasMateriaRepositorio.NotasExiste(id))
            {
                throw new NotImplementedException("Nota nao encontrada.");

            }
            NotasMateria notasMateria = _notasMateriaRepositorio.ObterPorId(id);
            _notasMateriaRepositorio.Excluir(notasMateria);


        }

        public void InserirNotas(NotasMateriaDTO notasMateria)
        {
        

            _notasMateriaRepositorio.Inserir(new NotasMateria(notasMateria));
        }

        

        public NotasMateriaDTO ObterPorId(int id)
        {
            if (_notasMateriaRepositorio.ObterPorId(id) != null)
            {
                return new NotasMateriaDTO(_notasMateriaRepositorio.ObterPorId(id));

            }
            else
            {
                throw new Exception("Nota não existe.");
            }
            
        }

        public IList<NotasMateriaDTO> ObterPorBoletim(int boletimId)
        {
            return _notasMateriaRepositorio.ObterPorBoletim(boletimId)
                    .Select(n => new NotasMateriaDTO(n)).ToList();
            
        }
        //public IList<NotasMateriaDTO> ObterTodos(Paginacao paginacao)
        //{
            // var alunosResposta = new List<AlunoDTO>();
            // var alunos=  _alunoRepositorio.ObterTodos();
            // foreach (var aluno in alunos){
            //     alunosResposta.Add(new AlunoDTO(aluno));
            // }
            // return alunosResposta;

            //return _notasMateriaRepositorio.ObterTodos(paginacao)
            //                .Select(x => new NotasMateriaDTO(x)).ToList();
        //}
    }
}
