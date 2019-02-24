using FMP.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FMP.ApplicationCore.Interfaces.Repositories
{
    public interface IPacienteRepository : IRepository<Paciente>
    {
        IEnumerable<Paciente> ObterPorNomeOuCPF(string Nome, string CPF);

        IEnumerable<PacienteDebito> ObterPorDataDeAtendimento(DateTime DataInicial, DateTime DataFinal);

    }
}
