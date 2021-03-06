﻿using FMP.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FMP.ApplicationCore.Interfaces.Repositories
{
    public interface IUsuarioRepository : IRepository<Usuario>
    {

        Usuario ObterPorLoginESenha(string Login, string Senha);
    }
}
