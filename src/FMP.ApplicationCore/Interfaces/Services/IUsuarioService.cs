using FMP.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace FMP.ApplicationCore.Interfaces.Services
{
    public interface IUsuarioService
    {
        Usuario ObterPorLoginESenha(string Login, string Senha);

        IEnumerable<Usuario> ObterTodos();
    }
}
