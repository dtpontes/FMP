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
    public class EstadoRepository : EFRepository<Estado>, IEstadoRepository
    {
        public EstadoRepository(FisioContext dbContext) : base(dbContext)
        {
        }
    }
}
