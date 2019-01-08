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
    public class PacienteDebitoRepository : EFRepository<PacienteDebito>, IPacienteDebitoRepository
    {
        public PacienteDebitoRepository(FisioContext dbContext) : base(dbContext)
        {
        }
    }
}
