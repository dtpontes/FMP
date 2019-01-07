﻿using FMP.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace FMP.ApplicationCore.Interfaces.Services
{
    public interface IClienteService
    {

        Cliente Adicionar(Cliente entity);

        void Atualizar(Cliente entity);

        IEnumerable<Cliente> ObterTodos();

        Cliente ObterPorId(int id);

        IEnumerable<Cliente> Buscar(Expression<Func<Cliente, bool>> predicado);

        void Remover(Cliente entity);
    }
}
