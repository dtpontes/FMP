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
    public class TipoPagamentoRepository : EFRepository<TipoPagamento>, ITipoPagamentoRepository
    {
        public TipoPagamentoRepository(FisioContext dbContext) : base(dbContext)
        {
        }
    }
}
