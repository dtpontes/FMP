using System;
using System.Collections.Generic;
using System.Text;
using FMP.ApplicationCore.Entities;
using FMP.ApplicationCore.Interfaces.Repositories;
using FMP.Infrastructure.Data;
using Microsoft.EntityFrameworkCore.Internal;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace FMP.Infrastructure.Repositories
{
    public class PacienteRepository : EFRepository<Paciente>, IPacienteRepository
    {
        public PacienteRepository(FisioContext dbContext) : base(dbContext)
        {
        }

        public override IEnumerable<Paciente>  ObterTodos()
        {
            //var verfificarResultado = "";
            return _dbContext.Pacientes.Include(x => x.Cidade);
            

        }
    }
}
