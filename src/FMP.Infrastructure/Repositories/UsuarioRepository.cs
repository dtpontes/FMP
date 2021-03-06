﻿using System;
using System.Collections.Generic;
using System.Text;
using FMP.ApplicationCore.Entities;
using FMP.ApplicationCore.Interfaces.Repositories;
using FMP.Infrastructure.Data;
using Microsoft.EntityFrameworkCore.Internal;
using System.Linq;

namespace FMP.Infrastructure.Repositories
{
    public class UsuarioRepository : EFRepository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(FisioContext dbContext) : base(dbContext)
        {
        }

        public Usuario ObterPorLoginESenha(string Login, string Senha)
        {
            //var verfificarResultado = "";
            
            return _dbContext.Usuarios.Where(x => x.Login == Login && x.Senha == Senha).SingleOrDefault();
        }
    }
}
