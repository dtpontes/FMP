using FMP.ApplicationCore.Interfaces.Repositories;
using FMP.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FMP.Infrastructure.Repositories
{
    public class EFRepository<T> : IRepository<T> where T : class
    {
        protected readonly FisioContext _dbContext;

        public EFRepository(FisioContext dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual T Adicionar(T entity)
        {
            _dbContext.Set<T>().Add(entity);
            _dbContext.SaveChanges();
            return entity;
        }

        public void Atualizar(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.SaveChanges();
            
        }
    

        public IEnumerable<T> Buscar(System.Linq.Expressions.Expression<Func<T, bool>> predicado)
        {
            return _dbContext.Set<T>().Where(predicado).AsEnumerable();
        }

        public virtual T ObterPorId(int id)
        {
            return _dbContext.Set<T>().Find(id);
        }

        public IEnumerable<T> ObterTodos()
        {
            return _dbContext.Set<T>().AsEnumerable();
        }

        public void Remover(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
            _dbContext.SaveChanges();
        }
    }
}
