using FMP.ApplicationCore.Entities;
using FMP.ApplicationCore.Interfaces.Repositories;
using FMP.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

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
            return _dbContext.Pacientes
                .Include(x=>x.Cidade).ThenInclude(x=>x.Estado).ThenInclude(x=>x.Cidades)
                .Include(x => x.PacienteCreditos)
                .Include(x => x.PacienteDebitos);
        }

        public IEnumerable<Paciente> ObterPorNomeOuCPF(string Nome, string CPF)
        {
            //var verfificarResultado = "";
            return _dbContext.Pacientes.Where(x => x.CPF == CPF || x.Nome.Contains(Nome)).ToList();
        }

        public override Paciente ObterPorId(int id)
        {
            
                //var verfificarResultado = "";
                return _dbContext.Pacientes.Include(x => x.Cidade).Where(x => x.PacienteId == id).SingleOrDefault();
        }

        public  IEnumerable<PacienteDebito> ObterPorDataDeAtendimento(DateTime DataInicial, DateTime DataFinal)
        {
            //var verfificarResultado = "";
            var pacientesDebitos = _dbContext.PacienteDebitos
                .Include(x => x.Paciente)
                .Where(x => x.Data > DataInicial && x.Data < DataFinal);
                

            return pacientesDebitos;
        }
    }
}
