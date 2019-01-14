using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Text;
using FMP.ApplicationCore.DTO;
using FMP.ApplicationCore.Entities;
using FMP.ApplicationCore.Interfaces.Repositories;
using FMP.ApplicationCore.Interfaces.Services;

namespace FMP.ApplicationCore.Services
{
    public class PacienteService : IPacienteService
    {
        private readonly IPacienteRepository _pacienterepository;

        public PacienteService(IPacienteRepository pacienteRepository)
        {
            _pacienterepository = pacienteRepository;
        }

        public Paciente Adicionar(Paciente entity)
        {
            return _pacienterepository.Adicionar(entity);
        }

        public void Atualizar(Paciente entity)
        {
            _pacienterepository.Atualizar(entity);
        }

        public IEnumerable<Paciente> Buscar(Expression<Func<Paciente, bool>> predicado)
        {
            return _pacienterepository.Buscar(predicado);
        }

        public Paciente ObterPorId(int id)
        {
            return _pacienterepository.ObterPorId(id);
        }

        public IEnumerable<Paciente> ObterTodos()
        {
            return _pacienterepository.ObterTodos();
        }

        public void Remover(Paciente entity)
        {
            _pacienterepository.Remover(entity);
        }

        public IEnumerable<Paciente> ObterPorNomeECPF(string Nome, string CPF)
        {
            return _pacienterepository.ObterPorNomeOuCPF(Nome, CPF);
        }
    }
}
