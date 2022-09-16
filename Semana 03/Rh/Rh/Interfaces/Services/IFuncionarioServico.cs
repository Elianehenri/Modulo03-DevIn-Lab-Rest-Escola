﻿using Rh.DTOs;
using Rh.Models;

namespace Rh.Interfaces.Services
{
    public interface IFuncionarioServico
    {

        IList<FuncionarioDto> ObterTodos();
        FuncionarioDto ObterPorId(string id);
        FuncionarioDto ObterPorUsuarioSenha(FuncionarioLoginDto funcionario);
        void CadastrarFuncionario(FuncionarioDto funcionario);
        void Editar(FuncionarioDto funcionario);
        void Remover(FuncionarioDto funcionario);
    }
}
