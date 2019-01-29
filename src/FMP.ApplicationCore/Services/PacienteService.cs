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
        private readonly IPacienteRepository _pacienteRepository;
        private readonly IEstadoRepository _estadoRepository;
        private readonly ICidadeRepository _cidadeRepository;
        private readonly IPacienteDebitoRepository _pacienteDebitoRepository;

        public PacienteService( IPacienteRepository pacienteRepository,
                                IEstadoRepository estadoRepository,
                                ICidadeRepository cidadeRepository,
                                IPacienteDebitoRepository pacienteDebitoRepository)
        {
            _pacienteRepository = pacienteRepository;
            _estadoRepository = estadoRepository;
            _cidadeRepository = cidadeRepository;
            _pacienteDebitoRepository = pacienteDebitoRepository;
        }

        public Paciente Adicionar(Paciente entity)
        {
            return _pacienteRepository.Adicionar(entity);
        }

        public void Atualizar(Paciente entity)
        {
            _pacienteRepository.Atualizar(entity);
        }

        public IEnumerable<Paciente> Buscar(Expression<Func<Paciente, bool>> predicado)
        {
            return _pacienteRepository.Buscar(predicado);
        }

        public Paciente ObterPorId(int id)
        {
            return _pacienteRepository.ObterPorId(id);
        }

        public IEnumerable<Paciente> ObterTodos()
        {
            return _pacienteRepository.ObterTodos();
        }

        public void Remover(Paciente entity)
        {
            _pacienteRepository.Remover(entity);
        }

        public IEnumerable<Paciente> ObterPorNomeECPF(string Nome, string CPF)
        {
            return _pacienteRepository.ObterPorNomeOuCPF(Nome, CPF);
        }

        public IEnumerable<Estado> ObterTodosEstados()
        {
            return _estadoRepository.ObterTodos();
        }

        public IEnumerable<Cidade> ObterCidadesPorIdEstado(int IdEstado)
        {
            return _cidadeRepository.ObterporIdEstado(IdEstado);
        }

        public void UtilizarCredito(Paciente entity)
        {
            entity.Creditos = entity.Creditos - 1;
            _pacienteRepository.Atualizar(entity);

            PacienteDebito pacienteDebito = new PacienteDebito();
            pacienteDebito.Data = DateTime.Now;
            pacienteDebito.PacienteId = entity.PacienteId;
            pacienteDebito.QtdCreditos = 1;
            _pacienteDebitoRepository.Adicionar(pacienteDebito);
        }
    }
}
