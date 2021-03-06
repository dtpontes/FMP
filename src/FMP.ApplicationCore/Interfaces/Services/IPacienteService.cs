﻿using FMP.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace FMP.ApplicationCore.Interfaces.Services
{
    public interface IPacienteService
    {

        Paciente Adicionar(Paciente entity);

        void Atualizar(Paciente entity);

        IEnumerable<Paciente> ObterTodos();

        Paciente ObterPorId(int id);

        IEnumerable<Paciente> Buscar(Expression<Func<Paciente, bool>> predicado);

        void Remover(Paciente entity);

        IEnumerable<Paciente> ObterPorNomeECPF(string Nome, string CPF);

        IEnumerable<Estado> ObterTodosEstados();

        IEnumerable<Cidade> ObterCidadesPorIdEstado(int IdEstado);

        void UtilizarCredito(Paciente entity);

        void AdicionarCredito(PacienteCredito entity);

        IEnumerable<PacienteDebito> ObterAtendimentosPorData(DateTime data);
    }
}
