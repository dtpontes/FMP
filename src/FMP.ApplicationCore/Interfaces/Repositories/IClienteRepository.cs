﻿using FMP.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FMP.ApplicationCore.Interfaces.Repositories
{
    public interface IClienteRepository : IRepository<Cliente>
    {
        Cliente ObterPorProfissao(int clienteId);

    }
}
