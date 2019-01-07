using System;
using System.Collections.Generic;
using System.Text;
using FMP.ApplicationCore.Entities;
using FMP.ApplicationCore.Interfaces.Repositories;
using FMP.Infrastructure.Data;
using Microsoft.EntityFrameworkCore.Internal;
using System.Linq;

namespace FMP.Infrastructure.Repositories
{
    public class ClienteRepository : EFRepository<Cliente>, IClienteRepository
    {
        public ClienteRepository(FisioContext dbContext) : base(dbContext)
        {
        }

        public Cliente ObterPorProfissao(int clienteId)
        {
            return Buscar(x => x.ProfissoesClientes.Any(p => p.ClienteId == clienteId)).FirstOrDefault();
        }

        public override Cliente Adicionar(Cliente entity)
        {
            var verfificarResultado = "";
            _dbContext.Set<Cliente>().Add(entity);
            _dbContext.SaveChanges();

            return entity;

        }
    }
}
