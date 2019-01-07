using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Text;
using FMP.ApplicationCore.Entities;
using FMP.ApplicationCore.Interfaces.Repositories;
using FMP.ApplicationCore.Interfaces.Services;

namespace FMP.ApplicationCore.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienterepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienterepository = clienteRepository;
        }

        public Cliente Adicionar(Cliente entity)
        {
            return _clienterepository.Adicionar(entity);
        }

        public void Atualizar(Cliente entity)
        {
           _clienterepository.Atualizar(entity);
        }

        public IEnumerable<Cliente> Buscar(Expression<Func<Cliente, bool>> predicado)
        {
            return _clienterepository.Buscar(predicado);
        }

        public Cliente ObterPorId(int id)
        {
            return _clienterepository.ObterPorId(id);
        }

        public IEnumerable<Cliente> ObterTodos()
        {
            return _clienterepository.ObterTodos();
        }

        public void Remover(Cliente entity)
        {
             _clienterepository.Remover(entity);
        }
    }
}
